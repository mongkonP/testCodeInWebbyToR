using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0480__LinearGradientBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/BrushExampleforfillingshapes.htm
    public partial  class frmBrushExampleforfillingshapes:Form
    {
        public frmBrushExampleforfillingshapes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBrushExampleforfillingshapes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBrushExampleforfillingshapes";
            this.Text = "frmBrushExampleforfillingshapes";
            this.Load += new System.EventHandler(this.frmBrushExampleforfillingshapes_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, ClientRectangle);

            g.FillRectangle(Brushes.Red, new Rectangle(10, 10, 50, 50));

            Brush linearGradientBrush = new LinearGradientBrush(
              new Rectangle(10, 60, 50, 50), Color.Blue, Color.White, 45);
            g.FillRectangle(linearGradientBrush, new Rectangle(10, 60, 50, 50));
            linearGradientBrush.Dispose();

            g.FillEllipse(Brushes.Aquamarine, new Rectangle(60, 20, 50, 30));

            g.FillPie(Brushes.Chartreuse, new Rectangle(60, 60, 50, 50), 90, 210);

            g.FillPolygon(Brushes.BlueViolet, new Point[] {
                                new Point(110, 10),
                                new Point(150, 10),
                                new Point(160, 40),
                                new Point(120, 20),
                                new Point(120, 60),
      });
        }
        private void frmBrushExampleforfillingshapes_Load(object sender, EventArgs e)
        {

        }
    }
}
