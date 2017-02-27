using System.IO;

namespace VehicleRegistrationPlate.Core.Interfaces
{
    public interface ICarRegistrationPlateReader
    {
        string GetPlate(MemoryStream data);
        string GetPlate(string path);
    }
}
