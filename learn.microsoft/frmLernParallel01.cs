
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;

namespace learn.microsoft.frm
{
    //https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.parallel.for?view=net-7.0

    public partial class frmLernParallel01 : frmBase
    {
        public frmLernParallel01()
        {
            Load +=(o,e)=> { Task.Factory.StartNew(Test06); };


        }

        private void frmLoad(object sender, EventArgs e)
        {
             Task.Factory.StartNew(Test06);
          
       }


        ///<summary>
        ///The following example executes up to 100 iterations of a loop in parallel. Each iteration pauses for a random interval from 1 to 1,000 milliseconds. A randomly generated value determines on which iteration of the loop the ParallelLoopState.Break method is called. As the output from the example shows, no iterations whose index is greater than the ParallelLoopState.LowestBreakIteration property value start after the call to the ParallelLoopState.Break method.
        ///</summary>
        void Test01()
        {
            var rnd = new Random();
            int breakIndex = rnd.Next(1, 11);

            richTextBox1.WriteLine($"Will call Break at iteration {breakIndex}\n");

            var result = Parallel.For(1, 101, (i, state) =>
            {
                richTextBox1.WriteLine($"Beginning iteration {i}");
                int delay;
                lock (rnd)
                    delay = rnd.Next(1, 1001);
                Thread.Sleep(delay);

                if (state.ShouldExitCurrentIteration)
                {
                    if (state.LowestBreakIteration < i)
                        return;
                }

                if (i == breakIndex)
                {
                    richTextBox1.WriteLine($"Break in iteration {i}");
                    state.Break();
                }

                richTextBox1.WriteLine($"Completed iteration {i}");
            });

            if (result.LowestBreakIteration.HasValue)
                richTextBox1.WriteLine($"\nLowest Break Iteration: {result.LowestBreakIteration}");
            else
                richTextBox1.WriteLine($"\nNo lowest break iteration.");
        }

        ///<summary>
        ///The following example uses the For method for 100 invocations of a delegate that generates random byte values and computes their sum.
        ///</summary>
        void Test02()
        {
            ParallelLoopResult result = Parallel.For(0, 100, ctr => {
                Random rnd = new Random(ctr * 100000);
                Byte[] bytes = new Byte[100];
                rnd.NextBytes(bytes);
                int sum = 0;
                foreach (var byt in bytes)
                    sum += byt;
                richTextBox1.WriteLine("Iteration {0,2}: {1:N0}", ctr, sum);
            });
            richTextBox1.WriteLine("Result: {0}", result.IsCompleted ? "Completed Normally" :
                                                                   String.Format("Completed to {0}", result.LowestBreakIteration));
        }

        ///<summary>
        ///Executes a for loop in which iterations may run in parallel and loop options can be configured.
        /// </summary>
        void Test03()
        {
            CancellationTokenSource cancellationSource = new CancellationTokenSource();
            ParallelOptions options = new ParallelOptions();
            options.CancellationToken = cancellationSource.Token;

            try
            {
                ParallelLoopResult loopResult = Parallel.For(
                        0,
                        10,
                        options,
                        (i, loopState) =>
                        {
                            richTextBox1.WriteLine("Start Thread={0}, i={1}", Thread.CurrentThread.ManagedThreadId, i);

                            // Simulate a cancellation of the loop when i=2
                            if (i == 2)
                            {
                                cancellationSource.Cancel();
                            }

                            // Simulates a long execution
                            for (int j = 0; j < 10; j++)
                            {
                                Thread.Sleep(1 * 200);

                                // check to see whether or not to continue
                                if (loopState.ShouldExitCurrentIteration) return;
                            }

                            richTextBox1.WriteLine("Finish Thread={0}, i={1}", Thread.CurrentThread.ManagedThreadId, i);
                        }
                    );

                if (loopResult.IsCompleted)
                {
                    richTextBox1.WriteLine("All iterations completed successfully. THIS WAS NOT EXPECTED.");
                }
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("Parallel.For has thrown an AggregateException. THIS WAS NOT EXPECTED.\n{0}", e);
            }
            // Catching the cancellation exception
            catch (OperationCanceledException e)
            {
                richTextBox1.WriteLine("An iteration has triggered a cancellation. THIS WAS EXPECTED.\n{0}", e.ToString());
            }
            finally
            {
                cancellationSource.Dispose();
            }
        }

        ///<summary>
        ///Executes a for loop with 64-bit indexes in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated.
        ///The following example shows how to use the Parallel.For method with a ParallelOptions object:
        /// </summary>
        void Test04()
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 2; // -1 is for unlimited. 1 is for sequential.

