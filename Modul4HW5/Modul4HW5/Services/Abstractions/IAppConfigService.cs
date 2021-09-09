using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW5.Services.Abstractions
{
    public interface IAppConfigService
    {
        public string ConnectionString { get; }
    }
}
