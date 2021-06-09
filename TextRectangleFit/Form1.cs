using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRectangleFit
{
    public struct SplitWord
    {
        public string PartThatFits;
        public string Remainder;
    }

    public partial class Form1 : Form
    {
        Rectangle _MsgRect = new Rectangle(56, 153, 159, 280);
        int _Padding = 7;

        string[] _SourceSplitByPeriods = File.ReadAllText("source.txt", Encoding.UTF8).Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        Random _RNG = new Random();
        string _Msg = "TEST";

        int _MinFrontSize = 14;
        int _WidthToFit => _MsgRect.Width - _Padding * 2;

        int _MaxRows;

        Font _Impact;
        StringFormat _SF;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _Impact = new Font("Impact", _MinFrontSize);
            _SF = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            int singleRowHeight;
            using (Graphics graphics = Graphics.FromImage(new Bitmap(1, 1)))
            {
                singleRowHeight = Convert.ToInt32(graphics.MeasureString("ss", _Impact).Height); ;
                _MaxRows = _MsgRect.Height / singleRowHeight;
            }

            LB_MaxRows.Text = $"Max rows: {_MaxRows}, Single row Height: {singleRowHeight}";
            LB_Rect.Text = $"Msg rect:" + _MsgRect.ToString();

            NUD_Padding.Value = _Padding;

            BT_Generate.PerformClick();
        }
        private void BT_Generate_Click(object sender, EventArgs e)
        {
            _Msg = GenerateMessageFromTextFile();
            PB_Pic.Invalidate();
        }
        private string GenerateMessageFromTextFile()
        {
            return GenerateMessage(_SourceSplitByPeriods[_RNG.Next(0, _SourceSplitByPeriods.Length)]);
        }
        private string GenerateMessage(string source)
        {
            if (String.IsNullOrWhiteSpace(source))
                return "null";

            string initialMsg = source.Replace("\n", "");

            if (CB_Double.Checked)
                initialMsg += initialMsg;

            RTB_Text.Text = initialMsg;
            Text = $"Initial Words: {GetWordCount(initialMsg)}";

            string newMsg = "";

            if (!CB_LineBreak.Checked)
            {
                for (int startIndex = 0, length = 1, rows = 1; rows <= _MaxRows;)
                {
                    string subString = initialMsg.Substring(startIndex, length);
                    if (startIndex + length == initialMsg.Length)
                    {
                        newMsg += subString;
                        break;
                    }

                    string subStringNext = initialMsg.Substring(startIndex, length + 1);
                    if (DoesStringFit(subString))
                    {
                        if (DoesStringFit(subStringNext))
                        {
                            length++;
                            continue;
                        }

                        newMsg += subString + "\n";
                        rows++;
                        startIndex += length;
                        length = 1;
                    }
                    else
                    {
                        throw new Exception("Single symbol is larger than max width!");
                    }
                }
            }
            else //with line break 
            {
                List<string> wordList = initialMsg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int startIndex = 0, length = 1, rows = 1; newMsg.Split('\n').Length <= _MaxRows;)
                {
                    string subString = GetStringFromWordList(startIndex, length, wordList);
                    if (startIndex + length == wordList.Count)
                    {
                        if (DoesStringFit(subString))
                            newMsg += subString;
                        else
                            goto SubStringDoesntFit;
                        break;
                    }

                    string subStringNext = GetStringFromWordList(startIndex, length + 1, wordList);
                    if (DoesStringFit(subString))
                    {
                        if (DoesStringFit(subStringNext))
                        {
                            length++;
                            continue;
                        }


                        newMsg += subString + "\n";
                        rows++;
                        startIndex += length;
                        length = 1;
                        continue;
                    }

                SubStringDoesntFit: //length == 1
                    if (CB_DeleteLargeWords.Checked)
                        wordList.RemoveAt(startIndex);
                    else
                    {
                        var splitWord = GetSplitWord(subString);
                        wordList[startIndex] = splitWord.PartThatFits;
                        wordList.Insert(startIndex + 1, splitWord.Remainder);
                    }
                }
            }

            newMsg = newMsg.Trim();
            Text += $", Actual Rows: {newMsg.Split('\n').Length}";
            return newMsg;
        }
        private SplitWord GetSplitWord(string word)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                string half = word.Substring(0, word.Length / 2);

                while (!DoesStringFit(half))
                    half = half.Substring(0, half.Length / 2);

                int length = 1;
                while (DoesStringFit(half + word.Substring(half.Length, length)))
                    length++;

                return new SplitWord()
                {
                    PartThatFits = word.Substring(0, half.Length + length - 1),
                    Remainder = word.Substring(half.Length + length - 1)
                };
            }
        }
        private bool DoesStringFit(string str)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                return g.MeasureString(str, _Impact).Width < _WidthToFit;
            }
        }
        private string GetStringFromWordList(int startIndex, int length, List<string> list)
        {
            return string.Join(" ", list.GetRange(startIndex, length));
        }
        private int GetWordCount(string msg)
        {
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < msg.Length && char.IsWhiteSpace(msg[index]))
                index++;

            while (index < msg.Length)
            {
                // check if current char is part of a word
                while (index < msg.Length && !char.IsWhiteSpace(msg[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < msg.Length && char.IsWhiteSpace(msg[index]))
                    index++;
            }

            return wordCount;
        }
        private void PB_Pic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, _MsgRect);
            e.Graphics.DrawString(_Msg, _Impact, Brushes.Black, _MsgRect, _SF);
        }
        private void NUD_Padding_ValueChanged(object sender, EventArgs e)
        {
            _Padding = Convert.ToInt32(NUD_Padding.Value);
        }
        private void BT_UseInputFromRTB_Click(object sender, EventArgs e)
        {
            _Msg = GenerateMessage(RTB_Text.Text);
            PB_Pic.Invalidate();
        }
    }
}