            try
            {
                Parallel.For(
                        0,
                        9,
                        options,
                        (i) =>
                        {
                            richTextBox1.WriteLine("Thread={0}, i={1}", Thread.CurrentThread.ManagedThreadId, i);
                        }
                    );
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("Parallel.For has thrown the following (unexpected) exception:\n{0}", e);
            }
        }

        ///<summary>
        ///Executes a for loop with 64-bit indexes in which iterations may run in parallel and loop options can be configured.
        ///The following example shows how to use ParallelOptions to specify a custom task scheduler:
        /// </summary>
        void Test05()
        {
            ParallelOptions options = new ParallelOptions();

            // Construct and associate a custom task scheduler
            options.TaskScheduler = new TwoThreadTaskScheduler();

            try
            {
                Parallel.For(
                        0,
                        10,
                        options,
                        (i, localState) =>
                        {
                            richTextBox1.WriteLine("i={0}, Task={1}, Thread={2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
                        }
                    );
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("An iteration has thrown an exception. THIS WAS NOT EXPECTED.\n{0}", e);
            }
        }

        ///<summary>
        ///Executes a for loop with thread-local data in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated.
        ///The following example uses thread-local variables to compute the sum of the results of many lengthy operations. This example limits the degree of parallelism to four.
        /// </summary>
        void Test06()
        {
            // The result of all thread-local computations.
            int result = 0;
            Func<int, int> Compute = (n) =>
            {
                for (int i = 0; i < 10000; i++) ;
                return 1;
            };
            int N = 1000000;
            Parallel.For(0, N, new ParallelOptions { MaxDegreeOfParallelism = 4 },
               // Initialize the local states
               () => 0,
               // Accumulate the thread-local computations in the loop body
               (i, loop, localState) =>
               {
                   return localState + Compute(i);
               },
               // Combine all local states
               localState => Interlocked.Add(ref result, localState)
            );

            // Print the actual and expected results.
            richTextBox1.WriteLine("Actual result: {0}. Expected 1000000.", result);
        }

        ///<summary>
        ///Executes a foreach (For Each in Visual Basic) operation with thread-local data on an IEnumerable in which iterations may run in parallel, and the state of the loop can be monitored and manipulated.
        ///The following example shows how to use a ForEach method with local state:
        /// </summary>
        void Test07()
        {
            // The sum of these elements is 40.
            int[] input = { 4, 1, 6, 2, 9, 5, 10, 3 };
            int sum = 0;

            try
            {
                Parallel.ForEach(
                        input,                          // source collection
                        () => 0,                            // thread local initializer
                        (n, loopState, localSum) =>     // body
                        {
                            localSum += n;
                            richTextBox1.WriteLine("Thread={0}, n={1}, localSum={2}", Thread.CurrentThread.ManagedThreadId, n, localSum);
                            return localSum;
                        },
                        (localSum) => Interlocked.Add(ref sum, localSum)                    // thread local aggregator
                    );

                richTextBox1.WriteLine("\nSum={0}", sum);
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("Parallel.ForEach has thrown an exception. THIS WAS NOT EXPECTED.\n{0}", e);
            }
        }

        ///<summary>
        ///Executes a foreach (For Each in Visual Basic) operation on a Partitioner in which iterations may run in parallel.
        ///The following example shows how to implement a range partitioner for use with Parallel.ForEach:
        /// </summary>
        void Test08()
        {
            Stopwatch sw = null;

            long sum = 0;
            long SUMTOP = 10000000;

            // Try sequential for
            sw = Stopwatch.StartNew();
            for (long i = 0; i < SUMTOP; i++) sum += i;
            sw.Stop();
            richTextBox1.WriteLine("sequential for result = {0}, time = {1} ms", sum, sw.ElapsedMilliseconds);

            // Try parallel for -- this is slow!
            //sum = 0;
            //sw = Stopwatch.StartNew();
            //Parallel.For(0L, SUMTOP, (item) => Interlocked.Add(ref sum, item));
            //sw.Stop();
            //richTextBox1.WriteLine("parallel for  result = {0}, time = {1} ms", sum, sw.ElapsedMilliseconds);

            // Try parallel for with locals
            sum = 0;
            sw = Stopwatch.StartNew();
            Parallel.For(0L, SUMTOP, () => 0L, (item, state, prevLocal) => prevLocal + item, local => Interlocked.Add(ref sum, local));
            sw.Stop();
            richTextBox1.WriteLine("parallel for w/locals result = {0}, time = {1} ms", sum, sw.ElapsedMilliseconds);

            // Try range partitioner
            sum = 0;
            sw = Stopwatch.StartNew();
            Parallel.ForEach(Partitioner.Create(0L, SUMTOP), (range) =>
            {
                long local = 0;
                for (long i = range.Item1; i < range.Item2; i++) local += i;
                Interlocked.Add(ref sum, local);
            });
            sw.Stop();
            richTextBox1.WriteLine("range partitioner result = {0}, time = {1} ms", sum, sw.ElapsedMilliseconds);
        }

        ///<summary>
        ///Executes a foreach (For Each in Visual Basic) operation on an IEnumerable in which iterations may run in parallel.
        ///The following example uses the ForEach<TSource>(IEnumerable<TSource>, Action<TSource>) method to count the number of vowels and non-white-space characters in a text file. In this case, the ParallelLoopResult value returned by the method is ignored. Note that, because operations can run in parallel, you must ensure that incrementing the counter variables is an atomic operation, and that multiple threads do not attempt to access the counter variables simultaneously. For this purpose, the example uses the lock statement (in C#) and the SyncLock statement (in Visual Basic).
        /// </summary>
        void Test09()
        {
            Func<string, Task<String>> ReadCharacters =async (fn) =>{
                String _text;
                using (StreamReader sr = new StreamReader(fn))
                {
                    _text = await sr.ReadToEndAsync();
                }
                return _text;
            };
            Task<String> task = ReadCharacters(@".\CallOfTheWild.txt");
            String text = task.Result;

            int nVowels = 0;
            int nNonWhiteSpace = 0;
            Object obj = new Object();

            ParallelLoopResult result = Parallel.ForEach(text,
                                                         (ch) => {
                                                             Char uCh = Char.ToUpper(ch);
                                                             if ("AEIOUY".IndexOf(uCh) >= 0)
                                                             {
                                                                 lock (obj)
                                                                 {
                                                                     nVowels++;
                                                                 }
                                                             }
                                                             if (!Char.IsWhiteSpace(uCh))
                                                             {
                                                                 lock (obj)
                                                                 {
                                                                     nNonWhiteSpace++;
                                                                 }
                                                             }
                                                         });
            richTextBox1.WriteLine("Total characters:      {0,10:N0}", text.Length);
            richTextBox1.WriteLine("Total vowels:          {0,10:N0}", nVowels);
            richTextBox1.WriteLine("Total non-white-space:  {0,10:N0}", nNonWhiteSpace);
        }

        ///<summary>
        ///Parallel.Invoke Method
        ///This example demonstrates how to use the Invoke method with other methods, anonymous delegates, and lambda expressions.
        /// </summary>
        void Test10()
        {
            Action BasicAction=()=> richTextBox1.WriteLine("Method=alpha, Thread={0}", Thread.CurrentThread.ManagedThreadId);
            try
            {
                Parallel.Invoke(
                    BasicAction,	// Param #0 - static method
                    () =>			// Param #1 - lambda expression
                    {
                        richTextBox1.WriteLine("Method=beta, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                    },
                    delegate ()		// Param #2 - in-line delegate
                    {
                        richTextBox1.WriteLine("Method=gamma, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                    }
                );
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                richTextBox1.WriteLine("An action has thrown an exception. THIS WAS UNEXPECTED.\n{0}", e.InnerException.ToString());
            }
        }

        ///<summary>
        ///Enables iterations of parallel loops to interact with other iterations. An instance of this class is provided by the Parallel class to each loop; you can not create instances in your code.
        ///The following example executes up to 100 iterations of a loop in parallel. Each iteration pauses for a random interval from 1 to 1,000 milliseconds. A randomly generated value determines on which iteration of the loop the Break method is called. As the output from the example shows, no iterations whose index is greater than the LowestBreakIteration property value start after the call to the Break method.
        /// </summary>
        void Test11()
        {
            var rnd = new Random();
            int breakIndex = rnd.Next(1, 11);

            richTextBox1.WriteLine($"Will call Break at iteration {breakIndex}\n");

            var result = Parallel.For(1, 101, (i, state) =>
            {
                richTextBox1.WriteLine($"Beginning iteration {i}");
                int delay;
                lock (rnd)
                    delay = rnd.Next(1, 1001);
                Thread.Sleep(delay);

                if (state.ShouldExitCurrentIteration)
                {
                    if (state.LowestBreakIteration < i)
                        return;
                }

                if (i == breakIndex)
                {
                    richTextBox1.WriteLine($"Break in iteration {i}");
                    state.Break();
                }

                richTextBox1.WriteLine($"Completed iteration {i}");
            });

            if (result.LowestBreakIteration.HasValue)
                richTextBox1.WriteLine($"\nLowest Break Iteration: {result.LowestBreakIteration}");
            else
                richTextBox1.WriteLine($"\nNo lowest break iteration.");
        }

        ///<summary>
        ///
        /// </summary>
        void Test12()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test13()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test14()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test15()
        {

        }

        ///<summary>
        ///
        /// </summary>
        void Test16()
        {

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
