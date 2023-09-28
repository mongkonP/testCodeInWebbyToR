using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0140__Ellipse
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawEllipseTrafficLights.htm
    public partial  class frmDrawEllipseTrafficLights:Form
    {
        private string strColor;
        public frmDrawEllipseTrafficLights()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawEllipseTrafficLights
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawEllipseTrafficLights";
            this.Text = "frmDrawEllipseTrafficLights";
            this.Load += new System.EventHandler(this.frmDrawEllipseTrafficLights_Load);
            this.Click += new EventHandler(Form1_Click);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawEllipseTrafficLights_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            switch (strColor)
            {
                case "red":
                    strColor = "yellow";
                    break;
                case "yellow":
                    strColor = "green";
                    break;
                default:
                    strColor = "red";
                    break;
            }
            this.Invalidate(new Rectangle(10, 10, 50, 150));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);

            g.FillRectangle(Brushes.Black, 10, 10, 50, 150);
            g.DrawEllipse(Pens.White, 15, 15, 40, 40);
            g.DrawEllipse(Pens.White, 15, 60, 40, 40);
            g.DrawEllipse(Pens.White, 15, 105, 40, 40);

            switch (strColor)
            {
                case "red":
                    g.FillEllipse(Brushes.Red, 15, 15, 40, 40);
                    break;
                case "yellow":
                    g.FillEllipse(Brushes.Yellow, 15, 60, 40, 40);
                    break;
                case "green":
                    g.FillEllipse(Brushes.Green, 15, 105, 40, 40);
                    break;
                default:
                    g.FillEllipse(Brushes.Red, 15, 15, 40, 40);
                    break;
            }
        }
    }
}
