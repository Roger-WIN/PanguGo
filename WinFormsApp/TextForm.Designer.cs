namespace WinFormsApp
{
    partial class TextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.tableLayoutPanel_Text = new System.Windows.Forms.TableLayoutPanel();
            this.button_empty = new System.Windows.Forms.Button();
            this.label_Preconvert = new System.Windows.Forms.Label();
            this.label_Postconvert = new System.Windows.Forms.Label();
            this.textBox_Preconvert = new System.Windows.Forms.TextBox();
            this.textBox_Postconvert = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_ToFile = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Text
            // 
            this.tableLayoutPanel_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Text.ColumnCount = 3;
            this.tableLayoutPanel_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel_Text.Controls.Add(this.button_empty, 1, 1);
            this.tableLayoutPanel_Text.Controls.Add(this.label_Preconvert, 0, 0);
            this.tableLayoutPanel_Text.Controls.Add(this.label_Postconvert, 2, 0);
            this.tableLayoutPanel_Text.Controls.Add(this.textBox_Preconvert, 0, 1);
            this.tableLayoutPanel_Text.Controls.Add(this.textBox_Postconvert, 2, 1);
            this.tableLayoutPanel_Text.Controls.Add(this.button_convert, 1, 0);
            this.tableLayoutPanel_Text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel_Text.Location = new System.Drawing.Point(93, 94);
            this.tableLayoutPanel_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_Text.Name = "tableLayoutPanel_Text";
            this.tableLayoutPanel_Text.RowCount = 2;
            this.tableLayoutPanel_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Text.Size = new System.Drawing.Size(794, 376);
            this.tableLayoutPanel_Text.TabIndex = 0;
            // 
            // button_empty
            // 
            this.button_empty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_empty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_empty.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_empty.Location = new System.Drawing.Point(335, 190);
            this.button_empty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_empty.Name = "button_empty";
            this.button_empty.Size = new System.Drawing.Size(123, 70);
            this.button_empty.TabIndex = 5;
            this.button_empty.Text = "清空";
            this.button_empty.UseVisualStyleBackColor = false;
            this.button_empty.Click += new System.EventHandler(this.button_empty_Click);
            // 
            // label_Preconvert
            // 
            this.label_Preconvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Preconvert.AutoSize = true;
            this.label_Preconvert.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Preconvert.Location = new System.Drawing.Point(116, 18);
            this.label_Preconvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Preconvert.Name = "label_Preconvert";
            this.label_Preconvert.Size = new System.Drawing.Size(101, 38);
            this.label_Preconvert.TabIndex = 0;
            this.label_Preconvert.Text = "转换前";
            // 
            // label_Postconvert
            // 
            this.label_Postconvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Postconvert.AutoSize = true;
            this.label_Postconvert.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Postconvert.Location = new System.Drawing.Point(576, 18);
            this.label_Postconvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Postconvert.Name = "label_Postconvert";
            this.label_Postconvert.Size = new System.Drawing.Size(101, 38);
            this.label_Postconvert.TabIndex = 1;
            this.label_Postconvert.Text = "转换后";
            // 
            // textBox_Preconvert
            // 
            this.textBox_Preconvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Preconvert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Preconvert.Location = new System.Drawing.Point(2, 77);
            this.textBox_Preconvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Preconvert.Multiline = true;
            this.textBox_Preconvert.Name = "textBox_Preconvert";
            this.textBox_Preconvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Preconvert.Size = new System.Drawing.Size(329, 297);
            this.textBox_Preconvert.TabIndex = 2;
            // 
            // textBox_Postconvert
            // 
            this.textBox_Postconvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Postconvert.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Postconvert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Postconvert.Location = new System.Drawing.Point(462, 77);
            this.textBox_Postconvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Postconvert.Multiline = true;
            this.textBox_Postconvert.Name = "textBox_Postconvert";
            this.textBox_Postconvert.ReadOnly = true;
            this.textBox_Postconvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Postconvert.Size = new System.Drawing.Size(330, 297);
            this.textBox_Postconvert.TabIndex = 3;
            // 
            // button_convert
            // 
            this.button_convert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_convert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_convert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_convert.Location = new System.Drawing.Point(335, 2);
            this.button_convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(123, 71);
            this.button_convert.TabIndex = 4;
            this.button_convert.Text = "转换";
            this.button_convert.UseVisualStyleBackColor = false;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label_ToFile
            // 
            this.label_ToFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ToFile.AutoSize = true;
            this.label_ToFile.BackColor = System.Drawing.SystemColors.Info;
            this.label_ToFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ToFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ToFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ToFile.Location = new System.Drawing.Point(93, 34);
            this.label_ToFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ToFile.Name = "label_ToFile";
            this.label_ToFile.Size = new System.Drawing.Size(99, 32);
            this.label_ToFile.TabIndex = 1;
            this.label_ToFile.Text = "转换文件";
            this.label_ToFile.Click += new System.EventHandler(this.label_ToFile_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(971, 570);
            this.Controls.Add(this.label_ToFile);
            this.Controls.Add(this.tableLayoutPanel_Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TextForm";
            this.Text = "PanguGo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextForm_FormClosed);
            this.tableLayoutPanel_Text.ResumeLayout(false);
            this.tableLayoutPanel_Text.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Text;
        private System.Windows.Forms.Label label_Preconvert;
        private System.Windows.Forms.Label label_Postconvert;
        private System.Windows.Forms.TextBox textBox_Preconvert;
        private System.Windows.Forms.TextBox textBox_Postconvert;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_empty;
        private System.Windows.Forms.Label label_ToFile;
    }
}