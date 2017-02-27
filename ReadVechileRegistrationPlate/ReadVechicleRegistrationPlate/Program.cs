using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ReadVechicleRegistrationPlate
{
    class Program
    {
        private static bool plateWasFound = false;

        static void Main(string[] args)
        {
            plateWasFound = false;
            var task = Task.Factory.StartNew(() => RunAPLR());
            Task.WaitAll(new[] {task});

            Console.WriteLine("Proceso finalizado");
            Console.ReadKey();
        }

        private static void RunAPLR()
        {
            var basePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            var exePath = string.Format(@"{0}\ALPR\alpr.exe", basePath);
            var imagePath = string.Format(@"{0}\ALPR\car.jpeg", basePath);
            var additionalParams = "-c eu";



            string genArgs = string.Format("{0} {1}", imagePath, additionalParams);
            string pathToFile = exePath;
            var process = new Process();
            try
            {
                process.StartInfo.FileName = pathToFile;
                process.StartInfo.Arguments = genArgs;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += (sender, a) => ProcessAPLRResponse(a.Data);
                process.Start();
                process.BeginOutputReadLine();

                while (!process.HasExited)
                    Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void ProcessAPLRResponse(string data)
        {
            if (string.IsNullOrWhiteSpace(data) || plateWasFound)
                return;

            var parts = data.Split('\t');
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            var carPlate = rgx.Replace(parts[0], "").Trim();
            if (carPlate.Length == 6)
            {
                plateWasFound = true;
                Console.WriteLine("Patente Encontrada: {0}", carPlate);
            }
        }
    }
}
