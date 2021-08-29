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
    public partial class RuleManager : Form
    {
        public delegate void RuleChangedHandler();
        public event RuleChangedHandler RuleChanged;

        private List<Rule> rules;
        public RuleManager()
        {
            InitializeComponent();
            this.ruleDisplayCollection1.RuleChanged += () => { RuleChanged?.Invoke(); };
            rules = new List<Rule>();
        }
        public void SetRules(List<Rule> rules)
        {
            this.rules = rules;
            this.ruleDisplayCollection1.SetRules(rules);
        }
        public void AddRule()
        {
            Rule r = new Rule();
            rules.Add(r);

            ruleDisplayCollection1.DisplayRules();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRule();
        }
    }
}
