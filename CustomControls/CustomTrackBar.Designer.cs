
namespace CustomControls
{
    partial class CustomTrackBar
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backLine = new System.Windows.Forms.Panel();
            this.frontLine = new System.Windows.Forms.Panel();
            this.scrollBtn = new System.Windows.Forms.Panel();
            this.valueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // backLine
            // 
            this.backLine.BackColor = System.Drawing.Color.Silver;
            this.backLine.Controls.Add(this.frontLine);
            this.backLine.Location = new System.Drawing.Point(0, 12);
            this.backLine.Name = "backLine";
            this.backLine.Size = new System.Drawing.Size(400, 6);
            this.backLine.TabIndex = 0;
            this.backLine.SizeChanged += new System.EventHandler(this.backLine_SizeChanged);
            this.backLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backLine_MouseDown);
            this.backLine.MouseEnter += new System.EventHandler(this.backLine_MouseEnter);
            this.backLine.MouseLeave += new System.EventHandler(this.backLine_MouseLeave);
            // 
            // frontLine
            // 
            this.frontLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.frontLine.Location = new System.Drawing.Point(0, 0);
            this.frontLine.Name = "frontLine";
            this.frontLine.Size = new System.Drawing.Size(0, 6);
            this.frontLine.TabIndex = 0;
            this.frontLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frontLine_MouseDown);
            this.frontLine.MouseEnter += new System.EventHandler(this.frontLine_MouseEnter);
            this.frontLine.MouseLeave += new System.EventHandler(this.frontLine_MouseLeave);
            // 
            // scrollBtn
            // 
            this.scrollBtn.BackColor = System.Drawing.Color.DimGray;
            this.scrollBtn.Location = new System.Drawing.Point(0, 5);
            this.scrollBtn.Name = "scrollBtn";
            this.scrollBtn.Size = new System.Drawing.Size(15, 20);
            this.scrollBtn.TabIndex = 1;
            this.scrollBtn.LocationChanged += new System.EventHandler(this.scrollBtn_LocationChanged);
            this.scrollBtn.SizeChanged += new System.EventHandler(this.scrollBtn_SizeChanged);
            this.scrollBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scrollBtn_MouseDown);
            this.scrollBtn.MouseEnter += new System.EventHandler(this.scrollBtn_MouseEnter);
            this.scrollBtn.MouseLeave += new System.EventHandler(this.scrollBtn_MouseLeave);
            this.scrollBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scrollBtn_MouseMove);
            this.scrollBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scrollBtn_MouseUp);
            // 
            // valueToolTip
            // 
            this.valueToolTip.AutoPopDelay = 5000;
            this.valueToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(97)))), ((int)(((byte)(105)))));
            this.valueToolTip.ForeColor = System.Drawing.Color.White;
            this.valueToolTip.InitialDelay = 500;
            this.valueToolTip.OwnerDraw = true;
            this.valueToolTip.ReshowDelay = 100;
            this.valueToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.valueToolTip_Draw);
            // 
            // CustomTrackBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.scrollBtn);
            this.Controls.Add(this.backLine);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Noto Sans KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomTrackBar";
            this.Size = new System.Drawing.Size(400, 30);
            this.ForeColorChanged += new System.EventHandler(this.CustomTrackBar_ForeColorChanged);
            this.SizeChanged += new System.EventHandler(this.CustomTrackBar_SizeChanged);
            this.backLine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backLine;
        private System.Windows.Forms.Panel frontLine;
        private System.Windows.Forms.Panel scrollBtn;
        private System.Windows.Forms.ToolTip valueToolTip;
    }
}
