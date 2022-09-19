using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "odaberi Yes/No/Cancel";
            string naslov = "Odaberi nesto...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rezultat = MessageBox.Show(poruka, naslov,buttons, ikona);

            switch (rezultat)
                {
                case DialogResult.Yes:
                    textBoxRezultat.Text = "da";
                    break;

                case DialogResult.No:
                    textBoxRezultat.Text = "ne";
                    break ;
                case DialogResult.Cancel:
                    textBoxRezultat.Text = "cancel";
                    break;
            }

        }
    }
}
