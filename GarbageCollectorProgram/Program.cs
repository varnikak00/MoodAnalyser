using System;

namespace GarbageCollectorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] value = new int[5000];
                value = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }

            long mem3 = GC.GetTotalMemory(false);

            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);

            }
        }
    }
}
      
    
