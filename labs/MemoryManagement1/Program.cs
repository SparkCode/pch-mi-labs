using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement1
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            using (timer.Start())
            {
                // do things
                var array = new int[10000].Select(x => Guid.NewGuid()).ToList();
            }
            Console.WriteLine(timer.ElapsedMilliseconds);

            using (timer.Continue())
            {
                // do things
                var array = new int[10000].Select(x => new Timer().Start()).ToList();
            }
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}
