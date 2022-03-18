using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_2.Lib
{
    public static class Encrypter
    {
        public static void Encrypt(string filePath, string registerStartSequence)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Read the source file into a byte array.
                byte[] bytes = new byte[fileStream.Length];
                int numBytesToRead = (int)fileStream.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                MSequenceRegister register = new MSequenceRegister(103, registerStartSequence);
                BitArray fileBits = new BitArray(bytes);

                for (int i = 0; i < fileBits.Length; i += 8)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        (fileBits[i + j], fileBits[i + 7 - j]) = (fileBits[i + 7 - j], fileBits[i + j]);
                    }
                }

                BitArray MsequenceBits = Converter.ToBitArray(register.GetMSequence(numBytesToRead * 8));
                BitArray encodedBits = fileBits.Xor(MsequenceBits);
                byte[] encodedBytes = Converter.ToByteArray(encodedBits);

                using (FileStream fsNew = new FileStream("encrypted.txt", FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(encodedBytes, 0, numBytesToRead);
                }
            }
        }

        public static void Decrypt(string filePath, string registerStartSequence)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Read the source file into a byte array.
                byte[] bytes = new byte[fileStream.Length];
                int numBytesToRead = (int)fileStream.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                MSequenceRegister register = new MSequenceRegister(103, registerStartSequence);
                BitArray fileBits = new BitArray(bytes);

                for (int i = 0; i < fileBits.Length; i += 8)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        (fileBits[i + j], fileBits[i + 7 - j]) = (fileBits[i + 7 - j], fileBits[i + j]);
                    }
                }

                BitArray MsequenceBits = Converter.ToBitArray(register.GetMSequence(numBytesToRead * 8));
                BitArray encodedBits = fileBits.Xor(MsequenceBits);
                byte[] encodedBytes = Converter.ToByteArray(encodedBits);

                using (FileStream fsNew = new FileStream("decrypted.txt", FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(encodedBytes, 0, numBytesToRead);
                }
            }

        }
    }
}
