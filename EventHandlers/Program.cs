using System;
using System.Threading;

// Sample has static event that notifies subscribers about some stuff.
// This collection of event handlers is a GC “root” because it 
// is static class field. So the all objects that are referenced 
// from this field will be not collected until program termination.
public class Sample
{
    public static event EventHandler SampleEvent;

    public static void Main()
    {
        var wr = CreateAndSubscribe();
        GC.Collect(2);
        Console.WriteLine("Object: " + (wr.IsAlive ? "Alive" : "Collected"));
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public static WeakReference CreateAndSubscribe()
    {
        return new WeakReference(new Sample());
    }

    public Sample()
    {
        SampleEvent += SampleEventHandler;
    }

    private void SampleEventHandler(object sender, EventArgs e)
    {
        // do nothing
    }
}