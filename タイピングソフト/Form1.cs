using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace タイピングソフト
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Button> keyButtons = new Dictionary<string, Button>();
        private string[] lines;
        private int currentLineIndex = 0;

        public Form1()
        {
            InitializeComponent();
            CreateKeyboard();
        }
        
        private void btnLoadText_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lines = File.ReadAllLines(openFileDialog.FileName);
                currentLineIndex = 0;
                ShowNextLine();
            }
        }

        private void ShowNextLine()
        {
            if (currentLineIndex < lines.Length)
            {
                lblText.Text = lines[currentLineIndex];
                txtInput.Text = "";
                txtInput.BackColor = Color.White;
            }
            else
            {
                lblText.Text = "完了！";
                txtInput.Text = "";
            }
        }

        //キーボードを表示
        private void CreateKeyboard()
        {
            string[] keys = {
                "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
                "A", "S", "D", "F", "G", "H", "J", "K", "L",
                "Z", "X", "C", "V", "B", "N", "M", "SPACE"
            };

            foreach (var key in keys)
            {
                Button btn = new Button();
                btn.Text = key == "SPACE" ? "␣" : key;
                btn.Tag = key;
                btn.Width = 40;
                btn.Height = 40;
                btn.Margin = new Padding(2);
                keyButtons[key] = btn;
                flowKeyboard.Controls.Add(btn);
            }
        }

        //文字を入力
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(lblText.Text) || lblText.Text == "完了！")
                return;

            if (txtInput.Text.Length >= lblText.Text.Length)
            {
                e.Handled = true;
                return;
            }

            char expectedChar = lblText.Text[txtInput.Text.Length];
            string displayKey = e.KeyChar == ' ' ? "SPACE" : e.KeyChar.ToString().ToUpper();

            HighlightKey(displayKey);

            if (e.KeyChar == expectedChar)
            {
                txtInput.BackColor = Color.White;
            }
            else
            {
                txtInput.BackColor = Color.MistyRose;
                e.Handled = true; 
            }

            if (txtInput.Text.Length + 1 == lblText.Text.Length && e.KeyChar == expectedChar)
            {
                currentLineIndex++;
                Timer t = new Timer();
                t.Interval = 100;
                t.Tick += (s, ev) => {
                    t.Stop();
                    ShowNextLine();
                };
                t.Start();
            }
        }

        private void HighlightKey(string key)
        {
            foreach (var btn in keyButtons.Values)
                btn.BackColor = SystemColors.Control;

            if (keyButtons.ContainsKey(key))
                keyButtons[key].BackColor = Color.Yellow;
        }
    }
}
