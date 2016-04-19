using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace MemoryManagement1
{
    [TestFixture]
    public class TimerTest
    {
        [Test]
        public void FirstMeasuredTimeMoreThanSecondFirstMeasuredTime()
        {
            var timer = new Timer();

            using (timer.Start())
            {
                var array = new int[10000].Select(x => Guid.NewGuid()).ToList();
            }
            var t1 = timer.ElapsedMilliseconds;

            using (timer.Continue())
            {
                var array = new int[10000].Select(x => new Timer().Start()).ToList();
            }

            var t2 = timer.ElapsedMilliseconds;

            Assert.That(t1 > 0 && t2 > t1);
        }

        [Test]
        public void StopwatchAndTimerWorkEqually()
        {
            var timer = new Timer();
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            using (timer.Start())
            {
                var array = new int[10000].Select(x => Guid.NewGuid()).ToList();
            }
            stopWatch.Stop();

            stopWatch.Start();
            using (timer.Continue())
            {
                var array = new int[10000].Select(x => new Timer().Start()).ToList();
            }
            stopWatch.Stop();

            Assert.That(Math.Abs(timer.ElapsedMilliseconds - stopWatch.ElapsedMilliseconds) < 1 );
        }
    }
}