﻿using System.IO;

namespace SOLID.SingleResponsibilityPrinciple.WithGenericSRP
{
    public class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> workReport)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), workReport.ToString());
        }
    }
}
