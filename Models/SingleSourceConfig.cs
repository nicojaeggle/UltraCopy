using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCopyGUI.Models
{
    internal class SingleSourceConfig
    {
        public string SourceName { get; set; }
        public string SourcePath { get; set; }
        public List<SingleJobConfig> Jobs { get; set; } = new();
        public TimeSpan ExecutionInterval { get; set; }
    }
}
