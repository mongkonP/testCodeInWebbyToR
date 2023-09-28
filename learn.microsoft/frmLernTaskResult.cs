
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace learn.microsoft.frm
{
    internal class frmLernTaskResult:frmBase
    {

        public frmLernTaskResult() { Load += (o, e) => { Task.Factory.StartNew(Test01); }; }


        ///<summary>
        ///
        /// </summary>
        void Test01()
        {
            var t = Task<int>.Run(() => {
                // Just loop.
                int max = 1000000;
                int ctr = 0;
                for (ctr = 0; ctr <= max; ctr++)
                {
                    if (ctr == max / 2 && DateTime.Now.Hour <= 12)
                    {
                        ctr++;
                        break;
                    }
                }
                return ctr;
            });
            richTextBox1.WriteLine("Finished {0:N0} iterations.", t.Result);
        }

        ///<summary>
        ///
        /// </summary>
        void Test02()
        {
            var t = Task<int>.Factory.StartNew(() => {
                // Just loop.
                int max = 1000000;
                int ctr = 0;
                for (ctr = 0; ctr <= max; ctr++)
                {
                    if (ctr == max / 2 && DateTime.Now.Hour <= 12)
                    {
                        ctr++;
                        break;
                    }
                }
                return ctr;
            });
            richTextBox1.WriteLine("Finished {0:N0} iterations.", t.Result);
        }

        ///<summary>
        ///
        /// </summary>
      async  void Test03()
        {
            string pattern = @"\p{P}*\s+";
            string[] titles = { "Sister Carrie", "The Financier" };
            Task<int>[] tasks = new Task<int>[titles.Length];

            for (int ctr = 0; ctr < titles.Length; ctr++)
            {
                string s = titles[ctr];
                tasks[ctr] = new Task<int>(() => {
                    // Number of words.
                    int nWords = 0;
                    // Create filename from title.
                    string fn = s + ".txt";

                    StreamReader sr = new StreamReader(fn);
                    string input = sr.ReadToEndAsync().Result;
                    sr.Close();
                    nWords = Regex.Matches(input, pattern).Count;
                    return nWords;
                });
            }
            // Ensure files exist before launching tasks.
            bool allExist = true;
            foreach (var title in titles)
            {
                string fn = title + ".txt";
                if (!File.Exists(fn))
                {
                    allExist = false;
                    richTextBox1.WriteLine("Cannot find '{0}'", fn);
                    break;
                }
            }
            // Launch tasks 
            if (allExist)
            {
                foreach (var t in tasks)
                    t.Start();

                await Task.WhenAll(tasks);

                richTextBox1.WriteLine("Word Counts:\n");
                for (int ctr = 0; ctr < titles.Length; ctr++)
                    richTextBox1.WriteLine("{0}: {1,10:N0} words", titles[ctr], tasks[ctr].Result);
            }
        }

        ///<summary>
        ///
        /// </summary>
         class Test
        {
        public string Name { get; set; }
        public double Number { get; set; }
        }
    void Test04()
        {
            // Return a value type with a lambda expression
            Task<int> task1 = Task<int>.Factory.StartNew(() => 1);
            int i = task1.Result;

            // Return a named reference type with a multi-line statement lambda.
            Task<Test> task2 = Task<Test>.Factory.StartNew(() =>
            {
                string s = ".NET";
                double d = 4.0;
                return new Test { Name = s, Number = d };
            });
            Test test = task2.Result;

            // Return an array produced by a PLINQ query
            Task<string[]> task3 = Task<string[]>.Factory.StartNew(() =>
            {
                string path = @"C:\Users\Public\Pictures\Sample Pictures\";
                string[] files = System.IO.Directory.GetFiles(path);

                var result = (from file in files.AsParallel()
                              let info = new System.IO.FileInfo(file)
                              where info.Extension == ".jpg"
                              select file).ToArray();

                return result;
            });

            foreach (var name in task3.Result)
                richTextBox1.WriteLine(name);
        }

        ///<summary>
        ///
        /// </summary>
        void Test05()
        {

            Func<string, Task<long>> GetFileLengthsAsync = (filePath) =>
            {
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
        ///
        /// </summary>

        CancellationTokenSource ts;
        void TimedOutEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            ts.Cancel();
        }
        void Test06(string[] args)
        {
            int upperBound = args.Length >= 1 ? Int32.Parse(args[0]) : 200;
            ts = new CancellationTokenSource();
            CancellationToken token = ts.Token;
            System.Timers.Timer timer = new System.Timers.Timer(3000);
            timer.Elapsed += TimedOutEvent;
            timer.AutoReset = false;
            timer.Enabled = true;

            var t1 = Task.Run(() => { // True = composite.
                                      // False = prime.
                bool[] values = new bool[upperBound + 1];
                for (int ctr = 2; ctr <= (int)Math.Sqrt(upperBound); ctr++)
                {
                    if (values[ctr] == false)
                    {
                        for (int product = ctr * ctr; product <= upperBound;
                                                      product = product + ctr)
                            values[product] = true;
                    }
                    token.ThrowIfCancellationRequested();
                }
                return values;
            }, token);

            var t2 = t1.ContinueWith((antecedent) => { // Create a list of prime numbers.
                var primes = new List<int>();
                token.ThrowIfCancellationRequested();
                bool[] numbers = antecedent.Result;
                string output = String.Empty;

                for (int ctr = 1; ctr <= numbers.GetUpperBound(0); ctr++)
                    if (numbers[ctr] == false)
                        primes.Add(ctr);

                // Create the output string.
                for (int ctr = 0; ctr < primes.Count; ctr++)
                {
                    token.ThrowIfCancellationRequested();
                    output += primes[ctr].ToString("N0");
                    if (ctr < primes.Count - 1)
                        output += ",  ";
                    if ((ctr + 1) % 8 == 0)
                        output += Environment.NewLine;
                }
                //Display the result.
                richTextBox1.WriteLine("Prime numbers from 1 to {0}:\n",
                                  upperBound);
                richTextBox1.WriteLine(output);
            }, token);
            try
            {
                t2.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                {
                    if (e.GetType() == typeof(TaskCanceledException))
                        richTextBox1.WriteLine("The operation was cancelled.");
                    else
                        richTextBox1.WriteLine("ELSE: {0}: {1}", e.GetType().Name, e.Message);
                }
            }
            finally
            {
                ts.Dispose();
            }
        }

        ///<summary>
        ///The following example creates a task that is passed an integer between 2 and 20 and returns an array that contains the first ten exponents (from n1 to n10) of that number. A continuation task is then responsible for displaying the exponents. It is passed both the antecedent and the original number whose exponents the antecedent generates.
        /// </summary>
        void Test07()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            // Get an integer to generate a list of its exponents.
            var rnd = new Random();
            var number = rnd.Next(2, 21);

            var t = Task.Factory.StartNew((value) => {
                int n = (int)value;
                long[] values = new long[10];
                for (int ctr = 1; ctr <= 10; ctr++)
                    values[ctr - 1] = (long)Math.Pow(n, ctr);

                return values;
            }, number);
            var continuation = t.ContinueWith((antecedent, value) => {
                richTextBox1.WriteLine("Exponents of {0}:", value);
                for (int ctr = 0; ctr <= 9; ctr++)
                    richTextBox1.WriteLine("   {0} {1} {2} = {3:N0}",
                                      value, "\u02C6", ctr + 1,
                                      antecedent.Result[ctr]);
                richTextBox1.WriteLine();
            }, number);
            continuation.Wait();
            cts.Dispose();
        }

        ///<summary>
        ///The following example creates an antecedent task that uses the Sieve of Eratosthenes to calculate the prime numbers between 1 and a value entered by the user. An array is used to hold information about the prime numbers. The array index represents the number, and the element's value indicates whether that number is composite (its value is true) or prime (its value is false). This task is then passed to a continuation task, which is responsible for extracting the prime numbers from the integer array and displaying them.
        /// </summary>
        void Test08(string[] args)
        {
            int upperBound = args.Length >= 1 ? Int32.Parse(args[0]) : 200;

            var t1 = Task.Run(() => { // True = composite.
                                      // False = prime.
                bool[] values = new bool[upperBound + 1];
                for (int ctr = 2; ctr <= (int)Math.Sqrt(upperBound); ctr++)
                {
                    if (values[ctr] == false)
                    {
                        for (int product = ctr * ctr; product <= upperBound;
                                                      product = product + ctr)
                            values[product] = true;
                    }
                }
                return values;
            });
            var t2 = t1.ContinueWith((antecedent) => { // Create a list of prime numbers.
                var primes = new List<int>();
                bool[] numbers = antecedent.Result;
                string output = String.Empty;

                for (int ctr = 1; ctr <= numbers.GetUpperBound(0); ctr++)
                    if (numbers[ctr] == false)
                        primes.Add(ctr);

                // Create the output string.
                for (int ctr = 0; ctr < primes.Count; ctr++)
                {
                    output += primes[ctr].ToString("N0");
                    if (ctr < primes.Count - 1)
                        output += ",  ";
                    if ((ctr + 1) % 8 == 0)
                        output += Environment.NewLine;
                }
                //Display the result.
                richTextBox1.WriteLine("Prime numbers from 1 to {0}:\n",
                                  upperBound);
                richTextBox1.WriteLine(output);
            });
            try
            {
                t2.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    richTextBox1.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
        }

        ///<summary>
        ///The following example creates a chain of continuation tasks. Each task provides the current time, a DateTime object, for the state argument of the ContinueWith(Action<Task,Object>, Object) method. Each DateTime value represents the time at which the continue task is created. Each task produces as its result a second DateTime value that represents the time at which the task finishes. After all tasks finish, the example displays the date and times at which each continuation task starts and finishes.
        /// </summary>
        void Test09()
        {
            Func<DateTime> DoWork = () => {

                // Simulate work by suspending the current thread
                // for two seconds.
                Thread.Sleep(2000);

                // Return the current time.
                return DateTime.Now;
            };

            // Start a root task that performs work.
            Task<DateTime> t = Task<DateTime>.Run(delegate { return DoWork(); });

            // Create a chain of continuation tasks, where each task is
            // followed by another task that performs work.
            List<Task<DateTime>> continuations = new List<Task<DateTime>>();
            for (int i = 0; i < 5; i++)
            {
                // Provide the current time as the state of the continuation.
                t = t.ContinueWith(delegate { return DoWork(); }, DateTime.Now);
                continuations.Add(t);
            }

            // Wait for the last task in the chain to complete.
            t.Wait();

            // Print the creation time of each continuation (the state object)
            // and the completion time (the result of that task) to the richTextBox1.
            foreach (var continuation in continuations)
            {
                DateTime start = (DateTime)continuation.AsyncState;
                DateTime end = continuation.Result;

                richTextBox1.WriteLine("Task was created at {0} and finished at {1}.",
                   start.TimeOfDay, end.TimeOfDay);
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test10()
        {
            TaskCompletionSource<int> tcs1 = new TaskCompletionSource<int>();
            Task<int> t1 = tcs1.Task;

            // Start a background task that will complete tcs1.Task
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                tcs1.SetResult(15);
            });

            // The attempt to get the result of t1 blocks the current thread until the completion source gets signaled.
            // It should be a wait of ~1000 ms.
            Stopwatch sw = Stopwatch.StartNew();
            int result = t1.Result;
            sw.Stop();

            richTextBox1.WriteLine("(ElapsedTime={0}): t1.Result={1} (expected 15) ", sw.ElapsedMilliseconds, result);

            // ------------------------------------------------------------------

            // Alternatively, an exception can be manually set on a TaskCompletionSource.Task
            TaskCompletionSource<int> tcs2 = new TaskCompletionSource<int>();
            Task<int> t2 = tcs2.Task;

            // Start a background Task that will complete tcs2.Task with an exception
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                tcs2.SetException(new InvalidOperationException("SIMULATED EXCEPTION"));
            });

            // The attempt to get the result of t2 blocks the current thread until the completion source gets signaled with either a result or an exception.
            // In either case it should be a wait of ~1000 ms.
            sw = Stopwatch.StartNew();
            try
            {
                result = t2.Result;

                richTextBox1.WriteLine("t2.Result succeeded. THIS WAS NOT EXPECTED.");
            }
            catch (AggregateException e)
            {
                richTextBox1.Write("(ElapsedTime={0}): ", sw.ElapsedMilliseconds);
                richTextBox1.WriteLine("The following exceptions have been thrown by t2.Result: (THIS WAS EXPECTED)");
                for (int j = 0; j < e.InnerExceptions.Count; j++)
                {
                    richTextBox1.WriteLine("\n-------------------------------------------------\n{0}", e.InnerExceptions[j].ToString());
                }
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test11()
        {
            Func<int, Task<int>> RemoteIncrement = (n) =>
            {
                return Task<int>.Factory.StartNew(
                (obj) =>
                {
                    // Simulate a slow operation
                    Thread.Sleep(1 * 1000);

                    int x = (int)obj;
                    richTextBox1.WriteLine("Thread={0}, Next={1}", Thread.CurrentThread.ManagedThreadId, ++x);
                    return x;
                },
                n);
            };

            // Invoking individual tasks is straightforward
            Task<int> t1 = RemoteIncrement(0);
            richTextBox1.WriteLine("Started RemoteIncrement(0)");

            // Chain together the results of (simulated) remote operations.
            // The use of Unwrap() instead of .Result below prevents this thread from blocking while setting up this continuation chain.
            Task<int> t2 = RemoteIncrement(4)
                .ContinueWith(t => RemoteIncrement(t.Result))			// RemoteIncrement() returns Task<int> so no unwrapping is needed for the first continuation.
                .Unwrap().ContinueWith(t => RemoteIncrement(t.Result))	// ContinueWith() returns Task<Task<int>>. Therefore unwrapping is needed.
                .Unwrap().ContinueWith(t => RemoteIncrement(t.Result))	// and on it goes...
                .Unwrap();
            richTextBox1.WriteLine("Started RemoteIncrement(...(RemoteIncrement(RemoteIncrement(4))...)");

            try
            {
                t1.Wait();
                richTextBox1.WriteLine("Finished RemoteIncrement(0)\n");

                t2.Wait();
                richTextBox1.WriteLine("Finished RemoteIncrement(...(RemoteIncrement(RemoteIncrement(4))...)");
            }
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("A task has thrown the following (unexpected) exception:\n{0}", e);
            }
        }

        ///<summary>
        ///The following example uses the static Factory property to make two calls to the TaskFactory.StartNew method. The first populates an array with the names of files in the user's MyDocuments directory, while the second populates an array with the names of subdirectories of the user's MyDocuments directory. It then calls the TaskFactory.ContinueWhenAll(Task[], Action<Task[]>) method, which displays information about the number of files and directories in the two arrays after the first two tasks have completed execution.
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
        ///
        /// </summary>
        void Test13()
        {
            string[] filenames = { "chapter1.txt", "chapter2.txt",
                             "chapter3.txt", "chapter4.txt",
                             "chapter5.txt" };
            string pattern = @"\b\w+\b";
            var tasks = new List<Task>();
            int totalWords = 0;

            // Determine the number of words in each file.
            foreach (var filename in filenames)
                tasks.Add(Task.Factory.StartNew(fn => {
                    if (!File.Exists(fn.ToString()))
                        throw new FileNotFoundException("{0} does not exist.", filename);

                    StreamReader sr = new StreamReader(fn.ToString());
                    String content = sr.ReadToEnd();
                    sr.Close();
                    int words = Regex.Matches(content, pattern).Count;
                    Interlocked.Add(ref totalWords, words);
                    richTextBox1.WriteLine("{0,-25} {1,6:N0} words", fn, words);
                },
                                                  filename));

            var finalTask = Task.Factory.ContinueWhenAll(tasks.ToArray(), wordCountTasks => {
                int nSuccessfulTasks = 0;
                int nFailed = 0;
                int nFileNotFound = 0;
                foreach (var t in wordCountTasks)
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                        nSuccessfulTasks++;

                    if (t.Status == TaskStatus.Faulted)
                    {
                        nFailed++;
                        t.Exception.Handle((e) => {
                            if (e is FileNotFoundException)
                                nFileNotFound++;
                            return true;
                        });
                    }
                }
                richTextBox1.WriteLine("\n{0,-25} {1,6} total words\n",
                                  String.Format("{0} files", nSuccessfulTasks),
                                  totalWords);
                if (nFailed > 0)
                {
                    richTextBox1.WriteLine("{0} tasks failed for the following reasons:", nFailed);
                    richTextBox1.WriteLine("   File not found:    {0}", nFileNotFound);
                    if (nFailed != nFileNotFound)
                        richTextBox1.WriteLine("   Other:          {0}", nFailed - nFileNotFound);
                }
            });
            finalTask.Wait();
        }

        ///<summary>
        ///
        /// </summary>
        void Test14()
        {
            string[] filenames = { "chapter1.txt", "chapter2.txt",
                             "chapter3.txt", "chapter4.txt",
                             "chapter5.txt" };
            string pattern = @"\b\w+\b";
            var tasks = new List<Task>();
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            int totalWords = 0;

            // Determine the number of words in each file.
            foreach (var filename in filenames)
                tasks.Add(Task.Factory.StartNew(fn => {
                    token.ThrowIfCancellationRequested();

                    if (!File.Exists(fn.ToString()))
                    {
                        source.Cancel();
                        token.ThrowIfCancellationRequested();
                    }

                    StreamReader sr = new StreamReader(fn.ToString());
                    String content = sr.ReadToEnd();
                    sr.Close();
                    int words = Regex.Matches(content, pattern).Count;
                    Interlocked.Add(ref totalWords, words);
                    richTextBox1.WriteLine("{0,-25} {1,6:N0} words", fn, words);
                },
                                                  filename, token));

            var finalTask = Task.Factory.ContinueWhenAll(tasks.ToArray(), wordCountTasks => {
                if (!token.IsCancellationRequested)
                    richTextBox1.WriteLine("\n{0,-25} {1,6} total words\n",
                                      String.Format("{0} files", wordCountTasks.Length),
                                      totalWords);
            }, token);
            try
            {
                finalTask.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (Exception inner in ae.InnerExceptions)
                    if (inner is TaskCanceledException)
                        richTextBox1.WriteLine("\nFailure to determine total word count: a task was cancelled.");
                    else
                        richTextBox1.WriteLine("\nFailure caused by {0}", inner.GetType().Name);
            }
            finally
            {
                source.Dispose();
            }
        }

        ///<summary>
        ///
        /// </summary>
        void Test15()
        {
            // Schedule a list of tasks that return integer
            Task<int>[] tasks = new Task<int>[]
                {
                Task<int>.Factory.StartNew(() =>
                    {
                        Thread.Sleep(500);
                        richTextBox1.WriteLine("Task={0}, Thread={1}, x=5", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                        return 5;
                    }),

                Task<int>.Factory.StartNew(() =>
                    {
                        Thread.Sleep(10);
                        richTextBox1.WriteLine("Task={0}, Thread={1}, x=3", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                        return 3;
                    }),

                Task<int>.Factory.StartNew(() =>
                    {
                        Thread.Sleep(200);
                        richTextBox1.WriteLine("Task={0}, Thread={1}, x=2", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                        return 2;
                    })
                };

            // Schedule a continuation to indicate the result of the first task to complete
            Task.Factory.ContinueWhenAny(tasks, winner =>
            {
                // You would expect winning result = 3 on multi-core systems, because you expect
                // tasks[1] to finish first.
                richTextBox1.WriteLine("Task={0}, Thread={1} (ContinueWhenAny): Winning result = {2}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, winner.Result);
            });

            // Schedule a continuation that sums up the results of all tasks, then wait on it.
            // The list of antecendent tasks is passed as an argument by the runtime.
            Task.Factory.ContinueWhenAll(tasks,
                (antecendents) =>
                {
                    int sum = 0;
                    foreach (Task<int> task in antecendents)
                    {
                        sum += task.Result;
                    }

                    richTextBox1.WriteLine("Task={0}, Thread={1}, (ContinueWhenAll): Total={2} (expected 10)", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, sum);
                })
                .Wait();
        }

        ///<summary>
        ///
        /// </summary>
        void Test16()
        {
            Task<string[]>[] tasks = new Task<string[]>[2];
            String docsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            tasks[0] = Task<string[]>.Factory.StartNew(() => Directory.GetFiles(docsDirectory));
            tasks[1] = Task<string[]>.Factory.StartNew(() => Directory.GetDirectories(docsDirectory));

            Task.Factory.ContinueWhenAll(tasks, completedTasks => {
                richTextBox1.WriteLine("{0} contains: ", docsDirectory);
                richTextBox1.WriteLine("   {0} subdirectories", tasks[1].Result.Length);
                richTextBox1.WriteLine("   {0} files", tasks[0].Result.Length);
            });
        }

        ///<summary>
        ///
        /// </summary>
        void Test17()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test18()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test19()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test20()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test21()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test22()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test23()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test24()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test25()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test26()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test27()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test28()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test29()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test30()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test31()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test32()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test33()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test34()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test35()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test36()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test37()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test38()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test39()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test40()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test41()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test42()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test43()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test44()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test45()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test46()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test47()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test48()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test49()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test50()
        {

        }
    }
}
