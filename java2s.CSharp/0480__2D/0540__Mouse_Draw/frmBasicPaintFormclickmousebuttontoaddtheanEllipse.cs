using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0540__Mouse_Draw
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/BasicPaintFormclickmousebuttontoaddtheanEllipse.htm
    public partial  class frmBasicPaintFormclickmousebuttontoaddtheanEllipse:Form
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button btnRenderedButton;
        private System.Windows.Forms.Button btnRenderToOtherButton;
        private ArrayList myPts = new ArrayList();
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
        public frmBasicPaintFormclickmousebuttontoaddtheanEllipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.btnRenderedButton = new System.Windows.Forms.Button();
            this.btnRenderToOtherButton = new System.Windows.Forms.Button();
            // 
            // btnRenderedButton
            // 
            this.btnRenderedButton.Location = new System.Drawing.Point(168, 120);
            this.btnRenderedButton.Name = "btnRenderedButton";
            this.btnRenderedButton.Size = new System.Drawing.Size(112, 136);
            this.btnRenderedButton.TabIndex = 0;
            this.btnRenderedButton.Text = "Click on other button!";
            // 
            // btnRenderToOtherButton
            // 
            this.btnRenderToOtherButton.Location = new System.Drawing.Point(168, 8);
            this.btnRenderToOtherButton.Name = "btnRenderToOtherButton";
            this.btnRenderToOtherButton.Size = new System.Drawing.Size(112, 56);
            this.btnRenderToOtherButton.TabIndex = 1;
            this.btnRenderToOtherButton.Text = "Render to button";
            // 
            // FormBasicPaintMouseClick
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnRenderToOtherButton);
            this.Controls.Add(this.btnRenderedButton);
            this.Name = "FormBasicPaintMouseClick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Paint Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBasicPaintMouseClick_MouseDown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBasicPaintMouseClick_Paint);
            // 
            // frmBasicPaintFormclickmousebuttontoaddtheanEllipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBasicPaintFormclickmousebuttontoaddtheanEllipse";
            this.Text = "frmBasicPaintFormclickmousebuttontoaddtheanEllipse";
            this.Load += new System.EventHandler(this.frmBasicPaintFormclickmousebuttontoaddtheanEllipse_Load);
            this.ResumeLayout(false);

        }
        private void FormBasicPaintMouseClick_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            myPts.Add(new Point(e.X, e.Y));
            Invalidate();
        }

        private void FormBasicPaintMouseClick_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point p in myPts)
                g.DrawEllipse(new Pen(Color.Green), p.X, p.Y, 10, 10);
        }
        private void frmBasicPaintFormclickmousebuttontoaddtheanEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
