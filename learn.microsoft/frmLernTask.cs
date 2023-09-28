
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;

namespace learn.microsoft.frm
{

    //https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=net-7.0
    internal class frmLernTask:frmBase
    {

        public frmLernTask() { Load += (o, e) => { Task.Factory.StartNew(Test06); }; }


        ///<summary>
        ///
        /// </summary>
        void Test01()
        {
            Action<object> action = (object obj) =>
            {
                richTextBox1.WriteLine("Task={0}, obj={1}, Thread={2}",
                Task.CurrentId, obj,
                Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but do not start it.
            Task t1 = new Task(action, "alpha");

            // Construct a started task
            Task t2 = Task.Factory.StartNew(action, "beta");
            // Block the main thread to demonstrate that t2 is executing
            t2.Wait();

            // Launch t1 
            t1.Start();
            richTextBox1.WriteLine("t1 has been launched. (Main Thread={0})",
                              Thread.CurrentThread.ManagedThreadId);
            // Wait for the task to finish.
            t1.Wait();

            // Construct a started task using Task.Run.
            String taskData = "delta";
            Task t3 = Task.Run(() => {
                richTextBox1.WriteLine("Task={0}, obj={1}, Thread={2}",
                                                         Task.CurrentId, taskData,
                                                          Thread.CurrentThread.ManagedThreadId);
            });
            // Wait for the task to finish.
            t3.Wait();

            // Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            // Run it synchronously
            t4.RunSynchronously();
            // Although the task was run synchronously, it is a good practice
            // to wait for it in the event exceptions were thrown by the task.
            t4.Wait();
        }

        ///<summary>
        ///Creating and executing a task
        ///Task instances may be created in a variety of ways. The most common approach, which is available starting with the .NET Framework 4.5, is to call the static Run method. The Run method provides a simple way to start a task using default values and without requiring additional parameters. The following example uses the Run(Action) method to start a task that loops and then displays the number of loop iterations:
        /// </summary>
      async  void Test02()
        {
            await Task.Run(() => {
                // Just loop.
                int ctr = 0;
                for (ctr = 0; ctr <= 1000000; ctr++)
                { }
                richTextBox1.WriteLine("Finished {0} loop iterations",
                                  ctr);
            });
        }

        ///<summary>
        ///An alternative, and the most common method to start a task in .NET Framework 4, is the static TaskFactory.StartNew method. The Task.Factory property returns a TaskFactory object. Overloads of the TaskFactory.StartNew method let you specify parameters to pass to the task creation options and a task scheduler. The following example uses the TaskFactory.StartNew method to start a task. It is functionally equivalent to the code in the previous example.
        /// </summary>
        void Test03()
        {
            Task t = Task.Factory.StartNew(() => {
                // Just loop.
                int ctr = 0;
                for (ctr = 0; ctr <= 1000000; ctr++)
                { }
                richTextBox1.WriteLine("Finished {0} loop iterations",
                                  ctr);
            });
            t.Wait();
        }

        ///<summary>
        ///
        /// </summary>
        void Test04()
        {
            // Wait on a single task with no timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            richTextBox1.WriteLine("taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait();
                richTextBox1.WriteLine("taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                richTextBox1.WriteLine("Exception in taskA.");
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test05()
        {
            // Wait on a single task with a timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            try
            {
                taskA.Wait(1000);       // Wait for 1 second.
                bool completed = taskA.IsCompleted;
                richTextBox1.WriteLine("Task A completed: {0}, Status: {1}",
                                 completed, taskA.Status);
                if (!completed)
                    richTextBox1.WriteLine("Timed out before task A completed.");
            }
            catch (AggregateException)
            {
                richTextBox1.WriteLine("Exception in taskA.");
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test06()
        {
            var tasks = new Task[3];
            var rnd = new Random();
            for (int ctr = 0; ctr <= 2; ctr++)
                tasks[ctr] = Task.Run(() => Thread.Sleep(rnd.Next(500, 3000)));

            try
            {
                int index = Task.WaitAny(tasks);
                richTextBox1.WriteLine("Task #{0} completed first.\n", tasks[index].Id);
                richTextBox1.WriteLine("Status of all tasks:");
                foreach (var t in tasks)
                    richTextBox1.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
            }
            catch (AggregateException)
            {
                richTextBox1.WriteLine("An exception occurred.");
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test07()
        {
            // Wait for all tasks to complete.
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() => Thread.Sleep(2000));
            }
            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ae)
            {
                richTextBox1.WriteLine("One or more exceptions occurred: ");
                foreach (var ex in ae.Flatten().InnerExceptions)
                    richTextBox1.WriteLine("   {0}", ex.Message);
            }

            richTextBox1.WriteLine("Status of completed tasks:");
            foreach (var t in tasks)
                richTextBox1.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
        }

        ///<summary>
        ///
        /// </summary>
        void Test08()
        {
            // Create a cancellation token and cancel it.
            var source1 = new CancellationTokenSource();
            var token1 = source1.Token;
            source1.Cancel();
            // Create a cancellation token for later cancellation.
            var source2 = new CancellationTokenSource();
            var token2 = source2.Token;

            // Create a series of tasks that will complete, be cancelled, 
            // timeout, or throw an exception.
            Task[] tasks = new Task[12];
            for (int i = 0; i < 12; i++)
            {
                switch (i % 4)
                {
                    // Task should run to completion.
                    case 0:
                        tasks[i] = Task.Run(() => Thread.Sleep(2000));
                        break;
                    // Task should be set to canceled state.
                    case 1:
                        tasks[i] = Task.Run(() => Thread.Sleep(2000),
                                 token1);
                        break;
                    case 2:
                        // Task should throw an exception.
                        tasks[i] = Task.Run(() => { throw new NotSupportedException(); });
                        break;
                    case 3:
                        // Task should examine cancellation token.
                        tasks[i] = Task.Run(() => {
                            Thread.Sleep(2000);
                            if (token2.IsCancellationRequested)
                                token2.ThrowIfCancellationRequested();
                            Thread.Sleep(500);
                        }, token2);
                        break;
                }
            }
            Thread.Sleep(250);
            source2.Cancel();

            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ae)
            {
                richTextBox1.WriteLine("One or more exceptions occurred:");
                foreach (var ex in ae.InnerExceptions)
                    richTextBox1.WriteLine("   {0}: {1}", ex.GetType().Name, ex.Message);
            }

            richTextBox1.WriteLine("\nStatus of tasks:");
            foreach (var t in tasks)
            {
                richTextBox1.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
                if (t.Exception != null)
                {
                    foreach (var ex in t.Exception.InnerExceptions)
                        richTextBox1.WriteLine("      {0}: {1}", ex.GetType().Name,
                                          ex.Message);
                }
            }
        }

        ///<summary>
        ///The following example uses the Task(Action) constructor to create tasks that retrieve the filenames in specified directories. All tasks write the file names to a single ConcurrentBag<T> object. The example then calls the WaitAll(Task[]) method to ensure that all tasks have completed, and then displays a count of the total number of file names written to the ConcurrentBag<T> object.
        /// </summary>
      async  void Test09()
        {
            var list = new ConcurrentBag<string>();
            string[] dirNames = { ".", ".." };
            List<Task> tasks = new List<Task>();
            foreach (var dirName in dirNames)
            {
                Task t = new Task(() => {
                    foreach (var path in Directory.GetFiles(dirName))
                        list.Add(path);
                });
                tasks.Add(t);
                t.Start();
            }
            await Task.WhenAll(tasks.ToArray());
            foreach (Task t in tasks)
                richTextBox1.WriteLine("Task {0} Status: {1}", t.Id, t.Status);

            richTextBox1.WriteLine("Number of files read: {0}", list.Count);
        }

        ///<summary>
        ///
        /// </summary>
       async void Test10()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var files = new List<Tuple<string, string, long, DateTime>>();

            var t = new Task(() => {
                string dir = "C:\\Windows\\System32\\";
                object obj = new Object();
                if (Directory.Exists(dir))
                {
                    Parallel.ForEach(Directory.GetFiles(dir),
                    f => {
                        if (token.IsCancellationRequested)
                            token.ThrowIfCancellationRequested();
                        var fi = new FileInfo(f);
                        lock (obj)
                        {
                            files.Add(Tuple.Create(fi.Name, fi.DirectoryName, fi.Length, fi.LastWriteTimeUtc));
                        }
                    });
                }
            }, token);
            t.Start();
            tokenSource.Cancel();
            try
            {
                await t;
                richTextBox1.WriteLine("Retrieved information for {0} files.", files.Count);
            }
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("Exception messages:");
                foreach (var ie in e.InnerExceptions)
                    richTextBox1.WriteLine("   {0}: {1}", ie.GetType().Name, ie.Message);

                richTextBox1.WriteLine("\nTask status: {0}", t.Status);
            }
            finally
            {
                tokenSource.Dispose();
            }
        }

        ///<summary>
        ///
        /// </summary>
      async  void Test11()
        {
            var tasks = new List<Task>();
            Random rnd = new Random();
            Object lockObj = new Object();
            String[] words6 = { "reason", "editor", "rioter", "rental",
                          "senior", "regain", "ordain", "rained" };

            foreach (var word6 in words6)
            {
                Task t = new Task((word) => {
                    Char[] chars = word.ToString().ToCharArray();
                    double[] order = new double[chars.Length];
                    lock (lockObj)
                    {
                        for (int ctr = 0; ctr < order.Length; ctr++)
                            order[ctr] = rnd.NextDouble();
                    }
                    Array.Sort(order, chars);
                    richTextBox1.WriteLine("{0} --> {1}", word,
                                      new String(chars));
                }, word6);
                t.Start();
                tasks.Add(t);
            }
            await Task.WhenAll(tasks.ToArray());
        }

        ///<summary>
        ///Task.Factory Property
        /// </summary>
        void Test12()
        {
            Task[] tasks = new Task[2];
            String[] files = null;
            String[] dirs = null;
            String docsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            tasks[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(docsDirectory));
            tasks[1] = Task.Factory.StartNew(() => dirs = Directory.GetDirectories(docsDirectory));

            Task.Factory.ContinueWhenAll(tasks, completedTasks => {
                richTextBox1.WriteLine("{0} contains: ", docsDirectory);
                richTextBox1.WriteLine("   {0} subdirectories", dirs.Length);
                richTextBox1.WriteLine("   {0} files", files.Length);
            });
        }

        ///<summary>
        ///The following example defines a task that populates an array with 100 random date and time values. It uses the ContinueWith(Action<Task>) method to select the earliest and the latest date values once the array is fully populated.
        /// </summary>
        void Test13()
        {
            var firstTask = Task.Factory.StartNew(() => {
                Random rnd = new Random();
                DateTime[] dates = new DateTime[100];
                Byte[] buffer = new Byte[8];
                int ctr = dates.GetLowerBound(0);
                while (ctr <= dates.GetUpperBound(0))
                {
                    rnd.NextBytes(buffer);
                    long ticks = BitConverter.ToInt64(buffer, 0);
                    if (ticks <= DateTime.MinValue.Ticks | ticks >= DateTime.MaxValue.Ticks)
                        continue;

                    dates[ctr] = new DateTime(ticks);
                    ctr++;
                }
                return dates;
            });

            Task continuationTask = firstTask.ContinueWith((antecedent) => {
                DateTime[] dates = antecedent.Result;
                DateTime earliest = dates[0];
                DateTime latest = earliest;

                for (int ctr = dates.GetLowerBound(0) + 1; ctr <= dates.GetUpperBound(0); ctr++)
                {
                    if (dates[ctr] < earliest) earliest = dates[ctr];
                    if (dates[ctr] > latest) latest = dates[ctr];
                }
                richTextBox1.WriteLine("Earliest date: {0}", earliest);
                richTextBox1.WriteLine("Latest date: {0}", latest);
            });
            // Since a richTextBox1 application otherwise terminates, wait for the continuation to complete.
            continuationTask.Wait();
        }

        ///<summary>
        ///
        /// </summary>
        void Test14()
        {
            Action success = () => richTextBox1.WriteLine("Task={0}, Thread={1}: Begin successful transaction",
                                                Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            Action failure = () =>
            {
                richTextBox1.WriteLine("Task={0}, Thread={1}: Begin transaction and encounter an error",
                                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                throw new InvalidOperationException("SIMULATED EXCEPTION");
            };

            Action<Task> commit = (antecendent) => richTextBox1.WriteLine("Task={0}, Thread={1}: Commit transaction",
                                                                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            Action<Task> rollback = (antecendent) =>
            {
                // "Observe" your antecedent's exception so as to avoid an exception
                // being thrown on the finalizer thread
                var unused = antecendent.Exception;

                richTextBox1.WriteLine("Task={0}, Thread={1}: Rollback transaction",
                      Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            };

            // Successful transaction - Begin + Commit
            richTextBox1.WriteLine("Demonstrating a successful transaction");

            // Initial task
            // Treated as "fire-and-forget" -- any exceptions will be cleaned up in rollback continuation
            Task tran1 = Task.Factory.StartNew(success);

            // The following task gets scheduled only if tran1 completes successfully
            var commitTran1 = tran1.ContinueWith(commit, TaskContinuationOptions.OnlyOnRanToCompletion);

            // The following task gets scheduled only if tran1 DOES NOT complete successfully
            var rollbackTran1 = tran1.ContinueWith(rollback, TaskContinuationOptions.NotOnRanToCompletion);

            // For demo purposes, wait for the sample to complete
            commitTran1.Wait();

            // -----------------------------------------------------------------------------------

            // Failed transaction - Begin + exception + Rollback
            richTextBox1.WriteLine("\nDemonstrating a failed transaction");

            // Initial task
            // Treated as "fire-and-forget" -- any exceptions will be cleaned up in rollback continuation
            Task tran2 = Task.Factory.StartNew(failure);

            // The following task gets scheduled only if tran2 completes successfully
            var commitTran2 = tran2.ContinueWith(commit, TaskContinuationOptions.OnlyOnRanToCompletion);

            // The following task gets scheduled only if tran2 DOES NOT complete successfully
            var rollbackTran2 = tran2.ContinueWith(rollback, TaskContinuationOptions.NotOnRanToCompletion);

            // For demo purposes, wait for the sample to complete
            rollbackTran2.Wait();
        }

        ///<summary>
        ///
        /// </summary>
        void Test15()
        {
            Action<string> action =
            (str) =>
                richTextBox1.WriteLine("Task={0}, str={1}, Thread={2}", Task.CurrentId, str, Thread.CurrentThread.ManagedThreadId);

            // Creating a sequence of action tasks (that return no result).
            richTextBox1.WriteLine("Creating a sequence of action tasks (that return no result)");
            Task.Factory.StartNew(() => action("alpha"))
                .ContinueWith(antecendent => action("beta"))        // Antecedent data is ignored
                .ContinueWith(antecendent => action("gamma"))
                .Wait();

            Func<int, int> negate =
                (n) =>
                {
                    richTextBox1.WriteLine("Task={0}, n={1}, -n={2}, Thread={3}", Task.CurrentId, n, -n, Thread.CurrentThread.ManagedThreadId);
                    return -n;
                };

            // Creating a sequence of function tasks where each continuation uses the result from its antecendent
            richTextBox1.WriteLine("\nCreating a sequence of function tasks where each continuation uses the result from its antecendent");
            Task<int>.Factory.StartNew(() => negate(5))
                .ContinueWith(antecendent => negate(antecendent.Result))        // Antecedent result feeds into continuation
                .ContinueWith(antecendent => negate(antecendent.Result))
                .Wait();

            // Creating a sequence of tasks where you can mix and match the types
            richTextBox1.WriteLine("\nCreating a sequence of tasks where you can mix and match the types");
            Task<int>.Factory.StartNew(() => negate(6))
                .ContinueWith(antecendent => action("x"))
                .ContinueWith(antecendent => negate(7))
                .Wait();
        }

        ///<summary>
        ///The following example launches a task that includes a call to the Delay(TimeSpan, CancellationToken) method with a 1.5 second delay. Before the delay interval elapses, the token is cancelled. The output from the example shows that, as a result, a TaskCanceledException is thrown, and the tasks' Status property is set to Canceled.
        /// </summary>
        void Test16()
        {
            CancellationTokenSource source = new CancellationTokenSource();

            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1.5), source.Token);
                return 42;
            });
            source.Cancel();
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    richTextBox1.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
            richTextBox1.Write("Task t Status: {0}", t.Status);
            if (t.Status == TaskStatus.RanToCompletion)
                richTextBox1.Write(", Result: {0}", t.Result);
            source.Dispose();
        }

        ///<summary>
        ///The following example shows a simple use of the Delay method.
        /// </summary>
        void Test17()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(TimeSpan.FromSeconds(1.5));
                return 42;
            });
            t.Wait();
            richTextBox1.WriteLine("Task t Status: {0}, Result: {1}",
                              t.Status, t.Result);
        }

