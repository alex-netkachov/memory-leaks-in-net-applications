using System;
using System.Collections.Generic;

class Program
{
    private static List<byte[]> _arrays = new List<byte[]>();

    static void Main(string[] args)
    {
        Console.WriteLine("Press any key to start allocations.");
        Console.ReadKey(true);
        var index = 0;
        var size = 8 * 1024 * 1024; // 8Mb
        var dsize = 7 * 1024 * 1024; // 7Mb
        while (true)
        {
            // Create object that allocated in the beginning of the heap segment:
            var local = new byte[dsize];
            // Next allocated object will be placed next to it:
            _arrays.Add(new byte[size]);
            // Destory first object:
            local = null;
            GC.Collect();
            // At this point heap segment has a free space of “dsize” bytes
            // at the beginning and object of “size” bytes after it:
            // [ ... free, ~7Mb ... ][ ....... 8Mb .......] - 16 Mb total

            // Increase the dynamic size so the next allocated object
            // does not fit in any free region:
            dsize += 100;

            index++;
            Console.WriteLine("Iteration {0}: press any key to continue.", index);
            Console.ReadKey(true);
        }
    }
}
