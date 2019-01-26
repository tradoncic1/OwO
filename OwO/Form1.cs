using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwO
{
    public partial class Form1 : Form
    {
        Random nani = new Random();
        List<string> kawaii = new List<string>();
        List<string> search = new List<string>();

        public Form1()
        {
            //fill with strings to insert
            fileToKawaii();

            //fill with strings to search for
            fileToSearch();
            
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //reset output on every run
            outputBox.Text = "";

            //null terminator needed for search algorithm
            string input = inputBox.Text + '\0';

            List<int> indexes = indices(input, search);
            //sort in descending order for easier insertion later on
            indexes = desc(indexes);

            for (int i = 0; i < indexes.Count; i++)
            {
                //randomly picks which string to insert
                int owo = nani.Next(0, kawaii.Count);

                input = input.Insert(indexes[i], " " + kawaii[owo]);
            }

            outputBox.Text += input;
        }

        //simple sort to make list descending order
        private List<int> desc(List<int> indexes)
        {
            indexes.Sort();
            indexes.Reverse();

            return indexes;
        }

        //function that returns list of indexes of every substring occurence(excludes suffixed words)
        private List<int> indices(string full, List<string> sub)
        {
            List<int> retVal = new List<int>();

            for (int i = 0; i < sub.Count; i++)
            {
                int index = full.IndexOf(sub[i]);

                while (true)
                {
                    //checks if last occurance check is true
                    if (index == -1)
                        break;

                    int found = index + sub[i].Length;

                    //check if theres a suffix to the substr if not add tolist
                    if (!Char.IsLetter(full[found]))
                    {
                        retVal.Add(index + sub[i].Length);
                    }

                    //searches for next occurance of word
                    index = full.IndexOf(sub[i], index + sub[i].Length);
                }
            }

            return retVal;
        }

        //copies output content to clipboard
        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }

        //opens popup to add triggers or emojis
        private void addBtn_Click(object sender, EventArgs e)
        {
            var form = new Form2(this);
            form.Show();
        }

        //function to add new trigger to file and list
        public void addTrigger(string str)
        {
            var file = File.AppendText(".\\search.txt");
            file.WriteLine(str);
            this.search.Add(str);
            file.Close();
        }

        //function to add new emoji to file and list
        public void addKawaii(string str)
        {
            var file = File.AppendText(".\\kawaii.txt");
            file.WriteLine(str);
            this.kawaii.Add(str);
            file.Close();
        }

        //function to read file contents and save to search list
        private void fileToSearch()
        {
            var file = new StreamReader(".\\search.txt");
            var line = string.Empty;

            while ((line = file.ReadLine()) != null)
            {
                search.Add(line);
            }

            file.Close();
        }

        //function to read file contents and save to kawaii list
        private void fileToKawaii()
        {
            var file = new StreamReader(".\\kawaii.txt");
            var line = string.Empty;

            while ((line = file.ReadLine()) != null)
            {
                kawaii.Add(line);
            }

            file.Close();
        }
    }
}
