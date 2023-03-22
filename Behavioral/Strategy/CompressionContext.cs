using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompressionContext
{
    private ICompressionStrategy _compressionStrategy;

    public CompressionContext(ICompressionStrategy compressionStrategy)
    {
        _compressionStrategy = compressionStrategy;
    }

    public void SetCompressionStrategy(ICompressionStrategy compressionStrategy)
    {
        _compressionStrategy = compressionStrategy;
    }

    public byte[] CompressData(byte[] data)
    {
        return _compressionStrategy.Compress(data);
    }
}