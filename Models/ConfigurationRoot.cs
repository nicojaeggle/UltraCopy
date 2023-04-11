using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCopyGUI.Models
{
    internal class ConfigurationRoot
    {
        public List<SingleSourceConfig> sources { get; set; } = new();
    }
}
