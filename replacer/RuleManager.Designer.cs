
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ruleDisplayCollection1
            // 
            this.ruleDisplayCollection1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ruleDisplayCollection1.Location = new System.Drawing.Point(10, 10);
            this.ruleDisplayCollection1.Name = "ruleDisplayCollection1";
            this.ruleDisplayCollection1.Size = new System.Drawing.Size(780, 380);
            this.ruleDisplayCollection1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RuleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ruleDisplayCollection1);
            this.Name = "RuleManager";
            this.Text = "RuleManager";
            this.ResumeLayout(false);

        }

        #endregion

        private RuleDisplayCollection ruleDisplayCollection1;
        private System.Windows.Forms.Button button1;
    }
}