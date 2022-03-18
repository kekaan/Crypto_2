using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Crypto_2.Lib
{
    public static class Converter
    {
        public static string ToString(BitArray sequence)
        {
            string result = "";
            for (int i = 0; i < sequence.Length; i++)
                result += sequence[i] ? "1" : "0";

            return result;
        }

        public static BitArray ToBitArray(string sequence)
        {
            BitArray result = new BitArray(sequence.Length);
            for (int i = 0; i < sequence.Length; i++)
                result[i] = sequence[i] == '1';
            return result;
        }

        public static byte[] ToByteArray(BitArray bits)
        {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) numBytes++;

            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i])
                    bytes[byteIndex] |= (byte)(1 << (7 - bitIndex));

                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
            return bytes;
        }
    }
}
