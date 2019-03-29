using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bizzart_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Pictures vp = new View_Pictures();
            vp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Employee ve = new View_Employee();
            ve.Show();
        }
    }
}
