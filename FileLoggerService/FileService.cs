using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileLoggerService
{
    public class FileService : IFileService
    {
        string fileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + "temp.txt";
        public void Save(FileContent fileContent)
        {
            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine($"Id : {fileContent.Id}, \t Date : {fileContent.Date}, \t Description : {fileContent.Description}.");

            }
        }

        public string GetFileContent()
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            else return string.Empty;
        }
    }
}
