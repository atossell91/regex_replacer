
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
            this.tb_expression = new System.Windows.Forms.TextBox();
            this.tb_replacement = new System.Windows.Forms.TextBox();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.cb_ruleEnabled = new System.Windows.Forms.CheckBox();
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
            this.tableLayoutPanel1.Controls.Add(this.tb_replacement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_expression, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_color, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_ruleEnabled, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_expression
            // 
            this.tb_expression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_expression.Location = new System.Drawing.Point(3, 3);
            this.tb_expression.Name = "tb_expression";
            this.tb_expression.Size = new System.Drawing.Size(292, 35);
            this.tb_expression.TabIndex = 0;
            this.tb_expression.TextChanged += new System.EventHandler(this.tb_expression_TextChanged);
            // 
            // tb_replacement
            // 
            this.tb_replacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_replacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_replacement.Location = new System.Drawing.Point(301, 3);
            this.tb_replacement.Name = "tb_replacement";
            this.tb_replacement.Size = new System.Drawing.Size(292, 35);
            this.tb_replacement.TabIndex = 1;
            this.tb_replacement.TextChanged += new System.EventHandler(this.tb_replacement_TextChanged);
            // 
            // pb_color
            // 
            this.pb_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_color.Location = new System.Drawing.Point(599, 3);
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
            this.cb_ruleEnabled.Location = new System.Drawing.Point(679, 3);
            this.cb_ruleEnabled.Name = "cb_ruleEnabled";
            this.cb_ruleEnabled.Size = new System.Drawing.Size(24, 37);
            this.cb_ruleEnabled.TabIndex = 3;
            this.cb_ruleEnabled.UseVisualStyleBackColor = true;
            this.cb_ruleEnabled.CheckedChanged += new System.EventHandler(this.cb_ruleEnabled_CheckedChanged);
            // 
            // RuleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RuleDisplay";
            this.Size = new System.Drawing.Size(733, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_replacement;
        private System.Windows.Forms.TextBox tb_expression;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.CheckBox cb_ruleEnabled;
    }
}
