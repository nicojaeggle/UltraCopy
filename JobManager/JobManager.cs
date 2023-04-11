using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCopyGUI.JobManager
{
    internal class JobManager
    {
        public Models.ConfigurationRoot ConfigurationRoot { get; set; }
        public event Action<JobManager> OnConfigChanged;
        readonly IDataStorage _dataStorage;

        public JobManager()
        {
            _dataStorage = new FileDataStorage("C:\\Users\\nico.jaeggle\\Downloads\\demofile.json");
            ReadJobs();
            UpdateJobs();
        }

        public void ReadJobs()
        {
            ConfigurationRoot = _dataStorage.ReadConfiguration();
        }

        public void UpdateJobs()
        {
            _dataStorage.WriteConfiguration(ConfigurationRoot);
            if (OnConfigChanged is not null)
                OnConfigChanged(this);
        }

        public void AddSource(string sourcename, string path)
        {
            ConfigurationRoot?.sources.Add(new Models.SingleSourceConfig() { SourceName = sourcename, SourcePath = path });
            UpdateJobs();
        }
    }
}
