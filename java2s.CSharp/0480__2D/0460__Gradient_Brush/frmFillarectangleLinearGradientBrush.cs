using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0460__Gradient_Brush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/FillarectangleLinearGradientBrush.htm
    public partial  class frmFillarectangleLinearGradientBrush:Form
    {
        public frmFillarectangleLinearGradientBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillarectangleLinearGradientBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillarectangleLinearGradientBrush";
            this.Text = "frmFillarectangleLinearGradientBrush";
            this.Load += new System.EventHandler(this.frmFillarectangleLinearGradientBrush_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BrushLinearGradient_Paint);
            this.ResumeLayout(false);

        }
        private void BrushLinearGradient_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush brGradient = new LinearGradientBrush(new Rectangle(0, 0, 200, 200), Color.Black, Color.LightGray, 45, false);
            g.FillRectangle(brGradient, 10, 10, 200, 200);
        }
        private void frmFillarectangleLinearGradientBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
