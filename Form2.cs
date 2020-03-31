using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Plane plane;
        public Form2(int PlaneId, Airport airport)
        {
            InitializeComponent();
            plane = airport.planes.Find(u => u.ID == PlaneId);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
