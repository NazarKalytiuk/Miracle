using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Miracle.Models;
using Miracle.Models.Helpers;
using System.Runtime.Serialization.Json;
using System.IO;
using Miracle.Service;

namespace Miracle.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public void SaveData(Message m)
        {
            var path = $"C:\\MiracleDB\\{m.Name}.json";
            File.WriteAllText(path, m.Data);
        }

        public Message LoadData(string s)
        {
            string fileContent = File.ReadAllText($"C:\\MiracleDB\\{s}.json");
            return new Message { Name = s, Data = fileContent };
        }
    }
}
