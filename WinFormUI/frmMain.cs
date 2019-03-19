using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmMain : Form
    {
        int time1 = 300;
        int time2 = 200;
        int time3 = 150;
        
        public frmMain()
        {
            InitializeComponent();
            Worker.log = ricLog;
        }

        private void btnNormalCall_Click(object sender, EventArgs e)
        {
            Worker.ClearLog();
            Worker.Log("Go Normal!");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            DoNormalCall();
            watch.Stop();
            Worker.Log($"{watch.ElapsedMilliseconds} millisecs");
        }

        private void DoNormalCall()
        {
            Worker.DoWork(time1);
            Worker.DoWork(time2);
            Worker.DoWork(time3);
        }

        private  async Task DoCallAsync()
        {
            await Task.Run(()=> Worker.DoWork(time1));
            await Task.Run(() => Worker.DoWork(time2));
            await Task.Run(() => Worker.DoWork(time3));
        }

        private async Task DoCallAsyncParallel()
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => Worker.DoWork(time1)));
            tasks.Add(Task.Run(() => Worker.DoWork(time2)));
            tasks.Add(Task.Run(() => Worker.DoWork(time3)));
            await Task.WhenAll(tasks);
        }

        private async void btnAsyncCall_ClickAsync(object sender, EventArgs e)
        {
            Worker.ClearLog();
            Worker.Log("Go Async!");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await DoCallAsync();
            watch.Stop();
            Worker.Log($"{watch.ElapsedMilliseconds} millisecs");
        }

        private async void btnParallelCall_Click(object sender, EventArgs e)
        {
            Worker.ClearLog();
            Worker.Log("Go AsyncParallel!");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await DoCallAsyncParallel();
            watch.Stop();
            Worker.Log($"{watch.ElapsedMilliseconds} millisecs");
        }
    }

    public class Worker
    {
        public static RichTextBox log { get; set; }
        public static void DoWork(int x)
        {
            Log($"Starting counting to {x}");
            for (int i = 0; i < x; i++)
            {
                Thread.Sleep(10);
            }
            Log($"Task counting to {x} completed.");
        }
        public  static void Log(string v)
        {
            string msg = "\n" + v;
                log.BeginInvoke(new MethodInvoker(() => { log.Text += msg; }));
        }
        public static void ClearLog()
        {
            log.BeginInvoke(new MethodInvoker(() => { log.Text = string.Empty; }));
        }
    }


}
