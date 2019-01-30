namespace WinFormsApp
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.tableLayoutPanel_Welcome = new System.Windows.Forms.TableLayoutPanel();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.button_chooseText = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Welcome
            // 
            this.tableLayoutPanel_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Welcome.ColumnCount = 1;
            this.tableLayoutPanel_Welcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Welcome.Controls.Add(this.button_chooseFile, 0, 1);
            this.tableLayoutPanel_Welcome.Controls.Add(this.button_chooseText, 0, 0);
            this.tableLayoutPanel_Welcome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel_Welcome.Location = new System.Drawing.Point(387, 178);
            this.tableLayoutPanel_Welcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel_Welcome.Name = "tableLayoutPanel_Welcome";
            this.tableLayoutPanel_Welcome.RowCount = 2;
            this.tableLayoutPanel_Welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Welcome.Size = new System.Drawing.Size(150, 166);
            this.tableLayoutPanel_Welcome.TabIndex = 0;
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_chooseFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_chooseFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_chooseFile.Location = new System.Drawing.Point(8, 91);
            this.button_chooseFile.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(134, 67);
            this.button_chooseFile.TabIndex = 1;
            this.button_chooseFile.Text = "转换文件";
            this.button_chooseFile.UseVisualStyleBackColor = false;
            this.button_chooseFile.Click += new System.EventHandler(this.button_chooseFile_Click);
            // 
            // button_chooseText
            // 
            this.button_chooseText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_chooseText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_chooseText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_chooseText.Location = new System.Drawing.Point(8, 8);
            this.button_chooseText.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_chooseText.Name = "button_chooseText";
            this.button_chooseText.Size = new System.Drawing.Size(134, 67);
            this.button_chooseText.TabIndex = 0;
            this.button_chooseText.Text = "转换文本";
            this.button_chooseText.UseVisualStyleBackColor = false;
            this.button_chooseText.Click += new System.EventHandler(this.button_chooseText_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 535);
            this.Controls.Add(this.tableLayoutPanel_Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WelcomeForm";
            this.Text = "PanguGo";
            this.tableLayoutPanel_Welcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Welcome;
        private System.Windows.Forms.Button button_chooseFile;
        private System.Windows.Forms.Button button_chooseText;
    }
}