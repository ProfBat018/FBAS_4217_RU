using System.Runtime.InteropServices;
using System;
using System.IO;

namespace Archiver;


class Compressor
{
    private readonly int alg = 2; // MsZip algorithm

    public void ComressFile(string inputFile, string outputFile)
    {
        byte[] payload = File.ReadAllBytes(inputFile);

        IntPtr hCompressor = IntPtr.Zero;
        CreateCompressor((uint)alg, IntPtr.Zero, out hCompressor);


        byte[] Trash = new byte[] { }; 
        uint CompressedDataSize = 0;

        if (!Compress(hCompressor, payload, (uint)payload.Length, Trash, 0, out CompressedDataSize))
        {
            if (CompressedDataSize > 0)
            {
                uint CompressedDataSize2 = 0; 

                byte[] CompressedBuffer = new byte[CompressedDataSize];

                if (!Compress(hCompressor, payload, (uint)payload.Length, CompressedBuffer, CompressedDataSize, out CompressedDataSize2)) 
                {
                    Console.WriteLine("[!] Compress error: {0}", Marshal.GetLastWin32Error().ToString());
                }
                else
                {
                    Console.WriteLine("\n[+] Success! Writing {0} bytes to {1}", CompressedDataSize, outputFile);
                    File.WriteAllBytes(outputFile, CompressedBuffer);
                }
            }
        }

        CloseCompressor(hCompressor);
    }


    [DllImport("Cabinet.dll")]
    static extern bool CreateCompressor(uint Algorithm, IntPtr AllocationRoutines, out IntPtr CompressorHandle);
    [DllImport("Cabinet.dll")]
    static extern bool CloseCompressor(IntPtr CompressHandle);

    [DllImport("Cabinet.dll")]
    static extern bool Compress(IntPtr CompressorHandle, byte[] UncompressedData, uint UncompressedDataSize, byte[] CompressedBuffer, uint CompressedBufferSize, out uint CompressedDataSize);

}