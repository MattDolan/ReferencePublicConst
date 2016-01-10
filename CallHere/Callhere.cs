using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclareHere;

namespace CallHere
{
    public partial class Callhere : Form
    {
        public Callhere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeclareHere.DeclareHere.szValue);
        }
    }
}
