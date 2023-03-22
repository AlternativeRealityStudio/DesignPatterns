using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyPatternExample : MonoBehaviour
{
    private void Start()
    {
        // Create some test data to compress
        byte[] testData = new byte[1024];
        for (int i = 0; i < testData.Length; i++)
        {
            testData[i] = (byte)Random.Range(0, 256);
        }

        // Create a new compression context and set the compression strategy to GZip
        CompressionContext context = new CompressionContext(new GZipCompression());

        // Compress the test data using the current compression strategy
        byte[] compressedData = context.CompressData(testData);
        Debug.Log("Compressed data size: " + compressedData.Length);

        // Change the compression strategy to Zip and compress the test data again
        context.SetCompressionStrategy(new ZipCompression());
        compressedData = context.CompressData(testData);
        Debug.Log("Compressed data size: " + compressedData.Length);
         
    }
}