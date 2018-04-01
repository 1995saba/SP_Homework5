using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace T9App
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string engPath = "eng.txt";
        private string rusPath = "rus.txt";
        private string path;
        private List<string> rusDictionary;
        private List<string> engDictionary;
        private List<string> currentDictionary;
        private Thread thread;
        public Form()
        {
            InitializeComponent();
            languageButton.Text = "English";
            path = engPath;
            rusDictionary = new List<string>();
            engDictionary = new List<string>();
            using(StreamReader reader = new StreamReader(engPath))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine();
                    engDictionary.Add(word);
                }
            }
            using (StreamReader reader = new StreamReader(rusPath))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine();
                    rusDictionary.Add(word);
                }
            }
            currentDictionary = engDictionary;
        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                languageButton.Text = "Русский";
                path = rusPath;
                currentDictionary = rusDictionary;
            }
            else
            {
                languageButton.Text = "English";
                path = engPath;
                currentDictionary = engDictionary;
            }
        }

        private void FindWord()
        {
            string word;
            if (richTextBox.Text.Contains(" ") == true)
            {
                word = currentDictionary
                    .First(p => p.StartsWith(
                        richTextBox.Text.Substring(
                            richTextBox.Text.LastIndexOf(' '))) == true);
            }
            else
            {
                word = currentDictionary
                    .First(p => p.StartsWith(
                        richTextBox.Text) == true);
            }
            wordLabel.Text = word;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox.Text += " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";
                
            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";

            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";

            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";

            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";

            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";
            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";

            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                richTextBox.Text += "a";
            }
            else
            {
                richTextBox.Text += "а";
            }
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox.Text.Last()!=' ')
            {
                FindWord();
            }
        }
    }
}
