
namespace replacer
{
    partial class RuleDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.cb_ruleEnabled = new System.Windows.Forms.CheckBox();
            this.rtb_expression = new System.Windows.Forms.RichTextBox();
            this.rtb_replacement = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.rtb_replacement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_color, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_ruleEnabled, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_expression, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_color
            // 
            this.pb_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_color.Location = new System.Drawing.Point(611, 3);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(74, 37);
            this.pb_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_color.TabIndex = 2;
            this.pb_color.TabStop = false;
            this.pb_color.Click += new System.EventHandler(this.pb_color_Click);
            // 
            // cb_ruleEnabled
            // 
            this.cb_ruleEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ruleEnabled.AutoSize = true;
            this.cb_ruleEnabled.Location = new System.Drawing.Point(691, 3);
            this.cb_ruleEnabled.Name = "cb_ruleEnabled";
            this.cb_ruleEnabled.Size = new System.Drawing.Size(25, 37);
            this.cb_ruleEnabled.TabIndex = 3;
            this.cb_ruleEnabled.UseVisualStyleBackColor = true;
            this.cb_ruleEnabled.CheckedChanged += new System.EventHandler(this.cb_ruleEnabled_CheckedChanged);
            // 
            // rtb_expression
            // 
            this.rtb_expression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_expression.Location = new System.Drawing.Point(3, 3);
            this.rtb_expression.Multiline = false;
            this.rtb_expression.Name = "rtb_expression";
            this.rtb_expression.Size = new System.Drawing.Size(298, 37);
            this.rtb_expression.TabIndex = 4;
            this.rtb_expression.Text = "";
            this.rtb_expression.TextChanged += new System.EventHandler(this.rtb_expression_TextChanged);
            this.rtb_expression.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // rtb_replacement
            // 
            this.rtb_replacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_replacement.Location = new System.Drawing.Point(307, 3);
            this.rtb_replacement.Multiline = false;
            this.rtb_replacement.Name = "rtb_replacement";
            this.rtb_replacement.Size = new System.Drawing.Size(298, 37);
            this.rtb_replacement.TabIndex = 5;
            this.rtb_replacement.Text = "";
            this.rtb_replacement.TextChanged += new System.EventHandler(this.rtb_replacement_TextChanged);
            this.rtb_replacement.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // RuleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RuleDisplay";
            this.Size = new System.Drawing.Size(746, 60);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.CheckBox cb_ruleEnabled;
        private System.Windows.Forms.RichTextBox rtb_replacement;
        private System.Windows.Forms.RichTextBox rtb_expression;
    }
}
