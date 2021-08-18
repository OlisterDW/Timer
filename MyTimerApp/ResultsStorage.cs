using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTimerApp
{
    class ResultsStorage
    {
        public static string textFilePath = "usersResults.json";


        public static void Append(Result currentResult)
        {

            var userResults = GetResults();
            userResults.Add(currentResult);
            if (userResults.Count > 10)
            {
                userResults.RemoveAt(userResults.Count - 1);
            }
            Save(userResults);
        }


        public static List<Result> GetResults()
        {
            if (!FileSystem.Exist(textFilePath) || FileSystem.JsonEmpty(textFilePath))
            {
                return new List<Result>();
            }
            var fileData = FileSystem.ReadFile(textFilePath);
            var results = JsonConvert.DeserializeObject<List<Result>>(fileData);
            return results;
        }

        public static void ClearUserResults()
        {
            FileSystem.ClearFile(textFilePath);
        }

        public static void Save(List<Result> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults);
            FileSystem.WriteToFile(textFilePath, jsonData);
        }
    }
}
