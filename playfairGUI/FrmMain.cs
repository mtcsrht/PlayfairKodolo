using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playfairGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            rTxtBText.TextChanged += RTxtBText_TextChanged;
        }

        private void RTxtBText_TextChanged(object sender, EventArgs e)
        {
            string[] ell = rTxtBText.Text.Split(' ');
            foreach (var item in ell)
            {
                if (item.Length > 2 || item.Length < 2)
                {
                    lblTitle.ForeColor = Color.Red;
                }
                else if ((item[0] < 64 || item[0] > 91 || (item[1] < 64 || item[1] > 91)) || char.IsLower(item[0]) || char.IsLower(item[1]))
                {
                    lblTitle.ForeColor = Color.Blue;
                }
                else if (item[0] == item[1])
                {
                    lblTitle.ForeColor = Color.Magenta;
                }
                else
                {
                    lblTitle.ForeColor = Color.Green;
                }


            }
        }
    }
}
