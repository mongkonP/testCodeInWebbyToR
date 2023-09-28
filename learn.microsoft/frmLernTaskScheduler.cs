
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;

namespace learn.microsoft.frm
{

    //https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask?view=net-7.0
    internal class frmLernTaskScheduler:frmBase
    {

        public frmLernTaskScheduler() { Load += (o, e) => { Task.Factory.StartNew(Test01); }; }

        ///<summary>
        ///The following example creates a custom task scheduler that limits the number of threads used by the app. It then launches two sets of tasks and displays information about the task and the thread on which the task is executing.
        /// </summary>
        void Test01()
        {
            // Create a scheduler that uses two threads.
            LimitedConcurrencyLevelTaskScheduler lcts = new LimitedConcurrencyLevelTaskScheduler(2);
            List<Task> tasks = new List<Task>();

            // Create a TaskFactory and pass it our custom scheduler.
            TaskFactory factory = new TaskFactory(lcts);
            CancellationTokenSource cts = new CancellationTokenSource();

            // Use our factory to run a set of tasks.
            Object lockObj = new Object();
            int outputItem = 0;

            for (int tCtr = 0; tCtr <= 4; tCtr++)
            {
                int iteration = tCtr;
                Task t = factory.StartNew(() => {
                    for (int i = 0; i < 1000; i++)
                    {
                        lock (lockObj)
                        {
                            richTextBox1.Write("{0} in task t-{1} on thread {2}   ",
                                          i, iteration, Thread.CurrentThread.ManagedThreadId);
                            outputItem++;
                            if (outputItem % 3 == 0)
                                richTextBox1.WriteLine();
                        }
                    }
                }, cts.Token);
                tasks.Add(t);
            }
            // Use it to run a second set of tasks.
            for (int tCtr = 0; tCtr <= 4; tCtr++)
            {
                int iteration = tCtr;
                Task t1 = factory.StartNew(() => {
                    for (int outer = 0; outer <= 10; outer++)
                    {
                        for (int i = 0x21; i <= 0x7E; i++)
                        {
                            lock (lockObj)
                            {
                                richTextBox1.Write("'{0}' in task t1-{1} on thread {2}   ",
                                              Convert.ToChar(i), iteration, Thread.CurrentThread.ManagedThreadId);
                                outputItem++;
                                if (outputItem % 3 == 0)
                                    richTextBox1.WriteLine();
                            }
                        }
                    }
                }, cts.Token);
                tasks.Add(t1);
            }

            // Wait for the tasks to complete before displaying a completion message.
            Task.WaitAll(tasks.ToArray());
            cts.Dispose();
            richTextBox1.WriteLine("\n\nSuccessful completion.");
        }

    }
}
