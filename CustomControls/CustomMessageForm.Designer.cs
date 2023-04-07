namespace CommonLib
{
    partial class CustomMessageForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.windowBar = new System.Windows.Forms.Panel();
            this.closingBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okCancelPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.itOK = new System.Windows.Forms.Button();
            this.itNotGood = new System.Windows.Forms.Button();
            this.yesOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Border.SuspendLayout();
            this.windowBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.okCancelPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.messageLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Border, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.messageLabel.AutoEllipsis = true;
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLabel.Location = new System.Drawing.Point(10, 94);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(10);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(104, 20);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "테스트 메세지";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.windowBar);
            this.Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Margin = new System.Windows.Forms.Padding(0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(414, 35);
            this.Border.TabIndex = 2;
            // 
            // windowBar
            // 
            this.windowBar.Controls.Add(this.closingBtn);
            this.windowBar.Controls.Add(this.titleLabel);
            this.windowBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowBar.Location = new System.Drawing.Point(0, 0);
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(414, 35);
            this.windowBar.TabIndex = 0;
            this.windowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseDown);
            this.windowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseMove);
            this.windowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseUp);
            // 
            // closingBtn
            // 
            this.closingBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closingBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.closingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closingBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingBtn.ForeColor = System.Drawing.Color.White;
            this.closingBtn.Location = new System.Drawing.Point(382, 3);
            this.closingBtn.Name = "closingBtn";
            this.closingBtn.Size = new System.Drawing.Size(29, 29);
            this.closingBtn.TabIndex = 0;
            this.closingBtn.Text = "Ⅹ";
            this.closingBtn.UseVisualStyleBackColor = true;
            this.closingBtn.Click += new System.EventHandler(this.closingBtn_Click);
            this.closingBtn.MouseLeave += new System.EventHandler(this.closingBtn_MouseLeave);
            this.closingBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closingBtn_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(5, 7);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(54, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "메세지";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.okCancelPanel);
            this.panel1.Controls.Add(this.yesOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 40);
            this.panel1.TabIndex = 3;
            // 
            // okCancelPanel
            // 
            this.okCancelPanel.Controls.Add(this.tableLayoutPanel2);
            this.okCancelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okCancelPanel.Location = new System.Drawing.Point(0, 0);
            this.okCancelPanel.Name = "okCancelPanel";
            this.okCancelPanel.Size = new System.Drawing.Size(414, 40);
            this.okCancelPanel.TabIndex = 1;
            this.okCancelPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.itOK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.itNotGood, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // itOK
            // 
            this.itOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.itOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.itOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itOK.Location = new System.Drawing.Point(105, 3);
            this.itOK.Name = "itOK";
            this.itOK.Size = new System.Drawing.Size(94, 34);
            this.itOK.TabIndex = 0;
            this.itOK.Text = "확인";
            this.itOK.UseVisualStyleBackColor = true;
            // 
            // itNotGood
            // 
            this.itNotGood.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.itNotGood.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.itNotGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itNotGood.Location = new System.Drawing.Point(215, 3);
            this.itNotGood.Name = "itNotGood";
            this.itNotGood.Size = new System.Drawing.Size(94, 34);
            this.itNotGood.TabIndex = 1;
            this.itNotGood.Text = "취소";
            this.itNotGood.UseVisualStyleBackColor = true;
            // 
            // yesOK
            // 
            this.yesOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yesOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.yesOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesOK.Location = new System.Drawing.Point(300, 3);
            this.yesOK.Name = "yesOK";
            this.yesOK.Size = new System.Drawing.Size(94, 34);
            this.yesOK.TabIndex = 0;
            this.yesOK.Text = "확인";
            this.yesOK.UseVisualStyleBackColor = true;
            this.yesOK.Click += new System.EventHandler(this.yesOK_Click);
            // 
            // CustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(416, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomMessageForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메세지";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Border.ResumeLayout(false);
            this.windowBar.ResumeLayout(false);
            this.windowBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.okCancelPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Button closingBtn;
        private System.Windows.Forms.Panel windowBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yesOK;
        private System.Windows.Forms.Panel okCancelPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button itOK;
        private System.Windows.Forms.Button itNotGood;
    }
}