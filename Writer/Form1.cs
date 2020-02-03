using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Writer
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Ana Maria\Desktop\enrollment.txt", true);
            try
            {
                writer.WriteLine("Name: " + txtName.Text);
                writer.WriteLine("Age: " + txtAge.Text);
                writer.WriteLine("Birth date: " + txtBirth.Text);
                writer.WriteLine("Career: " + txtCareer.Text);
                writer.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Please introduce a valid text");
            }
            writer.Close();
        }
    }
}
