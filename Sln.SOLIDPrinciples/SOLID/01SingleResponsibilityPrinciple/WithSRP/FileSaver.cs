using System.IO;

namespace SOLID.SingleResponsibilityPrinciple.WithSRP
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}

