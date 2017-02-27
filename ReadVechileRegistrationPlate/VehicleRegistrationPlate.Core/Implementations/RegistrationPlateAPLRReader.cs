using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using VehicleRegistrationPlate.Common.Resources;
using VehicleRegistrationPlate.Core.Interfaces;

namespace VehicleRegistrationPlate.Core.Implementations
{
    public class RegistrationPlateAPLRReader : ICarRegistrationPlateReader
    {
        private readonly string _workingArea;
        private readonly string _aplrDirectory;
        private readonly string _tempDir;
        private string _plateCar;

        public RegistrationPlateAPLRReader(string workingFolder)
        {
            if(string.IsNullOrWhiteSpace( workingFolder))
                throw new Exception("No se ha especificado el area de trabajo");

            _workingArea = workingFolder;
            _tempDir = string.Format(@"{0}\TEMP\", _workingArea);
            _aplrDirectory = string.Format(@"{0}\{1}\", _workingArea, "APLR");

            if (!isAPLRInstalled())
                installAPLR();

            if(!isTempDirCreated())
                createTempDir();
        }

        public string GetPlate(string path)
        {
            _plateCar = string.Empty;
            var task = Task.Factory.StartNew(() => RunProcess(path));
            Task.WaitAll(new Task[] {task});
            return _plateCar;
        }

        public string GetPlate(MemoryStream data)
        {
            var fileId = Guid.NewGuid().ToString() + ".tmp";
            var path = string.Format(@"{0}\{1}", _tempDir, fileId);
            data.WriteTo(new FileStream(path, FileMode.CreateNew));
            return GetPlate(path);
        }

        private void RunProcess(string imagePath)
        {
            var exePath = string.Format(@"{0}\alpr.exe", _aplrDirectory);
            var additionalParams = "-c eu";
            string genArgs = string.Format("{0} {1}", imagePath, additionalParams);
            string pathToFile = exePath;
            var process = new Process();
           
            process.StartInfo.FileName = pathToFile;
            process.StartInfo.Arguments = genArgs;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.OutputDataReceived += (sender, a) => ProcessAPLRResponse(a.Data);
            process.Start();
            process.BeginOutputReadLine();

            while (!process.HasExited)
                Thread.Sleep(1000);
            
        }

        private void ProcessAPLRResponse(string data)
        {
            if (string.IsNullOrWhiteSpace(data) || !string.IsNullOrWhiteSpace(_plateCar))
                return;

            var parts = data.Split('\t');
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            var carPlate = rgx.Replace(parts[0], "").Trim();
            if (carPlate.Length == 6)
                _plateCar = carPlate;
        }

        private bool isAPLRInstalled()
        {
            return Directory.Exists(_aplrDirectory);
        }

        private bool isTempDirCreated()
        {
            return Directory.Exists(_tempDir);
        }

        private void installAPLR()
        {
            var zipPath = string.Format(@"{0}\APLR.zip", _workingArea);
            File.WriteAllBytes(zipPath, APIS.ALPR);
            ZipFile.ExtractToDirectory(zipPath, _aplrDirectory);
        }

        private void createTempDir()
        {
            Directory.CreateDirectory(_tempDir);
        }
    }
}
