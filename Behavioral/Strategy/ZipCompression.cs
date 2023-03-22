using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Compression;

public class ZipCompression : ICompressionStrategy
{
    //Deflate algorithm
    public byte[] Compress(byte[] data)
    {
        Debug.Log("Compressing with Zip");
        using (MemoryStream output = new MemoryStream())
        {
            using (ZipArchive archive = new ZipArchive(output, ZipArchiveMode.Create))
            {
                ZipArchiveEntry entry = archive.CreateEntry("data.bin");
                using (Stream entryStream = entry.Open())
                {
                    entryStream.Write(data, 0, data.Length);
                }
            }
            return output.ToArray();
        }
    }
}