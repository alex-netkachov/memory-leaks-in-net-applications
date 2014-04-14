using System;
using System.Runtime.InteropServices;

class BigTable : IDisposable
{
    private static long inc;

    private byte[] _table;

    public BigTable()
    {
        // Allocate 1Mb
        _table = new byte[1024*1024];
        inc++;
    }

    ~BigTable()
    {
    }

    public void Dispose()
    {
    }
}

