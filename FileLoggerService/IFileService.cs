using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileLoggerService
{
    public interface IFileService
    {
        public void Save(FileContent fileContent);
        public string GetFileContent();
    }
}
