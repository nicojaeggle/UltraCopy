using OneOf;
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
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        public static OneOf<string, OneOf.Types.No> Show(string title, string? placeholder)
        {
            var _p = new Prompt();
            _p.Text = title;
            _p.textBox1.Text = placeholder;
            var dia = _p.ShowDialog();
            if (dia == DialogResult.OK)
            {
                return _p.textBox1.Text ?? string.Empty;
            }
            else
            {
                return new OneOf.Types.No();
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
