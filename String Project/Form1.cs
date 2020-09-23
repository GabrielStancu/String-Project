using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            char[] aux = input.ToCharArray();
            Array.Reverse(aux);
            string output = new string(aux);
            txtOutput.Text = string.Empty;
            txtOutput.Text = output;
        }

        private void btPigLatin_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            char[] s = input.ToCharArray();
            string output = input + s[0] + "ay";
            output = output.Substring(1);
            txtOutput.Text = string.Empty;
            txtOutput.Text = output;
        }

        private void btVowels_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string vocale = "aeiouAEIOU";
            int c = 0;
            for (int i = 0;i<input.Length;i++)
            {
                if (vocale.Contains(input[i]) == true ) c++;
            }
            string s = c.ToString();
            txtOutput.Text = string.Empty;
            txtOutput.Text = s;
        }

        private void btPalindrom_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            char[] s = input.ToCharArray();
            Array.Reverse(s);
            string output = new string(s);
            txtOutput.Text = string.Empty;
            if (output == input) txtOutput.Text = "This is a palindrome!";
            if (output != input) txtOutput.Text = "This is not a palindrome!";
        }

        private void btWords_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int c = 1;
            for (int i = 0; i < input.Length; i++)
                if (input[i] == ' ') c++;
            string output = c.ToString();
            txtOutput.Text = string.Empty;
            txtOutput.Text = output;
        }
    }
}
