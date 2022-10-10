using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0500__HatchBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/HatchBrushStyle.htm
    public partial  class frmHatchBrushStyle:Form
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

        public frmHatchBrushStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHatchBrushStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHatchBrushStyle";
            this.Text = "frmHatchBrushStyle";
            this.Load += new System.EventHandler(this.frmHatchBrushStyle_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

            this.ResumeLayout(false);

        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int yOffSet = 10;

            Array obj = Enum.GetValues(typeof(HatchStyle));

            for (int x = 0; x < 10; x++)
            {
                HatchStyle temp = (HatchStyle)obj.GetValue(x);
                HatchBrush theBrush = new HatchBrush(temp, Color.White, Color.Black);

                g.DrawString(temp.ToString(), new Font("Times New Roman", 10), new SolidBrush(Color.Black), 0, yOffSet);

                g.FillEllipse(theBrush, 150, yOffSet, 200, 25);
                yOffSet += 40;
            }
        }
        private void frmHatchBrushStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
