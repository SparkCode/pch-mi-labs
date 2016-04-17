using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = Processor.CreateEngine<MyEngine>().For<MyEntity>().With<MyLogger>();
            Console.WriteLine(processor.GetType());
        }

        public class MyLogger{}

        public class MyEntity{}

        public class MyEngine{}
    }
}
