using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AsyncAwaitUsage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task = CountChar();
            //task.Start();
            int count = await task;
            MessageBox.Show(count.ToString());

        }



        private async Task<int> CountChar()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\Razj\\Desktop\\websites.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                await Task.Delay(10000);
            }
            return count;




        }
    }
}
