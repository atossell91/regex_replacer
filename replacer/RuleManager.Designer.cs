
namespace replacer
{
    partial class RuleManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ruleDisplayCollection1 = new replacer.RuleDisplayCollection();
            this.b_addRule = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruleDisplayCollection1
            // 
            this.ruleDisplayCollection1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ruleDisplayCollection1.Location = new System.Drawing.Point(10, 40);
            this.ruleDisplayCollection1.Name = "ruleDisplayCollection1";
            this.ruleDisplayCollection1.Size = new System.Drawing.Size(780, 350);
            this.ruleDisplayCollection1.TabIndex = 0;
            // 
            // b_addRule
            // 
            this.b_addRule.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_addRule.Location = new System.Drawing.Point(270, 400);
            this.b_addRule.Name = "b_addRule";
            this.b_addRule.Size = new System.Drawing.Size(250, 40);
            this.b_addRule.TabIndex = 1;
            this.b_addRule.Text = "Add Rule";
            this.b_addRule.UseVisualStyleBackColor = true;
            this.b_addRule.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveRulesToolStripMenuItem,
            this.loadRulesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveRulesToolStripMenuItem
            // 
            this.saveRulesToolStripMenuItem.Name = "saveRulesToolStripMenuItem";
            this.saveRulesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveRulesToolStripMenuItem.Text = "Save Rules";
            this.saveRulesToolStripMenuItem.Click += new System.EventHandler(this.saveRulesToolStripMenuItem_Click);
            // 
            // loadRulesToolStripMenuItem
            // 
            this.loadRulesToolStripMenuItem.Name = "loadRulesToolStripMenuItem";
            this.loadRulesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadRulesToolStripMenuItem.Text = "Load Rules";
            this.loadRulesToolStripMenuItem.Click += new System.EventHandler(this.loadRulesToolStripMenuItem_Click);
            // 
            // RuleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_addRule);
            this.Controls.Add(this.ruleDisplayCollection1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RuleManager";
            this.Text = "RuleManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RuleDisplayCollection ruleDisplayCollection1;
        private System.Windows.Forms.Button b_addRule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRulesToolStripMenuItem;
    }
}