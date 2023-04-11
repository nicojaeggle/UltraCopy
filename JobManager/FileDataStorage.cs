using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraCopyGUI.Models;

namespace UltraCopyGUI.JobManager
{
    internal class FileDataStorage : IDataStorage
    {
        readonly string _path;
        public FileDataStorage(string file)
        {
            _path = file;
            if (!System.IO.File.Exists(_path))
            {
                System.IO.File.WriteAllText(_path, "{}");
            }
        }
            
        public ConfigurationRoot ReadConfiguration()
        {
            try
            {
                string? data = System.IO.File.ReadAllText(_path);
                return System.Text.Json.JsonSerializer.Deserialize<Models.ConfigurationRoot>(data ?? "{}") ?? new();
            }
            catch (Exception)
            {
                return new();
            }
        }

        public void WriteConfiguration(ConfigurationRoot config)
        {
            try
            {
                string data = System.Text.Json.JsonSerializer.Serialize(config);
                System.IO.File.WriteAllText(_path, data);
            }
            catch (Exception)
            {
            }
        }
    }
}
