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

namespace RandomNumberFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            int numbers = 0;
            int total = 0;

            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.ShowDialog();

            string file_path = open_file_dialog.FileName;

            StreamReader input_file = new StreamReader(file_path);

            listBox1.Items.Clear();

            while (!input_file.EndOfStream)
            {
                numbers = Convert.ToInt32(input_file.ReadLine());
                total += numbers;
                listBox1.Items.Add(numbers.ToString());
                count++;
            }
            label_total.Text = total.ToString();
            label_count.Text = count.ToString();
        }
    }
}
