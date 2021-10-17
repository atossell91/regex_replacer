using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

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

        private void saveRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*JSON files (*.json) | *.json";
            sfd.DefaultExt = ".json";
            sfd.AddExtension = true;
            sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            JsonSerializerOptions jso = new JsonSerializerOptions() { WriteIndented = true };
            string content = JsonSerializer.Serialize(rules, jso);
            File.WriteAllText(sfd.FileName, content);
        }

        private void loadRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json) | *.json";
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string content = File.ReadAllText(ofd.FileName);
            List<Rule> newRules = JsonSerializer.Deserialize<List<Rule>>(content);
            rules.AddRange(newRules);
            ruleDisplayCollection1.DisplayRules();
            //RuleChanged?.Invoke();
        }
    }
}
