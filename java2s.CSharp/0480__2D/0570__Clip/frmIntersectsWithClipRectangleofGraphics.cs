using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0570__Clip
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/IntersectsWithClipRectangleofGraphics.htm
    public partial  class frmIntersectsWithClipRectangleofGraphics:Form
    {
        public frmIntersectsWithClipRectangleofGraphics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntersectsWithClipRectangleofGraphics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntersectsWithClipRectangleofGraphics";
            this.Text = "frmIntersectsWithClipRectangleofGraphics";
            this.Load += new System.EventHandler(this.frmIntersectsWithClipRectangleofGraphics_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            SizeF sizeF = g.MeasureString("Test", this.Font);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;

            int cellHeight = (int)sizeF.Height + 4;
            int cellWidth = 80;
            int nbrColumns = 50;
            int nbrRows = 50;

            for (int row = 0; row < nbrRows; ++row)
            {
                for (int col = 0; col < nbrColumns; ++col)
                {
                    Point cellLocation = new Point(col * cellWidth, row * cellHeight);
                    Rectangle cellRect = new Rectangle(cellLocation.X, cellLocation.Y, cellWidth, cellHeight);
                    if (cellRect.IntersectsWith(e.ClipRectangle))
                    {
                        Console.WriteLine("Row:{0} Col:{1}", row, col);
                        g.FillRectangle(Brushes.LightGray, cellRect);
                        g.DrawRectangle(Pens.Black, cellRect);
                        String s = String.Format("{0},{1}", col, row);
                        g.DrawString(s, this.Font, Brushes.Black, cellRect, sf);
                    }
                }
            }
        }
        private void frmIntersectsWithClipRectangleofGraphics_Load(object sender, EventArgs e)
        {

        }
    }
}
