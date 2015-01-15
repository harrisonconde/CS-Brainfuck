/*
 *               C# Brainf*ck interpreter
 *              Created by: Harrison Conde
 *                       2015
 *         http://www.harriprojects.blogspot.com
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Brainfuck
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        // The main cell
        List<byte> buffer;

        // Indexes of every [ and ]
        List<int> loopIndexes;

        // arguments used by , operator
        char[] arguments;


        void Run(string code)
        {

            // Current operation index
            int opIndex = 0;

            // Current cell position
            int bufferIndex = 0;

            // Current argument index
            int argumentIndex = 0;

            // Create instances
            buffer = new List<byte>();
            loopIndexes = new List<int>();
            arguments = inputTxt.Text.ToCharArray();


            // Code operators
            char[] ops = code.ToCharArray();

            StringBuilder strB = new StringBuilder();

            try
            {

                while (opIndex < ops.Length)
                {

                    // dinamyc increase cells
                    if (bufferIndex >= buffer.Count) { buffer.Add(0); }

                    
                    switch (ops[opIndex])
                    {
                        case '+': // Increase current cell value
                            buffer[bufferIndex]++;
                            break;
                        case '-': // Decrease current cell value
                            buffer[bufferIndex]--;
                            break;
                        case '>': // Move to next cell 
                            bufferIndex++; break;
                        case '<': // Move to previous cell
                            bufferIndex--;
                            break;
                        case '.': // Get current cell value(ASCII)
                            strB.Append(char.ConvertFromUtf32(buffer[bufferIndex]));
                            break;
                        case '[': // Start loop
                            loopIndexes.Add(opIndex);
                            break;
                        case ']': // End loop
                            if (buffer[bufferIndex] != 0)
                            { opIndex = loopIndexes[loopIndexes.Count - 1]; }
                            else { loopIndexes.Remove(loopIndexes.Count - 1); }
                            break;
                        case ',': // Set current cell value with an argument

                            buffer[bufferIndex] = (byte)arguments[argumentIndex];
                            argumentIndex++;
                            break;
                    }

                    opIndex++;
                    cellCountView.Text = buffer.Count.ToString();
                }
            }

            // Catch runtime errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Show the BF output
            outputTxt.Text = strB.ToString();
            

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run(codeTxt.Text);
        }

    }
}
