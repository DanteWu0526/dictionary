using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise03
{
    public partial class Form1 : Form
    {
        static string dictionaryFile = "dictionary.txt";
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            LoadDictionary();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string addName = addTextBox.Text;
            if (addName.Length == 0 )
            {
                MessageBox.Show("輸入資料不齊全");
            }
            else
            {
                dictionary[addName] = addName;
                using (StreamWriter writer = new StreamWriter(dictionaryFile))
                {
                    foreach (var item in dictionary)
                    {
                        writer.WriteLine(item.Key, item.Value);
                    }
                }
                MessageBox.Show("以新增");
            }
        }

        private void InquireButton_Click(object sender, EventArgs e)
        {
            LoadDictionary();
            string Inquire = InquireTextBox.Text;
            ansTextBox.Clear();
            if (dictionary.ContainsKey(Inquire))
            {
                ansTextBox.AppendText(Inquire + "的中文翻譯為:" + dictionary[Inquire]);
            }
            else
            {
                MessageBox.Show("查無此單字");
                InquireTextBox.Clear();
            }
        }

        /// <summary>
        /// 載入字典
        /// </summary>
        static void LoadDictionary()
        {
            if (File.Exists(dictionaryFile))
            {
                using (StreamReader reader = new StreamReader(dictionaryFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string enName = parts[0].Trim();
                            string chName = parts[1].Trim();
                            dictionary[enName] = chName;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("字典尚未建立");
            }
        }

    }
}
