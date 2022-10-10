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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateHatchBrushstyleandcolor.htm
    public partial  class frmCreateHatchBrushstyleandcolor:Form
    {
        public frmCreateHatchBrushstyleandcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateHatchBrushstyleandcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateHatchBrushstyleandcolor";
            this.Text = "frmCreateHatchBrushstyleandcolor";
            this.Load += new System.EventHandler(this.frmCreateHatchBrushstyleandcolor_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BrushHatcHorizontalBrick_Paint);
            this.ResumeLayout(false);

        }
        private void BrushHatcHorizontalBrick_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush brHatch = new HatchBrush(HatchStyle.HorizontalBrick, Color.Red, Color.Yellow);
            g.FillEllipse(brHatch, 200, 200, 150, 190);
        }
        private void frmCreateHatchBrushstyleandcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
