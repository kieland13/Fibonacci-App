using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciApp
{
    public partial class AsynchronousTestForm : Form
    {
        int[] fibArray = new int[3];

        public AsynchronousTestForm()
        {
            InitializeComponent();
        }

        //Start asynchronous calls to Fibonacci
        private async void startButton_Click(object sender, EventArgs e)
        {
            
            fibArray[0] = int.Parse(firstNmbrBox.Text);

            fibArray[1] = fibArray[0] + 1;

            secondNmbrBox.Text = fibArray[1].ToString();

            fibArray[2] = fibArray[0] + 2;

            thirdNmbrBox.Text = fibArray[2].ToString();

            resultsBox.Text = "Starting Task to calculate Fibonacci(" + fibArray[0] + ")\r\n";

            //create Task to perform Fibonacci(firstNumberResult) calculation in thread
            Task<TimeData> task1 = Task.Run(() => StartFibonacci(fibArray[0]));

            resultsBox.AppendText("Starting Task to calculate Fibonacci(" + fibArray[1] + ")\r\n");

            //create Task to perform Fibonacci(secondNumberResult) calculation in thread
            Task<TimeData> task2 = Task.Run(() => StartFibonacci(fibArray[1]));

            resultsBox.AppendText("Starting Task to calculate Fibonacci(" + fibArray[2] + ")\r\n");

            //create Task to perform Fibonacci(thirdNumberResult) calculation in thread
            Task<TimeData> task3 = Task.Run(() => StartFibonacci(fibArray[2]));

            //wait for all three to complete
            TimeData[] timeArray = await Task.WhenAll(task1, task2, task3);

            //determine time that first thread started
            DateTime startTime;

            if (timeArray[0].StartTime < timeArray[1].StartTime && timeArray[0].StartTime < timeArray[2].StartTime)
            {
                startTime = timeArray[0].StartTime;
            }
            else if (timeArray[1].StartTime < timeArray[0].StartTime && timeArray[1].StartTime < timeArray[2].StartTime)
            {
                startTime = timeArray[1].StartTime;
            }
            else
            {
                startTime = timeArray[2].StartTime;
            }

            //determine time that last thread started
            DateTime endTime;

            if (timeArray[0].EndTime > timeArray[1].EndTime && timeArray[0].EndTime > timeArray[2].EndTime)
            {
                endTime = timeArray[0].EndTime;
            }
            else if (timeArray[1].EndTime > timeArray[0].EndTime && timeArray[1].EndTime > timeArray[2].EndTime)
            {
                endTime = timeArray[1].EndTime;
            }
            else
            {
                endTime = timeArray[2].EndTime;
            }

            //display total time for calculations
            double totalMinutes = (endTime - startTime).TotalMinutes;
            resultsBox.AppendText($"Total calculation time = {totalMinutes:F6} minutes \r\n");
        }

        //starts a call to Fibonacci and captures start/end times
        TimeData StartFibonacci(int n)
        {
            //creates a TimeData object to store start/end times
            var result = new TimeData();

            AppendText($"Calculating fibonacci({n})");
            result.StartTime = DateTime.Now;
            long fibonacciValue = Fibonacci(n);
            result.EndTime = DateTime.Now;
            double minutes = (result.EndTime - result.StartTime).TotalMinutes;

            AppendText($"Fibonacci({n}) = {fibonacciValue}\r\nCalculation time = {minutes:F6} minutes\r\n");

            return result;
        }

        //Recursively calculates Fibonacci numbers
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        //append text to resultsBox in UI thread
        public void AppendText(string text)
        {
            if (InvokeRequired) //not GUI thread, so add to GUI thread
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else //GUI thread so append text
            {
                resultsBox.AppendText(text + "\r\n");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNmbrBox.Text = "";
            secondNmbrBox.Text = "";
            thirdNmbrBox.Text = "";
            resultsBox.Text = "";
        }
    }
}
