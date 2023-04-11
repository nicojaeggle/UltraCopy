namespace UltraCopyGUI
{
    public partial class RootOverview : Form
    {
        public RootOverview()
        {
            InitializeComponent();

            Program.JobManager.OnConfigChanged += JobManager_OnConfigChanged;
            JobManager_OnConfigChanged(Program.JobManager);
        }

        private void JobManager_OnConfigChanged(JobManager.JobManager obj)
        {
            this.dataGridView1.Rows.Clear();
            foreach (var item in obj.ConfigurationRoot.sources)
            {
                this.dataGridView1.Rows.Add((object)item.SourceName, (object)item.SourcePath);
            }
        }

        private void btnAddSource_Click(object sender, EventArgs e)
        {
            var sourceNamePromptResult = Prompt.Show("Name", "");

            sourceNamePromptResult.Switch(sourceName =>
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var folderSelectResult = folder.ShowDialog();

                if (folderSelectResult == DialogResult.OK)
                {
                    Program.JobManager.AddSource(sourceName, folder.SelectedPath);
                }
            }, cancel => { });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveSource_Click(object sender, EventArgs e)
        {
            string? selectedValue = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (selectedValue is null)
            {
                return;
            }

            Program.JobManager.ConfigurationRoot.sources.Remove(
                Program.JobManager.ConfigurationRoot.sources.First(x => x.SourceName == selectedValue));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string? selectedValue = null;
            try
            {
                selectedValue = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
            this.btnRemoveSource.Enabled = selectedValue is not null;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UltraCopy\nVersion 1.0.0\nAuthor Nico Jäggle", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ultraCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? selectedValue = null;
            try
            {
                selectedValue = this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }

            if (selectedValue is null)
            {
                return;
            }

            var source = Program.JobManager.ConfigurationRoot.sources.First(x => x.SourceName == selectedValue);
            var sourceEditor = new SourceEditor(source);
            sourceEditor.Show();

        }
    }
}