using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0180__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawPathandgetmouseclick.htm
    public partial  class frmDrawPathandgetmouseclick:Form
    {
        private System.ComponentModel.Container components = null;

        GraphicsPath myPath = new GraphicsPath();

        private bool isImageClicked = false;
        private int imageClickedIndex;
        public frmDrawPathandgetmouseclick()
        {
            InitializeComponent();
            myPath.StartFigure();
            myPath.AddLine(new Point(150, 10), new Point(120, 150));
            myPath.AddArc(200, 200, 100, 100, 0, 90);
            Point point1 = new Point(250, 250);
            Point point2 = new Point(350, 275);
            Point point3 = new Point(350, 325);
            Point point4 = new Point(250, 350);
            Point[] points = { point1, point2, point3, point4 };
            myPath.AddCurve(points);
            myPath.CloseFigure();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawPathandgetmouseclick
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawPathandgetmouseclick";
            this.Text = "frmDrawPathandgetmouseclick";
            this.Load += new System.EventHandler(this.frmDrawPathandgetmouseclick_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(376, 361);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPathMouseClick_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPathMouseClick_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawPathandgetmouseclick_Load(object sender, EventArgs e)
        {

        }
        private void DrawPathMouseClick_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mousePt = new Point(e.X, e.Y);

            if (myPath.IsVisible(mousePt))
            {
                isImageClicked = true;
                imageClickedIndex = 3;
            }
            else
            {
                isImageClicked = false;
            }
            Invalidate();
        }

        private void DrawPathMouseClick_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillPath(Brushes.RoyalBlue, myPath);

            if (isImageClicked == true)
            {
                Pen outline = new Pen(Color.Purple, 5);

                switch (imageClickedIndex)
                {
                    case 3:
                        g.DrawPath(outline, myPath);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
