using Crypto_2.Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoDesktop_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            // создание объекта регистра
            sequenceRichTextBox.Clear();
            MSequenceRegister register;
            if (comboBox1.SelectedItem.ToString() != "Random")
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog())
                {
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string startState = File.ReadAllText(fileDialog.FileName);
                        register = new MSequenceRegister(103, startState);
                    }
                    else
                        return;
                }
            }
            else
                register = new MSequenceRegister(103);

            // формирование последовательности нужной длины
            decimal sequenceLength = sequenceLengthNumericUpDown.Value;
            if (sequenceLength == Math.Truncate(sequenceLength))
                sequenceRichTextBox.Text = register.GetMSequence((int)sequenceLength);
            else
                MessageBox.Show("Invalid sequence length");
        }

        private void testsButton_Click(object sender, EventArgs e)
        {
            testsOutputRichTextBox.Clear();

            string sequence = sequenceRichTextBox.Text;
            if (sequence.Length == 0)
            {
                testsOutputRichTextBox.Text += "Sequence is empty. Generated sequence for 1500 bits\n\n";
                MSequenceRegister register = new MSequenceRegister(103);
                sequence = register.GetMSequence(1500);
                sequenceRichTextBox.Text = sequence;
            }

            for (int i = 2; i < 5; i++)
            { 
                (double, double, double) serialTestResult = MSequenceTester.SerialTest(sequence, i);
                testsOutputRichTextBox.Text += $"Serial test, serial length = {i}\n{serialTestResult.Item3} - AlphaMax: {serialTestResult.Item1}, AlphaMin: {serialTestResult.Item2}\n";
            }
            testsOutputRichTextBox.Text += "\n";

            (double, double) correlationTestResult1 = MSequenceTester.CorrelationTest(sequence, 1);
            testsOutputRichTextBox.Text += $"Correlation Test, k = 1\nR = {correlationTestResult1.Item1}, Rref = {correlationTestResult1.Item2}\n";
            (double, double) correlationTestResult2 = MSequenceTester.CorrelationTest(sequence, 2);
            testsOutputRichTextBox.Text += $"Correlation Test, k = 2\nR = {correlationTestResult2.Item1}, Rref = {correlationTestResult2.Item2}\n";
            (double, double) correlationTestResult8 = MSequenceTester.CorrelationTest(sequence, 8);
            testsOutputRichTextBox.Text += $"Correlation Test, k = 8\nR = {correlationTestResult8.Item1}, Rref = {correlationTestResult8.Item2}\n";
            (double, double) correlationTestResult9 = MSequenceTester.CorrelationTest(sequence, 9);
            testsOutputRichTextBox.Text += $"Correlation Test, k = 9\nR = {correlationTestResult9.Item1}, Rref = {correlationTestResult9.Item2}\n";
        
            
        }

        private string FileInBinary(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
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

                BitArray fileBits = new BitArray(bytes);

                for (int i = 0; i < fileBits.Length; i += 8)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        (fileBits[i + j], fileBits[i + 7 - j]) = (fileBits[i + 7 - j], fileBits[i + j]);
                    }
                }

                return Converter.ToString(fileBits);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                    fileName = fileDialog.FileName;
                else
                    return;
            }

            string sequence = File.ReadAllText("key.txt");
            Encrypter.Encrypt(fileName, sequence);

            encryptionTestsRichTextBox.Clear();
            encryptionTestsRichTextBox.Text += "____________________________\n123.txt\n____________________________\n\n";
            string sourceFile = FileInBinary(fileName);

            for (int i = 2; i < 5; i++)
            {
                (double, double, double) serialTestResult = MSequenceTester.SerialTest(sourceFile, i);
                encryptionTestsRichTextBox.Text += $"Serial test, serial length = {i}\n{serialTestResult.Item3} - AlphaMax: {serialTestResult.Item1}, AlphaMin: {serialTestResult.Item2}\n";
            }
            encryptionTestsRichTextBox.Text += "\n";

            (double, double) correlationTestResult1 = MSequenceTester.CorrelationTest(sourceFile, 1);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 1\nR = {correlationTestResult1.Item1}, Rref = {correlationTestResult1.Item2}\n";
            (double, double) correlationTestResult2 = MSequenceTester.CorrelationTest(sourceFile, 2);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 2\nR = {correlationTestResult2.Item1}, Rref = {correlationTestResult2.Item2}\n";
            (double, double) correlationTestResult8 = MSequenceTester.CorrelationTest(sourceFile, 8);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 8\nR = {correlationTestResult8.Item1}, Rref = {correlationTestResult8.Item2}\n";
            (double, double) correlationTestResult9 = MSequenceTester.CorrelationTest(sourceFile, 9);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 9\nR = {correlationTestResult9.Item1}, Rref = {correlationTestResult9.Item2}\n";

            encryptionTestsRichTextBox.Text += "____________________________\nencrypted.txt\n____________________________\n\n";
            sourceFile = FileInBinary("encrypted.txt");

            for (int i = 2; i < 5; i++)
            {
                (double, double, double) serialTestResult = MSequenceTester.SerialTest(sourceFile, i);
                encryptionTestsRichTextBox.Text += $"Serial test, serial length = {i}\n{serialTestResult.Item2} - Test passed: {serialTestResult.Item1}\n";
            }
            encryptionTestsRichTextBox.Text += "\n";

            (double, double) correlationTestResult11 = MSequenceTester.CorrelationTest(sourceFile, 1);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 1\nR = {correlationTestResult11.Item1}, Rref = {correlationTestResult11.Item2}\n";
            (double, double) correlationTestResult21 = MSequenceTester.CorrelationTest(sourceFile, 2);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 2\nR = {correlationTestResult21.Item1}, Rref = {correlationTestResult21.Item2}\n";
            (double, double) correlationTestResult81 = MSequenceTester.CorrelationTest(sourceFile, 8);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 8\nR = {correlationTestResult81.Item1}, Rref = {correlationTestResult81.Item2}\n";
            (double, double) correlationTestResult91 = MSequenceTester.CorrelationTest(sourceFile, 9);
            encryptionTestsRichTextBox.Text += $"Correlation Test, k = 9\nR = {correlationTestResult91.Item1}, Rref = {correlationTestResult91.Item2}\n";


        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string fileName = "encrypted.txt";
            string sequence = File.ReadAllText("key.txt");
            Encrypter.Decrypt(fileName, sequence);
        }
    }
}
