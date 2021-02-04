using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadQueueAndLock
{
    class ThreadExecutor
    {
        Queue<Thread> threadsQueue = new Queue<Thread>();

        public void Add(Thread t) {
            lock (this)
            {
                    threadsQueue.Enqueue(t);
            }
        }

        public void Execute() {
            lock (this) {

                if (threadsQueue.Count != 0) {
                        Thread t = threadsQueue.Dequeue();
                        t.Start();
                }
            
            }
        }
    }
}
