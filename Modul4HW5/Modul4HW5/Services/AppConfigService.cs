using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Modul4HW5.Configs;
using Newtonsoft.Json;
using Modul4HW5.Services.Abstractions;

namespace Modul4HW5.Services
{
    public class AppConfigService : IAppConfigService
    {
        public AppConfigService()
        {
            var config = GetConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; }

        private AppConfig GetConfig()
        {
            var json = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }
    }
}
