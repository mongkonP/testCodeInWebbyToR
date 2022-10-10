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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LinearGradientBrushandLinearGradientMode.htm
    public partial  class frmLinearGradientBrushandLinearGradientMode:Form
    {
        private System.ComponentModel.Container components = null;
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
        public frmLinearGradientBrushandLinearGradientMode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinearGradientBrushandLinearGradientMode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinearGradientBrushandLinearGradientMode";
            this.Text = "frmLinearGradientBrushandLinearGradientMode";
            this.Load += new System.EventHandler(this.frmLinearGradientBrushandLinearGradientMode_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LinearGradientBrushMode_Paint);
            this.ResumeLayout(false);

        }
        private void LinearGradientBrushMode_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(10, 10, 100, 100);

            LinearGradientBrush theBrush = null;
            int yOffSet = 10;

            Array obj = Enum.GetValues(typeof(LinearGradientMode));

            for (int x = 0; x < obj.Length; x++)
            {
                LinearGradientMode temp = (LinearGradientMode)obj.GetValue(x);
                theBrush = new LinearGradientBrush(r, Color.GreenYellow, Color.Blue, temp);

                g.DrawString(temp.ToString(), new Font("Times New Roman", 10), new SolidBrush(Color.Black), 0, yOffSet);

                g.FillRectangle(theBrush, 150, yOffSet, 200, 50);
                yOffSet += 80;
            }
        }
        private void frmLinearGradientBrushandLinearGradientMode_Load(object sender, EventArgs e)
        {

        }
    }
}
