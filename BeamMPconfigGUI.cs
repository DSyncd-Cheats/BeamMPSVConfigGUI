using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeamMPconfigGUI
{
    public partial class BeamMPconfigGUI : Form
    {
        public string map = "/levels/gridmap/info.json";
        public BeamMPconfigGUI()
        {
            InitializeComponent();
        }

        private void BeamMPconfigGUI_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            textBox5.Visible = false;
            label11.Visible = false;
            comboBox2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label10.Visible = true;
                textBox5.Visible = true;
                label11.Visible = true;
                comboBox2.Visible = true;
            }
            else
            {
                label10.Visible = false;
                textBox5.Visible = false;
                label11.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        } 

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(map);
            if (comboBox1.Text == "Gridmap")
            {
                map = "/levels/gridmap/info.json";
            }
            else if (comboBox1.Text == "Automation Test Track")
            {
                map = "/levels/automation_test_track/info.json";
            }
            else if (comboBox1.Text == "East Coast USA")
            {
                map = "/levels/east_coast_usa/info.json";
            }
            else if (comboBox1.Text == "Hirochi Raceway")
            {
                map = "/levels/hirochi_raceway/info.json";
            }
            else if (comboBox1.Text == "Italy")
            {
                map = "/levels/italy/info.json";
            }
            else if (comboBox1.Text == "Jungle Rock Island")
            {
                map = "/levels/jungle_rock_island/info.json";
            }
            else if (comboBox1.Text == "Port")
            {
                map = "/levels/port/info.json";
            }
            else if (comboBox1.Text == "Small Island")
            {
                map = "/levels/small_island/info.json";
            }
            else if (comboBox1.Text == "Small Grid")
            {
                map = "/levels/smallgrid/info.json";
            }
            else if (comboBox1.Text == "Utah")
            {
                map = "/levels/utah/info.json";
            }
            else if (comboBox1.Text == "West Coast USA")
            {
                map = "/levels/west_coast_usa/info.json";
            }
            else if (comboBox1.Text == "Driver Training")
            {
                map = "/levels/driver_training/info.json";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string config = "Debug = " + comboBox2.Text + Environment.NewLine +
            "Private = " + comboBox3.Text + Environment.NewLine +
            "Port = " + textBox5.Text + Environment.NewLine +
            "Cars = " + textBox2.Text + Environment.NewLine +
            "MaxPlayers = " + textBox3.Text + Environment.NewLine +
            "Map = " + "\"" + map + "\"" + Environment.NewLine +
            "Name = " + "\"" + textBox4.Text + "\"" + Environment.NewLine +
            "use = \"Resources\"" + Environment.NewLine +
            "AuthKey = " + "\"" + textBox1.Text + "\"";

           using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CFG files (*.cfg)|*.cfg|AllFiles (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, config);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
