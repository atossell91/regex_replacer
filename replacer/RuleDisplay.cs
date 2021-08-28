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
    public partial class RuleDisplay : UserControl
    {
        private Rule rule;
        private bool isConstructor = false;
        public RuleDisplay()
        {
            isConstructor = true;

            InitializeComponent();

            isConstructor = false;
        }
        public RuleDisplay(Rule rule) : this()
        {
            isConstructor = true;

            this.rule = rule;
            tb_expression.Text = rule.Expression;
            tb_replacement.Text = rule.Replacement;
            cb_ruleEnabled.Checked = rule.Enabled;
            pb_color.BackColor = rule.RuleColor;

            isConstructor = false;
        }
        private void tb_expression_TextChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            TextBox tb = (TextBox)sender;
            rule.Expression = tb.Text;
        }

        private void tb_replacement_TextChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            TextBox tb = (TextBox)sender;
            rule.Replacement = tb.Text;
        }
        private void cb_ruleEnabled_CheckedChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            CheckBox cb = (CheckBox)sender;
            rule.Enabled = cb.Checked;
        }
        private void pb_color_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //  If dialog is OK
            pb.BackColor = cd.Color;
            rule.RuleColor = cd.Color;
        }
    }
}
