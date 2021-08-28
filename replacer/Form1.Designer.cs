
namespace replacer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_New = new System.Windows.Forms.RichTextBox();
            this.rtb_Old = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.b_pasteIn = new System.Windows.Forms.Button();
            this.b_Replace = new System.Windows.Forms.Button();
            this.b_copy = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.l_Message = new System.Windows.Forms.Label();
            this.cb_highlightControl = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.rtb_New, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.rtb_Old, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(878, 357);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // rtb_New
            // 
            this.rtb_New.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_New.Location = new System.Drawing.Point(442, 3);
            this.rtb_New.Name = "rtb_New";
            this.rtb_New.Size = new System.Drawing.Size(433, 351);
            this.rtb_New.TabIndex = 1;
            this.rtb_New.Text = "";
            // 
            // rtb_Old
            // 
            this.rtb_Old.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Old.Location = new System.Drawing.Point(3, 3);
            this.rtb_Old.Name = "rtb_Old";
            this.rtb_Old.Size = new System.Drawing.Size(433, 351);
            this.rtb_Old.TabIndex = 0;
            this.rtb_Old.Text = "";
            this.rtb_Old.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.b_pasteIn, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.b_Replace, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.b_copy, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 411);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(878, 47);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // b_pasteIn
            // 
            this.b_pasteIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pasteIn.Location = new System.Drawing.Point(3, 3);
            this.b_pasteIn.Name = "b_pasteIn";
            this.b_pasteIn.Size = new System.Drawing.Size(286, 41);
            this.b_pasteIn.TabIndex = 2;
            this.b_pasteIn.Text = "Paste Input";
            this.b_pasteIn.UseVisualStyleBackColor = true;
            this.b_pasteIn.Click += new System.EventHandler(this.b_pasteIn_Click);
            // 
            // b_Replace
            // 
            this.b_Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Replace.Location = new System.Drawing.Point(295, 3);
            this.b_Replace.Name = "b_Replace";
            this.b_Replace.Size = new System.Drawing.Size(286, 41);
            this.b_Replace.TabIndex = 0;
            this.b_Replace.Text = "Replace";
            this.b_Replace.UseVisualStyleBackColor = true;
            this.b_Replace.Click += new System.EventHandler(this.b_Replace_Click);
            // 
            // b_copy
            // 
            this.b_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_copy.Location = new System.Drawing.Point(587, 3);
            this.b_copy.Name = "b_copy";
            this.b_copy.Size = new System.Drawing.Size(288, 41);
            this.b_copy.TabIndex = 1;
            this.b_copy.Text = "Copy Output";
            this.b_copy.UseVisualStyleBackColor = true;
            this.b_copy.Click += new System.EventHandler(this.b_copy_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.l_Message, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cb_highlightControl, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 464);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(878, 33);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // l_Message
            // 
            this.l_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Message.AutoSize = true;
            this.l_Message.Location = new System.Drawing.Point(3, 0);
            this.l_Message.Name = "l_Message";
            this.l_Message.Size = new System.Drawing.Size(433, 33);
            this.l_Message.TabIndex = 3;
            this.l_Message.Text = "Nothing to report";
            this.l_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_Message.Click += new System.EventHandler(this.l_Message_Click);
            // 
            // cb_highlightControl
            // 
            this.cb_highlightControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_highlightControl.AutoSize = true;
            this.cb_highlightControl.Location = new System.Drawing.Point(442, 3);
            this.cb_highlightControl.Name = "cb_highlightControl";
            this.cb_highlightControl.Size = new System.Drawing.Size(433, 27);
            this.cb_highlightControl.TabIndex = 4;
            this.cb_highlightControl.Text = "Disable Highlighting";
            this.cb_highlightControl.UseVisualStyleBackColor = true;
            this.cb_highlightControl.CheckedChanged += new System.EventHandler(this.cb_highlightControl_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Text Replacer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RichTextBox rtb_New;
        private System.Windows.Forms.RichTextBox rtb_Old;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button b_Replace;
        private System.Windows.Forms.Button b_copy;
        private System.Windows.Forms.Button b_pasteIn;
        private System.Windows.Forms.Label l_Message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox cb_highlightControl;
        private System.Windows.Forms.Button button1;
    }
}

