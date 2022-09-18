using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmytechDbtool.ViewModels
{
    public class TestConnectionVM
    {
        public string? ServerName { get; set; }
        public string? ServerType { get; set; }
        public string? AuthenticationType { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? DataBaseName { get; set; }
        public string? Port { get; set; }

    }
}