        ///<summary>
        ///The following example shows a simple use of the Delay method.
        /// </summary>
        void Test18()
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(1000);
                return 42;
            });
            t.Wait();
            richTextBox1.WriteLine("Task t Status: {0}, Result: {1}",
                              t.Status, t.Result);
        }

        ///<summary>
        ///The following example launches a task that includes a call to the Delay(Int32, CancellationToken) method with a one second delay. Before the delay interval elapses, the token is cancelled. The output from the example shows that, as a result, a TaskCanceledException is thrown, and the tasks' Status property is set to Canceled.
        /// </summary>
        void Test19()
        {
            CancellationTokenSource source = new CancellationTokenSource();

            var t = Task.Run(async delegate
            {
                await Task.Delay(1000, source.Token);
                return 42;
            });
            source.Cancel();
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    richTextBox1.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
            richTextBox1.Write("Task t Status: {0}", t.Status);
            if (t.Status == TaskStatus.RanToCompletion)
                richTextBox1.Write(", Result: {0}", t.Result);
            source.Dispose();
        }

        ///<summary>
        ///The following example is a command-line utility that calculates the number of bytes in the files in each directory whose name is passed as a command-line argument. Rather than executing a longer code path that instantiates a FileInfo object and retrieves the value of its FileInfo.Length property for each file in the directory, the example simply calls the FromException<TResult>(Exception) method to create a faulted task if a particular subdirectory does not exist.
        /// </summary>
        void Test20()
        {
            Func<string, Task<long>> GetFileLengthsAsync = (filePath) => {
                if (!Directory.Exists(filePath))
                {
                    return Task.FromException<long>(
                                new DirectoryNotFoundException("Invalid directory name."));
                }
                else
                {
                    string[] files = Directory.GetFiles(filePath);
                    if (files.Length == 0)
                        return Task.FromResult(0L);
                    else
                        return Task.Run(() => {
                            long total = 0;
                            Parallel.ForEach(files, (fileName) => {
                                var fs = new FileStream(fileName, FileMode.Open,
                                                        FileAccess.Read, FileShare.ReadWrite,
                                                        256, true);
                                long length = fs.Length;
                                Interlocked.Add(ref total, length);
                                fs.Close();
                            });
                            return total;
                        });
                }
            };
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                List<Task<long>> tasks = new List<Task<long>>();
                for (int ctr = 1; ctr < args.Length; ctr++)
                    tasks.Add(GetFileLengthsAsync(args[ctr]));

                try
                {
                    Task.WaitAll(tasks.ToArray());
                }
                // Ignore exceptions here.
                catch (AggregateException) { }

                for (int ctr = 0; ctr < tasks.Count; ctr++)
                {
                    if (tasks[ctr].Status == TaskStatus.Faulted)
                        richTextBox1.WriteLine("{0} does not exist", args[ctr + 1]);
                    else
                        richTextBox1.WriteLine("{0:N0} bytes in files in '{1}'",
                                          tasks[ctr].Result, args[ctr + 1]);
                }
            }
            else
            {
                richTextBox1.WriteLine("Syntax error: Include one or more file paths.");
            }
        }

        ///<summary>
        ///The following example is a command-line utility that calculates the number of bytes in the files in each directory whose name is passed as a command-line argument. Rather than executing a longer code path that instantiates a FileStream object and retrieves the value of its FileStream.Length property for each file in the directory, the example simply calls the FromResult method to create a task whose Task<TResult>.Result property is zero (0) if a directory has no files.
        /// </summary>
        void Test21()
        {
            Func<string, Task<long>> GetFileLengthsAsync = (filePath) => {

                if (!Directory.Exists(filePath))
                {
                    return Task.FromException<long>(
                                new DirectoryNotFoundException("Invalid directory name."));
                }
                else
                {
                    string[] files = Directory.GetFiles(filePath);
                    if (files.Length == 0)
                        return Task.FromResult(0L);
                    else
                        return Task.Run(() => {
                            long total = 0;
                            Parallel.ForEach(files, (fileName) => {
                                var fs = new FileStream(fileName, FileMode.Open,
                                                        FileAccess.Read, FileShare.ReadWrite,
                                                        256, true);
                                long length = fs.Length;
                                Interlocked.Add(ref total, length);
                                fs.Close();
                            });
                            return total;
                        });
                }
            };

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                List<Task<long>> tasks = new List<Task<long>>();
                for (int ctr = 1; ctr < args.Length; ctr++)
                    tasks.Add(GetFileLengthsAsync(args[ctr]));

                try
                {
                    Task.WaitAll(tasks.ToArray());
                }
                // Ignore exceptions here.
                catch (AggregateException) { }

                for (int ctr = 0; ctr < tasks.Count; ctr++)
                {
                    if (tasks[ctr].Status == TaskStatus.Faulted)
                        richTextBox1.WriteLine("{0} does not exist", args[ctr + 1]);
                    else
                        richTextBox1.WriteLine("{0:N0} bytes in files in '{1}'",
                                          tasks[ctr].Result, args[ctr + 1]);
                }
            }
            else
            {
                richTextBox1.WriteLine("Syntax error: Include one or more file paths.");
            }
        }

        ///<summary>
        ///The following example defines a ShowThreadInfo method that displays the Thread.ManagedThreadId of the current thread. It is called directly from the application thread, and is called from the Action delegate passed to the Run(Action) method.
        /// </summary>
        void Test22()
        {
            Action<string> ShowThreadInfo=(s)=> richTextBox1.WriteLine("{0} thread ID: {1}",
                        s, Thread.CurrentThread.ManagedThreadId);

            ShowThreadInfo("Application");

            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();
        }

        ///<summary>
        ///The following example is similar to the previous one, except that it uses a lambda expression to define the code that the task is to execute.
        /// </summary>
        void Test23()
        {
            richTextBox1.WriteLine("Application thread ID: {0}",
                        Thread.CurrentThread.ManagedThreadId);
            var t = Task.Run(() => {
                richTextBox1.WriteLine("Task thread ID: {0}",
                                         Thread.CurrentThread.ManagedThreadId);
            });
            t.Wait();
        }

        ///<summary>
        ///The following example illustrates the Run(Action) method. It defines an array of directory names and starts a separate task to retrieve the file names in each directory. All tasks write the file names to a single ConcurrentBag<T> object. The example then calls the WaitAll(Task[]) method to ensure that all tasks have completed, and then displays a count of the total number of file names written to the ConcurrentBag<T> object.
        /// </summary>
        void Test24()
        {
            var list = new ConcurrentBag<string>();
            string[] dirNames = { ".", ".." };
            List<Task> tasks = new List<Task>();
            foreach (var dirName in dirNames)
            {
                Task t = Task.Run(() => {
                    foreach (var path in Directory.GetFiles(dirName))
                        list.Add(path);
                });
                tasks.Add(t);
            }
            Task.WaitAll(tasks.ToArray());
            foreach (Task t in tasks)
                richTextBox1.WriteLine("Task {0} Status: {1}", t.Id, t.Status);

            richTextBox1.WriteLine("Number of files read: {0}", list.Count);
        }

        ///<summary>
        ///The following example calls the Run(Action, CancellationToken) method to create a task that iterates the files in the C:\Windows\System32 directory. The lambda expression calls the Parallel.ForEach method to add information about each file to a List<T> object. Each detached nested task invoked by the Parallel.ForEach loop checks the state of the cancellation token and, if cancellation is requested, calls the CancellationToken.ThrowIfCancellationRequested method. The CancellationToken.ThrowIfCancellationRequested method throws an OperationCanceledException exception that is handled in a catch block when the calling thread calls the Task.Wait method.
        /// </summary>
      async  void Test25()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var files = new List<Tuple<string, string, long, DateTime>>();

            var t = Task.Run(() => {
                string dir = "C:\\Windows\\System32\\";
                object obj = new Object();
                if (Directory.Exists(dir))
                {
                    Parallel.ForEach(Directory.GetFiles(dir),
                    f => {
                        if (token.IsCancellationRequested)
                            token.ThrowIfCancellationRequested();
                        var fi = new FileInfo(f);
                        lock (obj)
                        {
                            files.Add(Tuple.Create(fi.Name, fi.DirectoryName, fi.Length, fi.LastWriteTimeUtc));
                        }
                    });
                }
            }
                              , token);
            await Task.Yield();
            tokenSource.Cancel();
            try
            {
                await t;
                richTextBox1.WriteLine("Retrieved information for {0} files.", files.Count);
            }
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("Exception messages:");
                foreach (var ie in e.InnerExceptions)
                    richTextBox1.WriteLine("   {0}: {1}", ie.GetType().Name, ie.Message);

                richTextBox1.WriteLine("\nTask status: {0}", t.Status);
            }
            finally
            {
                tokenSource.Dispose();
            }
        }

        ///<summary>
        ///The following example counts the approximate number of words in text files that represent published books. Each task is responsible for opening a file, reading its entire contents asynchronously, and calculating the word count by using a regular expression. The WaitAll(Task[]) method is called to ensure that all tasks have completed before displaying the word count of each book to the richTextBox1.
        /// </summary>
        void Test26()
        {
            string pattern = @"\p{P}*\s+";
            string[] titles = { "Sister Carrie", "The Financier" };
            Task<int>[] tasks = new Task<int>[titles.Length];

            for (int ctr = 0; ctr < titles.Length; ctr++)
            {
                string s = titles[ctr];
                tasks[ctr] = Task.Run(() => {
                    // Number of words.
                    int nWords = 0;
                    // Create filename from title.
                    string fn = s + ".txt";
                    if (File.Exists(fn))
                    {
                        StreamReader sr = new StreamReader(fn);
                        string input = sr.ReadToEndAsync().Result;
                        nWords = Regex.Matches(input, pattern).Count;
                    }
                    return nWords;
                });
            }
            Task.WaitAll(tasks);

            richTextBox1.WriteLine("Word Counts:\n");
            for (int ctr = 0; ctr < titles.Length; ctr++)
                richTextBox1.WriteLine("{0}: {1,10:N0} words", titles[ctr], tasks[ctr].Result);
        }

        ///<summary>
        ///The following example creates 20 tasks that will loop until a counter is incremented to a value of 2 million. When the first 10 tasks reach 2 million, the cancellation token is cancelled, and any tasks whose counters have not reached 2 million are cancelled. The example shows possible output.
        /// </summary>
        void Test27()
        {
            var tasks = new List<Task<int>>();
            var source = new CancellationTokenSource();
            var token = source.Token;
            int completedIterations = 0;

            for (int n = 0; n <= 19; n++)
                tasks.Add(Task.Run(() => {
                    int iterations = 0;
                    for (int ctr = 1; ctr <= 2000000; ctr++)
                    {
                        token.ThrowIfCancellationRequested();
                        iterations++;
                    }
                    Interlocked.Increment(ref completedIterations);
                    if (completedIterations >= 10)
                        source.Cancel();
                    return iterations;
                }, token));

            richTextBox1.WriteLine("Waiting for the first 10 tasks to complete...\n");
            try
            {
                Task.WaitAll(tasks.ToArray());
            }
            catch (AggregateException)
            {
                richTextBox1.WriteLine("Status of tasks:\n");
                richTextBox1.WriteLine("{0,10} {1,20} {2,14:N0}", "Task Id",
                                  "Status", "Iterations");
                foreach (var t in tasks)
                    richTextBox1.WriteLine("{0,10} {1,20} {2,14}",
                                      t.Id, t.Status,
                                      t.Status != TaskStatus.Canceled ? t.Result.ToString("N0") : "n/a");
            }
        }

        ///<summary>
        ///Instead of using the InnerExceptions property to examine exceptions, the example iterates all tasks to determine which have completed successfully and which have been cancelled. For those that have completed, it displays the value returned by the task.
        ///Because cancellation is cooperative, each task can decide how to respond to cancellation.The following example is like the first, except that, once the token is cancelled, tasks return the number of iterations they've completed rather than throw an exception.
        /// </summary>
        void Test28()
        {
            var tasks = new List<Task<int>>();
            var source = new CancellationTokenSource();
            var token = source.Token;
            int completedIterations = 0;

            for (int n = 0; n <= 19; n++)
                tasks.Add(Task.Run(() => {
                    int iterations = 0;
                    for (int ctr = 1; ctr <= 2000000; ctr++)
                    {
                        if (token.IsCancellationRequested)
                            return iterations;
                        iterations++;
                    }
                    Interlocked.Increment(ref completedIterations);
                    if (completedIterations >= 10)
                        source.Cancel();
                    return iterations;
                }, token));

            richTextBox1.WriteLine("Waiting for the first 10 tasks to complete...\n");
            try
            {
                Task.WaitAll(tasks.ToArray());
            }
            catch (AggregateException)
            {
                richTextBox1.WriteLine("Status of tasks:\n");
                richTextBox1.WriteLine("{0,10} {1,20} {2,14:N0}", "Task Id",
                                  "Status", "Iterations");
                foreach (var t in tasks)
                    richTextBox1.WriteLine("{0,10} {1,20} {2,14}",
                                      t.Id, t.Status,
                                      t.Status != TaskStatus.Canceled ? t.Result.ToString("N0") : "n/a");
            }
        }

        ///<summary>
        ///The following example compares a task executed by calling the RunSynchronously method with one executed asynchronously. In both cases, the tasks execute identical lambda expressions that display the task ID and the ID of the thread on which the task is running. The task calculates the sum of the integers between 1 and 1,000,000. As the output from the example shows, the task executed by calling the RunSynchronously method runs on the application thread, while the asynchronous task does not.
        /// </summary>
        void Test29()
        {
            richTextBox1.WriteLine("Application executing on thread {0}",
                        Thread.CurrentThread.ManagedThreadId);
            var asyncTask = Task.Run(() => {
                richTextBox1.WriteLine("Task {0} (asyncTask) executing on Thread {1}",
                                                                 Task.CurrentId,
                                                                 Thread.CurrentThread.ManagedThreadId);
                long sum = 0;
                for (int ctr = 1; ctr <= 1000000; ctr++)
                    sum += ctr;
                return sum;
            });
            var syncTask = new Task<long>(() => {
                richTextBox1.WriteLine("Task {0} (syncTask) executing on Thread {1}",
                                                                       Task.CurrentId,
                                                                       Thread.CurrentThread.ManagedThreadId);
                long sum = 0;
                for (int ctr = 1; ctr <= 1000000; ctr++)
                    sum += ctr;
                return sum;
            });
            syncTask.RunSynchronously();
            richTextBox1.WriteLine();
            richTextBox1.WriteLine("Task {0} returned {1:N0}", syncTask.Id, syncTask.Result);
            richTextBox1.WriteLine("Task {0} returned {1:N0}", asyncTask.Id, asyncTask.Result);
        }

        ///<summary>
        ///The following example calls the Task(Action) constructor to instantiate a new Task object that displays its task ID and managed thread ID and then executes a loop. It then calls the Start method to execute the task. Since this is a richTextBox1 app, the call to the Wait method is necessary to prevent the app from terminating before the task finishes execution.
        /// </summary>
        void Test30()
        {
            var t = new Task(() => {
                richTextBox1.WriteLine("Task {0} running on thread {1}",
                                                  Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                for (int ctr = 1; ctr <= 10; ctr++)
                    richTextBox1.WriteLine("   Iteration {0}", ctr);
            }
                        );
            t.Start();
            t.Wait();
        }

        ///<summary>
        ///The following example starts a task that generates one million random integers between 0 and 100 and computes their mean. The example uses the Wait method to ensure that the task completes before the application terminates. Otherwise, because this is a richTextBox1 application, the example would terminate before the task can compute and display the mean.
        /// </summary>
        void Test31()
        {
            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                int n = 1000000;
                for (int ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                richTextBox1.WriteLine("Total:   {0:N0}", sum);
                richTextBox1.WriteLine("Mean:    {0:N2}", sum / n);
                richTextBox1.WriteLine("N:       {0:N0}", n);
            });
            t.Wait();
        }

        ///<summary>
        ///The following example starts a task that generates five million random integers between 0 and 100 and computes their mean. The example uses the Wait(Int32) method to wait for the application to complete within 150 milliseconds. If the application completes normally, the task displays the sum and mean of the random numbers that it has generated. If the timeout interval has elapsed, the example displays a message before it terminates.
        /// </summary>
        void Test32()
        {
            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                int n = 5000000;
                for (int ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                richTextBox1.WriteLine("Total:   {0:N0}", sum);
                richTextBox1.WriteLine("Mean:    {0:N2}", sum / n);
                richTextBox1.WriteLine("N:       {0:N0}", n);
            });
            if (!t.Wait(150))
                richTextBox1.WriteLine("The timeout interval elapsed.");
        }

        ///<summary>
        ///The following example illustrates the simple use of a cancellation token to cancel waiting for a task's completion. A task is launched, calls the CancellationTokenSource.Cancel method to cancel any of the token source's cancellation tokens, and then delays for five seconds. Note that the task itself has not been passed the cancellation token and is not cancelable. The application thread calls the task's Task.Wait method to wait for the task to complete, but the wait is canceled once the cancellation token is cancelled and an OperationCanceledException is thrown. The exception handler reports the exception and then sleeps for six seconds. As the output from the example shows, that delay allows the task to complete in the RanToCompletion state.
        /// </summary>
        void Test33()
        {
            CancellationTokenSource ts = new CancellationTokenSource();

            Task t = Task.Run(() => {
                richTextBox1.WriteLine("Calling Cancel...");
                ts.Cancel();
                Task.Delay(5000).Wait();
                richTextBox1.WriteLine("Task ended delay...");
            });
            try
            {
                richTextBox1.WriteLine("About to wait for the task to complete...");
                t.Wait(ts.Token);
            }
            catch (OperationCanceledException e)
            {
                richTextBox1.WriteLine("{0}: The wait has been canceled. Task status: {1:G}",
                                  e.GetType().Name, t.Status);
                Thread.Sleep(6000);
                richTextBox1.WriteLine("After sleeping, the task status:  {0:G}", t.Status);
            }
            ts.Dispose();
        }

        ///<summary>
        ///The following example starts a task that generates five million random integers between 0 and 100 and computes their mean. The example uses the Wait(TimeSpan) method to wait for the application to complete within 150 milliseconds. If the application completes normally, the task displays the sum and mean of the random numbers that it has generated. If the timeout interval has elapsed, the example displays a message before it terminates.
        /// </summary>
        void Test34()
        {
            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                int n = 5000000;
                for (int ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                richTextBox1.WriteLine("Total:   {0:N0}", sum);
                richTextBox1.WriteLine("Mean:    {0:N2}", sum / n);
                richTextBox1.WriteLine("N:       {0:N0}", n);
            });
            TimeSpan ts = TimeSpan.FromMilliseconds(150);
            if (!t.Wait(ts))
                richTextBox1.WriteLine("The timeout interval elapsed.");
        }

        ///<summary>
        ///The following example calls the Wait(Int32, CancellationToken) method to provide both a timeout value and a cancellation token that can end the wait for a task's completion. A new thread is started and executes the CancelToken method, which pauses and then calls the CancellationTokenSource.Cancel method to cancel the cancellation tokens. A task is then launched and delays for 5 seconds. The Wait method is then called to wait for the task's completion and is provided both a brief timeout value and a cancellation token.
        /// </summary>
         void CancelToken(Object obj)
           {
              Thread.Sleep(1500);
              richTextBox1.WriteLine("Canceling the cancellation token from thread {0}...",
                                Thread.CurrentThread.ManagedThreadId);
              CancellationTokenSource source = obj as CancellationTokenSource;
              if (source != null) source.Cancel();
           }
    void Test35()
        {
            /*Action<object> CancelToken = (obj) => {
                Thread.Sleep(1500);
                richTextBox1.WriteLine("Canceling the cancellation token from thread {0}...",
                                  Thread.CurrentThread.ManagedThreadId);
                CancellationTokenSource source = obj as CancellationTokenSource;
                if (source != null) source.Cancel();
            };*/
            CancellationTokenSource ts = new CancellationTokenSource();
            Thread thread = new Thread(CancelToken);
            thread.Start(ts);

            Task t = Task.Run(() => {
                Task.Delay(5000).Wait();
                richTextBox1.WriteLine("Task ended delay...");
            });
            try
            {
                richTextBox1.WriteLine("About to wait completion of task {0}", t.Id);
                bool result = t.Wait(1510, ts.Token);
                richTextBox1.WriteLine("Wait completed normally: {0}", result);
                richTextBox1.WriteLine("The task status:  {0:G}", t.Status);
            }
            catch (OperationCanceledException e)
            {
                richTextBox1.WriteLine("{0}: The wait has been canceled. Task status: {1:G}",
                                  e.GetType().Name, t.Status);
                Thread.Sleep(4000);
                richTextBox1.WriteLine("After sleeping, the task status:  {0:G}", t.Status);
                ts.Dispose();
            }
        }

        ///<summary>
        ///The following example starts 10 tasks, each of which is passed an index as a state object. Tasks with an index from two to five throw exceptions. The call to the WaitAll method wraps all exceptions in an AggregateException object and propagates it to the calling thread.
        /// </summary>
        void Test36()
        {
            var tasks = new List<Task<int>>();

            // Define a delegate that prints and returns the system tick count
            Func<object, int> action = (object obj) =>
            {
                int i = (int)obj;

                // Make each thread sleep a different time in order to return a different tick count
                Thread.Sleep(i * 100);

                // The tasks that receive an argument between 2 and 5 throw exceptions
                if (2 <= i && i <= 5)
                {
                    throw new InvalidOperationException("SIMULATED EXCEPTION");
                }

                int tickCount = Environment.TickCount;
                richTextBox1.WriteLine("Task={0}, i={1}, TickCount={2}, Thread={3}", Task.CurrentId, i, tickCount, Thread.CurrentThread.ManagedThreadId);

                return tickCount;
            };

            // Construct started tasks
            for (int i = 0; i < 10; i++)
            {
                int index = i;
                tasks.Add(Task<int>.Factory.StartNew(action, index));
            }

            try
            {
                // Wait for all the tasks to finish.
                Task.WaitAll(tasks.ToArray());

                // We should never get to this point
                richTextBox1.WriteLine("WaitAll() has not thrown exceptions. THIS WAS NOT EXPECTED.");
            }
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("\nThe following exceptions have been thrown by WaitAll(): (THIS WAS EXPECTED)");
                for (int j = 0; j < e.InnerExceptions.Count; j++)
                {
                    richTextBox1.WriteLine("\n-------------------------------------------------\n{0}", e.InnerExceptions[j].ToString());
                }
            }
        }

        ///<summary>
        ///The following example launches five tasks, each of which sleeps for a minimum of 50 milliseconds or a maximum of 1,050 milliseconds. The WaitAny method then waits for any of the tasks to complete. The example displays the task ID of the task that ended the wait, as well as the current status of all the tasks.
        /// </summary>
        void Test37()
        {
            Task[] tasks = new Task[5];
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                int factor = ctr;
                tasks[ctr] = Task.Run(() => Thread.Sleep(factor * 250 + 50));
            }
            int index = Task.WaitAny(tasks);
            richTextBox1.WriteLine("Wait ended because task #{0} completed.",
                              tasks[index].Id);
            richTextBox1.WriteLine("\nCurrent Status of Tasks:");
            foreach (var t in tasks)
                richTextBox1.WriteLine("   Task {0}: {1}", t.Id, t.Status);
        }

        ///<summary>
        ///The following example creates a set of tasks that ping the URLs in an array. The tasks are stored in a List<Task> collection that is passed to the WhenAll(IEnumerable<Task>) method. After the call to the Wait method ensures that all threads have completed, the example examines the Task.Status property to determine whether any tasks have faulted.
        /// </summary>
        void Test38()
        {
            int failed = 0;
            var tasks = new List<Task>();
            String[] urls = { "www.adatum.com", "www.cohovineyard.com",
                        "www.cohowinery.com", "www.northwindtraders.com",
                        "www.contoso.com" };

            foreach (var value in urls)
            {
                var url = value;
                tasks.Add(Task.Run(() => {
                    var png = new Ping();
                    try
                    {
                        var reply = png.Send(url);
                        if (!(reply.Status == IPStatus.Success))
                        {
                            Interlocked.Increment(ref failed);
                            throw new TimeoutException("Unable to reach " + url + ".");
                        }
                    }
                    catch (PingException)
                    {
                        Interlocked.Increment(ref failed);
                        throw;
                    }
                }));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
                richTextBox1.WriteLine("All ping attempts succeeded.");
            else if (t.Status == TaskStatus.Faulted)
                richTextBox1.WriteLine("{0} ping attempts failed", failed);
        }

        ///<summary>
        ///The following example creates a set of tasks that ping the URLs in an array. The tasks are stored in a List<Task> collection that is converted to an array and passed to the WhenAll(IEnumerable<Task>) method. After the call to the Wait method ensures that all threads have completed, the example examines the Task.Status property to determine whether any tasks have faulted.
        /// </summary>
       async void Test39()
        {
            int failed = 0;
            var tasks = new List<Task>();
            String[] urls = { "www.adatum.com", "www.cohovineyard.com",
                        "www.cohowinery.com", "www.northwindtraders.com",
                        "www.contoso.com" };

            foreach (var value in urls)
            {
                var url = value;
                tasks.Add(Task.Run(() => {
                    var png = new Ping();
                    try
                    {
                        var reply = png.Send(url);
                        if (!(reply.Status == IPStatus.Success))
                        {
                            Interlocked.Increment(ref failed);
                            throw new TimeoutException("Unable to reach " + url + ".");
                        }
                    }
                    catch (PingException)
                    {
                        Interlocked.Increment(ref failed);
                        throw;
                    }
                }));
            }
            Task t = Task.WhenAll(tasks.ToArray());
            try
            {
                await t;
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
                richTextBox1.WriteLine("All ping attempts succeeded.");
            else if (t.Status == TaskStatus.Faulted)
                richTextBox1.WriteLine("{0} ping attempts failed", failed);
        }

        ///<summary>
        ///The following example creates ten tasks, each of which instantiates a random number generator that creates 1,000 random numbers between 1 and 1,000 and computes their mean. The Delay(Int32) method is used to delay instantiation of the random number generators so that they are not created with identical seed values. The call to the WhenAll method then returns an Int64 array that contains the mean computed by each task. These are then used to calculate the overall mean.
        /// </summary>
        void Test40()
        {
            var tasks = new List<Task<long>>();
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int delayInterval = 18 * ctr;
                tasks.Add(Task.Run(async () => {
                    long total = 0;
                    await Task.Delay(delayInterval);
                    var rnd = new Random();
                    // Generate 1,000 random numbers.
                    for (int n = 1; n <= 1000; n++)
                        total += rnd.Next(0, 1000);
                    return total;
                }));
            }
            var continuation = Task.WhenAll(tasks);
            try
            {
                continuation.Wait();
            }
            catch (AggregateException)
            { }

            if (continuation.Status == TaskStatus.RanToCompletion)
            {
                long grandTotal = 0;
                foreach (var result in continuation.Result)
                {
                    grandTotal += result;
                    richTextBox1.WriteLine("Mean: {0:N2}, n = 1,000", result / 1000.0);
                }

                richTextBox1.WriteLine("\nMean of Means: {0:N2}, n = 10,000",
                                  grandTotal / 10000);
            }
            // Display information on faulted tasks.
            else
            {
                foreach (var t in tasks)
                {
                    richTextBox1.WriteLine("Task {0}: {1}", t.Id, t.Status);
                }
            }
        }

        ///<summary>
        ///The following example creates ten tasks, each of which instantiates a random number generator that creates 1,000 random numbers between 1 and 1,000 and computes their mean. In this case, the ten individual tasks are stored in a Task<Int64> array. The Delay(Int32) method is used to delay instantiation of the random number generators so that they are not created with identical seed values. The call to the WhenAll method then returns an Int64 array that contains the mean computed by each task. These are then used to calculate the overall mean.
        /// </summary>
        void Test41()
        {
            var tasks = new Task<long>[10];
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int delayInterval = 18 * ctr;
                tasks[ctr - 1] = Task.Run(async () => {
                    long total = 0;
                    await Task.Delay(delayInterval);
                    var rnd = new Random();
                    // Generate 1,000 random numbers.
                    for (int n = 1; n <= 1000; n++)
                        total += rnd.Next(0, 1000);

                    return total;
                });
            }
            var continuation = Task.WhenAll(tasks);
            try
            {
                continuation.Wait();
            }
            catch (AggregateException)
            { }

            if (continuation.Status == TaskStatus.RanToCompletion)
            {
                long grandTotal = 0;
                foreach (var result in continuation.Result)
                {
                    grandTotal += result;
                    richTextBox1.WriteLine("Mean: {0:N2}, n = 1,000", result / 1000.0);
                }

                richTextBox1.WriteLine("\nMean of Means: {0:N2}, n = 10,000",
                                  grandTotal / 10000);
            }
            // Display information on faulted tasks.
            else
            {
                foreach (var t in tasks)
                    richTextBox1.WriteLine("Task {0}: {1}", t.Id, t.Status);
            }
        }

       
    }


}
