using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace replacer
{
    public partial class RuleDisplayCollection : UserControl
    {
        public delegate void RuleChangedHandler();
        public event RuleChangedHandler RuleChanged;
        private List<Rule> rules;
        private int rightClickIndex = -5;
        public RuleDisplayCollection()
        {
            rules = new List<Rule>();
            InitializeComponent();
        }
        private void RuleDisplayCollection_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 10;
            panel1.Height = this.Height - 10;
        }
        public void DisplayRules()
        {
            panel1.Controls.Clear();
            for (int n = 0; n < rules.Count; ++n)
            {
                Rule r = rules[n];
                RuleDisplay rd = new RuleDisplay(r);
                rd.Width = panel1.Width;
                rd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                rd.Location = new Point(0, rd.Height * n);
                rd.RuleChanged += () => { RuleChanged?.Invoke(); };
                
                rd.RightClicked += (sender, e) => { 
                    RuleDisplay rdi = (RuleDisplay)sender;
                    rightClickIndex = rules.IndexOf(rdi.Rule);
                    RightClickMenu.Show(this, rdi.Location);
                };
                panel1.Controls.Add(rd);
            }
        }
        public void SetRules(List<Rule> rules)
        {
            this.rules = rules;
            DisplayRules();
        }
        public void DeleteRule(int ruleIndex)
        {
            rules.RemoveAt(ruleIndex);
            DisplayRules();
        }
        private void swapRules(int q, int r)
        {
            Rule temp = rules[q];
            rules[q] = rules[r];
            rules[r] = temp;
        }
        private void moveUp(int index)
        {
            if (index <= 0 || index > rules.Count-1)
            {
                return;
            }
            swapRules(index, index - 1);
        }
        private void moveDown(int index)
        {
            if (index < 0 || index > rules.Count -2)
            {
                return;
            }

            swapRules(index, index + 1);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRule(rightClickIndex);
            RuleChanged?.Invoke();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveUp(rightClickIndex);
            DisplayRules();
            RuleChanged?.Invoke();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveDown(rightClickIndex);
            DisplayRules();
            RuleChanged?.Invoke();
        }
    }
}
