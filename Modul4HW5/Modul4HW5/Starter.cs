using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4HW5.Services.Abstractions;

namespace Modul4HW5
{
    public class Starter
    {
        private IAppConfigService _config;

        public Starter(
            IAppConfigService config)
        {
            _config = config;
        }

        public void Run()
        {
            Console.WriteLine("Test Sourcetree");
        }
    }
}
