using System;
using System.Diagnostics;

namespace MemoryManagement1
{
    public class Timer: Stopwatch, IDisposable
    {
        public Timer Continue()
        {
            base.Start();
            return this;
        }

        public new Timer Start()
        {
            base.Start();
            return this;
        }

        public void Dispose()
        {
            this.Stop();
        }
    }
}