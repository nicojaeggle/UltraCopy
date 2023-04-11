namespace UltraCopyGUI
{
    partial class RootOverview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddSource = new Button();
            btnRemoveSource = new Button();
            dataGridView1 = new DataGridView();
            Sourcename = new DataGridViewTextBoxColumn();
            Path = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            ultraCopyToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddSource
            // 
            btnAddSource.Location = new Point(12, 636);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(277, 68);
            btnAddSource.TabIndex = 0;
            btnAddSource.Text = "Add Source";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnRemoveSource
            // 
            btnRemoveSource.Enabled = false;
            btnRemoveSource.Location = new Point(484, 636);
            btnRemoveSource.Name = "btnRemoveSource";
            btnRemoveSource.Size = new Size(277, 68);
            btnRemoveSource.TabIndex = 1;
            btnRemoveSource.Text = "Remove Source";
            btnRemoveSource.UseVisualStyleBackColor = true;
            btnRemoveSource.Click += btnRemoveSource_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sourcename, Path });
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(749, 599);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Sourcename
            // 
            Sourcename.HeaderText = "Sourcename";
            Sourcename.MinimumWidth = 6;
            Sourcename.Name = "Sourcename";
            Sourcename.ReadOnly = true;
            Sourcename.Width = 250;
            // 
            // Path
            // 
            Path.HeaderText = "Path";
            Path.MinimumWidth = 6;
            Path.Name = "Path";
            Path.ReadOnly = true;
            Path.Width = 450;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ultraCopyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(773, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ultraCopyToolStripMenuItem
            // 
            ultraCopyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            ultraCopyToolStripMenuItem.Name = "ultraCopyToolStripMenuItem";
            ultraCopyToolStripMenuItem.Size = new Size(96, 24);
            ultraCopyToolStripMenuItem.Text = "Navigation";
            ultraCopyToolStripMenuItem.Click += ultraCopyToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(124, 26);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // RootOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 716);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemoveSource);
            Controls.Add(btnAddSource);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RootOverview";
            Text = "UltraCopy";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSource;
        private Button btnRemoveSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Sourcename;
        private DataGridViewTextBoxColumn Path;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ultraCopyToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}