using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class CustomTrackBar : UserControl
    {
        public CustomTrackBar()
        {
            InitializeComponent();
            btnY = (Height - scrollBtn.Height) / 2;
            centerPoint = scrollBtn.Width / 2;
            realMaxVal = Width - scrollBtn.Width;
        }

        private bool isDown = false;
        private int preX;
        private int gap;
        private int btnX;
        private int btnY;
        private int centerPoint;
        private double realMaxVal;

        #region 속성 값
        private Color btnColor = Color.DimGray;
        [Description("버튼 기본 색입니다."), Category()]
        public Color ButtonColor
        {
            get { return btnColor; }
            set
            {
                btnColor = value;
                scrollBtn.BackColor = btnColor;
            }
        }

        private Color btnOverColor = Color.DarkGray;
        [Description("버튼 위로 마우스를 올려놓았을 때 색입니다."), Category()]
        public Color ButtonOverColor
        {
            get { return btnOverColor; }
            set
            {
                btnOverColor = value;
            }
        }

        private Color btnClickColor = Color.LightGray;
        [Description("버튼을 클릭 했을 때 변하는 색입니다."), Category()]
        public Color ButtonClickColor
        {
            get { return btnClickColor; }
            set
            {
                btnClickColor = value;
            }
        }

        private Color backLineColor = Color.Silver;
        [Description("배경 선 색을 설정합니다."), Category()]
        public Color BackLineColor
        {
            get { return backLineColor; }
            set
            {
                backLineColor = value;
                backLine.BackColor = backLineColor;
            }
        }

        private Color frontLineColor = Color.FromArgb(94, 97, 105);
        [Description("현재 값을 나타내는 선 색을 설정합니다."), Category()]
        public Color FrontLineColor
        {
            get { return frontLineColor; }
            set
            {
                frontLineColor = value;
                frontLine.BackColor = frontLineColor;
                valueToolTip.BackColor = frontLineColor;
            }
        }

        private int lineHeight = 6;
        [Description("선 굵기를 설정합니다."), Category()]
        public int LineHeight
        {
            get { return lineHeight; }
            set
            {
                lineHeight = value;
                backLine.Height = lineHeight;
            }
        }

        private int curVal = 0;
        [Description("트랙 바의 현재 값을 설정합니다."), Category()]
        public int Value
        {
            get { return curVal; }
            set
            {
                if (value > maxVal)
                    curVal = maxVal;
                else if (value < 0)
                    curVal = 0;
                else
                    curVal = value;
                scrollBtn.Location = new Point(CalculateBtnLoc(), btnY);
            }
        }

        private int maxVal = 100;
        [Description("트랙 바의 최대값을 설정합니다."), Category()]
        public int MaxVal
        {
            get { return maxVal; }
            set
            {
                maxVal = value;
            }
        }

        private Size btnSize = new Size(15, 20);
        [Description("스크롤 버튼 크기를 설정합니다."), Category()]
        public Size ButtonSize
        {
            get { return btnSize; }
            set
            {
                btnSize = value;
                scrollBtn.Size = btnSize;
            }
        }

        #endregion

        private void scrollBtn_MouseEnter(object sender, EventArgs e)
        {
            scrollBtn.BackColor = btnOverColor;
        }

        private void scrollBtn_MouseLeave(object sender, EventArgs e)
        {
            scrollBtn.BackColor = btnColor;
        }

        private void CustomTrackBar_SizeChanged(object sender, EventArgs e)
        {
            int lineY = (Height - backLine.Height) / 2;
            backLine.Location = new Point(0, lineY);
            backLine.Width = Width;
            btnY = (Height - scrollBtn.Height) / 2;
            scrollBtn.Location = new Point(scrollBtn.Location.X, btnY);
            realMaxVal = Width - scrollBtn.Width;
        }

        private void backLine_SizeChanged(object sender, EventArgs e)
        {
            frontLine.Height = backLine.Height;
            int lineY = (Height - backLine.Height) / 2;
            backLine.Location = new Point(0, lineY);
        }

        private void scrollBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
                MoveButton(e.X);
        }

        private void MoveButton(int mouseX)
        {
            if (preX < mouseX)
            {
                gap = mouseX - preX;
                btnX = scrollBtn.Location.X + gap;

                if (btnX > Width - scrollBtn.Width)
                    btnX = Width - scrollBtn.Width;

                scrollBtn.Location = new Point(btnX, btnY);

            }
            else if (preX > mouseX)
            {
                gap = preX - mouseX;
                btnX = scrollBtn.Location.X - gap;

                if (btnX < 0)
                    btnX = 0;

                scrollBtn.Location = new Point(btnX, btnY);
            }
        }

        private void scrollBtn_MouseDown(object sender, MouseEventArgs e)
        {
            scrollBtn.BackColor = btnClickColor;
            isDown = true;
            preX = e.X;
        }

        private void scrollBtn_MouseUp(object sender, MouseEventArgs e)
        {
            scrollBtn.BackColor = btnOverColor;
            isDown = false;
        }

        private void backLine_MouseEnter(object sender, EventArgs e)
        {
            backLine.BackColor = ControlPaint.Light(backLineColor);
        }

        private void backLine_MouseLeave(object sender, EventArgs e)
        {
            backLine.BackColor = backLineColor;
        }

        private void frontLine_MouseEnter(object sender, EventArgs e)
        {
            frontLine.BackColor = ControlPaint.Light(frontLineColor);
        }

        private void frontLine_MouseLeave(object sender, EventArgs e)
        {
            frontLine.BackColor = frontLineColor;
        }

        private void scrollBtn_LocationChanged(object sender, EventArgs e)
        {
            frontLine.Width = scrollBtn.Location.X;
            curVal = CalculateValue();
            valueToolTip.SetToolTip(scrollBtn, curVal.ToString());
        }

        private void backLine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > Width - centerPoint)
                scrollBtn.Location = new Point(Width - scrollBtn.Width, btnY);
            else
                scrollBtn.Location = new Point(e.X - (centerPoint), btnY);
        }

        private void frontLine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < centerPoint)
                scrollBtn.Location = new Point(0, btnY);
            else
                scrollBtn.Location = new Point(e.X - (centerPoint), btnY);
        }

        private int CalculateValue()
        {
            return (int)Math.Round(frontLine.Width * maxVal / realMaxVal);
        }

        private int CalculateBtnLoc()
        {
            return (int)Math.Round(curVal * realMaxVal / maxVal);
        }

        private void valueToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void CustomTrackBar_ForeColorChanged(object sender, EventArgs e)
        {
            valueToolTip.ForeColor = ForeColor;
        }

        private void scrollBtn_SizeChanged(object sender, EventArgs e)
        {
            btnY = (Height - scrollBtn.Height) / 2;
            scrollBtn.Location = new Point(scrollBtn.Location.X, btnY);
            centerPoint = scrollBtn.Width / 2;
        }
    }
}
