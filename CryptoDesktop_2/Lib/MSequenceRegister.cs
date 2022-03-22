using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_2.Lib
{
    public class MSequenceRegister
    {
        private const string KeyFilePath = "key.txt";

        private const int Coefficient1 = 93;
        private const int Coefficient2 = 102;

        private BitArray state;

        // регистр со случайно начальной последовательностью
        public MSequenceRegister(int length)
        {
            state = new BitArray(length);

            Random random = new Random();
            for (int i = 0; i < length - 1; i++)
                state[i] = random.Next(2) == 1;

            File.WriteAllText(KeyFilePath, Converter.ToString(state));
        }

        // регистр с заданной начальной последовательностью
        public MSequenceRegister(int length, string startState)
        {
            state = Converter.ToBitArray(startState);
        }

        // со всеми 1/0
        public MSequenceRegister(int lenght, bool startValue)
        {
            state = new BitArray(lenght, startValue);
        }

        // получение последовательности нужной длины
        public string GetMSequence(int length)
        {
            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += state[state.Length - 1] ? 1 : 0;
                SetNextState();
            }

            return result;
        }

        // итерация
        private void SetNextState()
        {
            bool newOne = state[Coefficient1] ^ state[Coefficient2];

            state.LeftShift(1);
            state.Set(0, newOne);
        }
    }
}
