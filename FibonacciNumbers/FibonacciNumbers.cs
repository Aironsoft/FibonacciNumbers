using System;
using System.Windows.Forms;
using System.Threading;//для Thread.Sleep()

namespace FibonacciNumbers
{
    public partial class FibonacciNumbers : Form
    {
        public FibonacciNumbers()
        {
            InitializeComponent();
            write = rtbWrite;
            progress = pbProgress;
        }
        
        int count = 0;


        public delegate void RTB(string s);
        RTB write;
        public delegate void PB(int i);
        PB progress;


        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                count = Convert.ToInt32(tbCount.Text);
            }
            catch
            {
                MessageBox.Show("Неверное выражение в поле количества чисел");
            }

            rtbOutput.Text = "";
            backgroundWorker.RunWorkerAsync();
        }


        public void rtbWrite(string s)
        {
            rtbOutput.Text += s;
        }

        public void pbProgress(int i)
        {
            if (i != 0)
                progressBar.Value = (int)(progressBar.Maximum * i / count);
            else
                progressBar.Value = progressBar.Maximum;
        }


        public void Computing()
        {
            Invoke(progress, new object[] { 0 });

            Double fib1 = 1, fib2=1;

            if(count==1)
            {
                Invoke(write, new object[] { fib1.ToString() });
                Invoke(progress, new object[] { 1 });
            }

            else if(count == 2)
            {
                Invoke(write, new object[] { fib1.ToString() });
                Invoke(progress, new object[] { count/2 });
                Thread.Sleep(200);

                Invoke(write, new object[] { "  " + fib2.ToString() });
                Invoke(progress, new object[] { count });
            }

            else if(count>2)
            {
                Double resFib;

                Invoke(write, new object[] { fib1.ToString() } );
                Invoke(progress, new object[] { 1 });
                Thread.Sleep(200);

                Invoke(write, new object[] { "  " + fib2.ToString() });
                Invoke(progress, new object[] { 2 });

                for (int i=3; i<= count; i++)
                {
                    resFib = fib1;
                    fib1 += fib2;
                    fib2 = resFib;
                    Thread.Sleep(200);

                    Invoke(progress, new object[] { i });
                    Invoke(write, new object[] { "  " + fib1.ToString() });
                }

            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Computing();
        }
    }
}
