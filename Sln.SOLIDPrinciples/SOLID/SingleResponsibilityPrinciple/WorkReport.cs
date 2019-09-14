using SOLID.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SOLID.SingleResponsibilityPrinciple
{
    public class WorkReport
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
    }
}



/* Problems With This Code
We can add even more features in this class, like the Load or UploadToCloud methods 
because they are all related to our WorkReport, 
but, just because we can doesn’t mean we have to do it.
*/


