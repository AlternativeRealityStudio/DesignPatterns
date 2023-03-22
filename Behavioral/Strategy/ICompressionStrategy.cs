using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICompressionStrategy
{
    byte[] Compress(byte[] data);
}