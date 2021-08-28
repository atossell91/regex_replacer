using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replacer
{
    public partial class Form1 : Form
    {
        private List<Rule> rules;
        public Form1()
        {
            InitializeComponent();
            rules = new List<Rule>();
        }
        private void replaceText()
        {
            string input = rtb_Old.Text;
            string output = input;
            try
            {
                foreach (Rule rule in rules)
                {
                    output = Regex.Replace(input, rule.Expression, rule.Replacement);
                    l_Message.Text = "";
                }
            }
            catch (Exception e)
            {
                l_Message.Text = "A parse error has ocurred. Please try again";
            }
            rtb_New.Text = output;
        }
        private void unhighlight()
        {
            rtb_Old.SelectAll();
            rtb_Old.SelectionColor = Color.Black;
            rtb_Old.SelectionBackColor = Color.White;
        }
        private void highlight()
        {
            if (cb_highlightControl.Checked)
            {
                return;
            }
            try
            {
                unhighlight();
                foreach (Rule rule in rules)
                {
                    MatchCollection matches = Regex.Matches(rtb_Old.Text, rule.Expression);
                    foreach (Match match in matches)
                    {
                        rtb_Old.Select(match.Index, match.Length);
                        rtb_Old.SelectionColor = rule.RuleColor;
                        rtb_Old.SelectionBackColor = Color.Blue;
                        rtb_Old.DeselectAll();
                    }
                }
            }
            catch (Exception e) {
                unhighlight();
            }
        }
        private void b_Replace_Click(object sender, EventArgs e)
        {
            replaceText();
        }
        private void regexText()
        {
            //unhighlight();
            highlight();
            replaceText();
        }
        private void TextChanged(object sender, EventArgs e)
        {
            regexText();
        }

        private void b_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_New.Text);
        }

        private void b_pasteIn_Click(object sender, EventArgs e)
        {
            rtb_Old.Text = Clipboard.GetText();
        }

        private void l_Message_Click(object sender, EventArgs e)
        {

        }

        private void cb_highlightControl_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (!cb.Checked)
            {
                regexText();
            }
            else
            {
                unhighlight();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RuleManager rm = new RuleManager();
            rm.SetRules(rules);
            Action a = new Action(() => { });
            rm.RuleChanged += () => { this.BeginInvoke(new Action(() => { regexText(); })); };
            WaitCallback wc = new WaitCallback((obj)=> { rm.ShowDialog(); });
            ThreadPool.QueueUserWorkItem(wc);
        }
    }
}
