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

namespace dictionary
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

        /// <summary>
        /// 新增字典功能
        /// </summary>
        private void AddDictionary()
        {
            string addEnName = addEnTextBox.Text;
            string addChName = addChTextBox.Text;
            if (addEnName.Length == 0 || addChName.Length == 0)
            {
                MessageBox.Show("輸入資料不齊全");
            }
            else
            {
                string dic = addEnName + "," + addChName;
                dictionary[dic] = dic;

                using (StreamWriter writer = new StreamWriter(dictionaryFile, true))
                {
                    foreach (var item in dictionary)
                    {
                        writer.WriteLine(item.Key, item.Value);
                    }
                }
                MessageBox.Show("已新增");
            }
        }

        /// <summary>
        /// 翻譯功能
        /// </summary>
        private void Rendering()
        {
            LoadDictionary();
            string Inquire = InquireTextBox.Text;
            ansTextBox.Clear();
            if (dictionary.ContainsKey(Inquire))
            {
                ansTextBox.AppendText(Inquire + "的中文翻譯為:" + dictionary[Inquire]);
            }
            else if (dictionary.ContainsValue(Inquire))
            {
                var matchingKeys = dictionary.Where(pair => pair.Value == Inquire).Select(pair => pair.Key);
                if (matchingKeys.Any())
                {
                    ansTextBox.AppendText(Inquire + "的英文翻譯為:" + string.Join(",", matchingKeys));
                }
            }
            else
            {
                MessageBox.Show("查無此單字");
                InquireTextBox.Clear();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddDictionary();
        }

        private void InquireButton_Click(object sender, EventArgs e)
        {
            Rendering();
        }
    }
}
