using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0420__Pens
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/PenAlignmentInset.htm
    public partial  class frmPenAlignmentInset:Form
    {
        public frmPenAlignmentInset()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenAlignmentInset
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenAlignmentInset";
            this.Text = "frmPenAlignmentInset";
            this.Load += new System.EventHandler(this.frmPenAlignmentInset_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            p.Alignment = PenAlignment.Inset;
            g.DrawRectangle(p, 3, 3, 8, 7);
            p.Dispose();
        }
        private void frmPenAlignmentInset_Load(object sender, EventArgs e)
        {

        }
    }
}
