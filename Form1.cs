using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image img = Clipboard.GetImage();
             
            img.Save("destination"); //destination for saving captured screen
            this.Show();

        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && (e.KeyCode.ToString() == "E"))
            {
                this.Hide();
                System.Threading.Thread.Sleep(1000);
                SendKeys.Send("{PRTSC}");
                Image img = Clipboard.GetImage();

                img.Save("destination"); //destination for saving captured screen
                this.Show();

            }
        }
    }
}
