using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCopyGUI.JobManager
{
    internal interface IDataStorage
    {
        public Models.ConfigurationRoot ReadConfiguration();
        public void WriteConfiguration(Models.ConfigurationRoot config);
    }
}
