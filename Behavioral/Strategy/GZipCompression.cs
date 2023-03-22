using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Compression;

public class GZipCompression : ICompressionStrategy
{
    //Lempel-Ziv algorithm 
    public byte[] Compress(byte[] data)
    {
        Debug.Log("Compressing with GZip");
        using (MemoryStream output = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(output, CompressionMode.Compress))
            {
                gzip.Write(data, 0, data.Length);
            }
            return output.ToArray();
        }
    }
}