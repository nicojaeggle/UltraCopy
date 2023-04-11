namespace UltraCopyGUI
{
    partial class Prompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOkay = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(12, 45);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(776, 75);
            btnOkay.TabIndex = 0;
            btnOkay.Text = "Ok";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 27);
            textBox1.TabIndex = 1;
            // 
            // Prompt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 135);
            Controls.Add(textBox1);
            Controls.Add(btnOkay);
            Name = "Prompt";
            Text = "Prompt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOkay;
        private TextBox textBox1;
    }
}