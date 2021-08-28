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
        private List<Rule> rules;
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
                panel1.Controls.Add(rd);
            }
        }
        public void SetRules(List<Rule> rules)
        {
            this.rules = rules;
            DisplayRules();
        }

    }
}
