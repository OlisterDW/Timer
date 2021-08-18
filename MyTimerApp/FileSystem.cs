using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimerApp
{
    class FileSystem
    {
        public static void WriteToFile(string textFilePath, string userResult)
        {
            var writer = new StreamWriter(textFilePath, false, Encoding.UTF8);
            writer.WriteLine(userResult);
            writer.Close();
        }

        public static bool Exist(string filePath)
        {
            return File.Exists(filePath);
        }

        public static bool JsonEmpty(string filePath)
        {
            return FileSystem.ReadFile(filePath) == "[]\r\n";
        }

        public static string ReadFile(string textFilePath)
        {
            var reader = new StreamReader(textFilePath, Encoding.UTF8);
            string fileValue = reader.ReadToEnd();
            reader.Close();
            return fileValue;
        }

        public static void ClearFile(string FilePath)
        {
            File.WriteAllText(FilePath, "[]\r\n");
        }
    }
}
