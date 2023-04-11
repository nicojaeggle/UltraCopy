using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraCopyGUI
{
    internal partial class SourceEditor : Form
    {
        Models.SingleSourceConfig _source { get; set; }
        public SourceEditor(Models.SingleSourceConfig source)
        {
            this.Text = "Edit Source " + source.SourceName;
            _source = source;
            InitializeComponent();

            ReloadGrid();
        }

        void ReloadGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in _source.Jobs)
            {
                dataGridView1.Rows.Add(item.JobName);
            }
        }

        private void SourceEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var jobAddPrompt = Prompt.Show("Add new Job", "");

            if (jobAddPrompt.IsT0)
            {
                _source.Jobs.Add(new Models.SingleJobConfig()
                {
                    JobName = jobAddPrompt.Value as string
                });
            }

            ReloadGrid();
        }
    }
}
