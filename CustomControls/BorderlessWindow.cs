using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib
{
    public partial class BorderlessWindow : Form
    {
        public BorderlessWindow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, Top);
            e.Graphics.FillRectangle(Brushes.Transparent, Left);
            e.Graphics.FillRectangle(Brushes.Transparent, Right);
            e.Graphics.FillRectangle(Brushes.Transparent, Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int dummy = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, dummy); } }
        Rectangle Left { get { return new Rectangle(0, 0, dummy, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - dummy, this.ClientSize.Width, dummy); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - dummy, 0, dummy, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, dummy, dummy); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - dummy, 0, dummy, dummy); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - dummy, dummy, dummy); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - dummy, this.ClientSize.Height - dummy, dummy, dummy); } }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) m.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) m.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) m.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) m.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) m.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) m.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) m.Result = (IntPtr)HTBOTTOM;
            }
        }
    }
}
