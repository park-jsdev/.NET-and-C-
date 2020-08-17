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

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int random_number = 0;
            int number = Convert.ToInt32(textBox1.Text.Trim());

            SaveFileDialog save_file = new SaveFileDialog();
            save_file.ShowDialog();
            string file_path = save_file.FileName;

            StreamWriter output_file = File.CreateText(file_path);
            while (number > 0)
            {
                random_number = random.Next(1, 100);
                output_file.WriteLine(random_number.ToString());
                number--;
            }
            output_file.Close();
            MessageBox.Show("File Saved at: " + file_path);
        }
    }
}
