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
        public delegate void RuleChangedHandler();
        public event RuleChangedHandler RuleChanged;
        public event EventHandler RightClicked;
        public Rule Rule { get; private set; }
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

            this.Rule = rule;
            rtb_expression.Text = rule.Expression;
            rtb_replacement.Text = rule.Replacement;
            cb_ruleEnabled.Checked = rule.Enabled;
            pb_color.BackColor = rule.RuleColor;

            isConstructor = false;
        }
        private void rtb_expression_TextChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            RichTextBox tb = (RichTextBox)sender;
            Rule.Expression = tb.Text;

            RuleChanged?.Invoke();
        }

        private void rtb_replacement_TextChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            RichTextBox tb = (RichTextBox)sender;
            Rule.Replacement = tb.Text;

            RuleChanged?.Invoke();
        }
        private void cb_ruleEnabled_CheckedChanged(object sender, EventArgs e)
        {
            //  Needed to stop an endless loop during construction
            if (isConstructor) return;

            //  Only runs after constructor
            CheckBox cb = (CheckBox)sender;
            Rule.Enabled = cb.Checked;

            RuleChanged?.Invoke();
        }
        private void controlRightClicked()
        {
            RightClicked?.Invoke(this, EventArgs.Empty);
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
            Rule.RuleColor = cd.Color;

            RuleChanged?.Invoke();
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                controlRightClicked();
            }
        }
    }
}
