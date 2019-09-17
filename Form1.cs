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

namespace numberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UInt64 doCalculations(UInt64 number)
        {
            if (number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return (number * 3) + 1;
            }
        }

        public void setProgress(int progress)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(setProgress), new object[] { progress });
                return;
            }
            progressBar1.Value = progress;
        }

        private void singleThread()
        {
            Stream fs; // fileStream as a stream
            StreamWriter sw;
            try
            {
                fs = saveFileDialog1.OpenFile();
                sw = new StreamWriter(fs, Encoding.ASCII);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The save file is not correct! {ex.Message}", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            UInt64 num;
            for (UInt64 i = 0; i < numberBox.Value; i++)
            {
                num = i;
                sw.Write(i);
                while (num > 1)
                {
                    num = doCalculations(num);
                    sw.Write(",");
                    sw.Write(num);
                }
                sw.Write("\n");
                if (i % 2 == 0)
                {
                    setProgress((int)((float)i / (float)numberBox.Value * 100));
                }
            }
            setProgress(100);
            sw.Close(); // also closeses underlying stream.
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            

            progressBar1.Maximum = 100;
            if (stRadio.Checked)
            {
                Task.Run( singleThread );
            }            
        }

        private void ChoseFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
