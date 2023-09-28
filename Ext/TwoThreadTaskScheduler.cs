using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testCodeInWebbyToR.Ext
{
    // This scheduler schedules all tasks on (at most) two threads
    sealed class TwoThreadTaskScheduler : TaskScheduler, IDisposable
    {
        // The runtime decides how many tasks to create for the given set of iterations, loop options, and scheduler's max concurrency level.
        // Tasks will be queued in this collection
        private BlockingCollection<Task> _tasks = new BlockingCollection<Task>();

        // Maintain an array of threads. (Feel free to bump up _n.)
        private readonly int _n = 2;
        private Thread[] _threads;

        public TwoThreadTaskScheduler()
        {
            _threads = new Thread[_n];

            // Create unstarted threads based on the same inline delegate
            for (int i = 0; i < _n; i++)
            {
                _threads[i] = new Thread(() =>
                {
                    // The following loop blocks until items become available in the blocking collection.
                    // Then one thread is unblocked to consume that item.
                    foreach (var task in _tasks.GetConsumingEnumerable())
                    {
                        TryExecuteTask(task);
                    }
                });

                // Start each thread
                _threads[i].IsBackground = true;
                _threads[i].Start();
            }
        }

        // This method is invoked by the runtime to schedule a task
        protected override void QueueTask(Task task)
        {
            _tasks.Add(task);
        }

        // The runtime will probe if a task can be executed in the current thread.
        // By returning false, we direct all tasks to be queued up.
        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }

        public override int MaximumConcurrencyLevel { get { return _n; } }

        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return _tasks.ToArray();
        }

        // Dispose is not thread-safe with other members.
        // It may only be used when no more tasks will be queued
        // to the scheduler.  This implementation will block
        // until all previously queued tasks have completed.
        public void Dispose()
        {
            if (_threads != null)
            {
                _tasks.CompleteAdding();

                for (int i = 0; i < _n; i++)
                {
                    _threads[i].Join();
                    _threads[i] = null;
                }
                _threads = null;
                _tasks.Dispose();
                _tasks = null;
            }
        }
    }
}
