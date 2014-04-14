using System;

class Manager : IDisposable
{
    // Constructor gets the resources on class instantiation.
    public Manager()
    {
        // 1. Allocate managed resources: create objects, arrays, etc.
        // 2. Allocate unmanaged resources: create file, open socket,
        // consume memory, etc.
    }

    // Finalizer releases unmanaged resources - all the unnecessary
    // managed resources should be already collected at this point.
    // Can be called only by the GC finalization thread.
    ~Manager()
    {
        Dispose(false);
    }

    // Dispose frees both managed and unmanaged resources - it is 
    // called from the user’s code and both managed and unmanaged resources
    // are not released yet.
    public void Dispose()
    {
        Dispose(true);
    }

    // Actual disposing method - disposes only unmanaged resources
    // or both managed and unmanaged. This method should not be called from
    // other code.
    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            // dispose managed resources
        }
        // dispose unmanaged resources
    }
}

