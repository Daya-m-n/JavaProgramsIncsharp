using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitFramework.utilities
{
    public class JsonReader
    {
        public string ReadJsonFile(string tokenName)
        {
            string currentPath = TestContext.CurrentContext.TestDirectory;
            string projectPath = Directory.GetParent(currentPath).Parent.Parent.FullName;
            string filePath = Path.Combine(projectPath, "utilities", "testData.json");
            string data = File.ReadAllText(filePath);
            JToken jsonObject = JToken.Parse(data);
            return jsonObject.SelectToken(tokenName).Value<string>();
        }

        public string[] ReadJsonDataArray(string tokenName)
        {
            string currentPath = TestContext.CurrentContext.TestDirectory;
            string projectPath = Directory.GetParent(currentPath).Parent.Parent.FullName;
            string filePath = Path.Combine(projectPath, "utilities", "testData.json");
            string data = File.ReadAllText(filePath);
            JToken jsonObject = JToken.Parse(data);
            List<string> str = jsonObject.SelectTokens(tokenName).Values<string>().ToList();
            return str.ToArray();
        }
    }
}
