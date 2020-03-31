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
    public partial class Form1 : Form
    {
        private Airport airport;
        public Form1()
        {
            airport = new Airport();
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                label3.Text = "Вместимость";
                label3.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Text = "Грузоподъёмность";
                label3.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label3.Text = "Грузоподъёмность";
                label3.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                Types type = Types.Passenger;
                if (radioButton1.Checked)
                    type = Types.Passenger;
                else if (radioButton2.Checked)
                    type = Types.Cargo;
                else if (radioButton3.Checked)
                    type = Types.War;
                Plane plane = new Plane(Convert.ToInt32(textBox1.Text), type, textBox2.Text, Convert.ToInt32(textBox3.Text), dateTimePicker1.Value);
                airport.planes.Add(plane);
                listView1.Items.Add(plane.ToString());
            }
            else
            {
                MessageBox.Show("Введите полные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(airport.planes[listView1.SelectedItems[0].Index].ID, airport);
            form.Show();
            this.Hide();
        }
    }
}
