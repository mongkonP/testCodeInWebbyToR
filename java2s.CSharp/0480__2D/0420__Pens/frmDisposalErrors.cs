using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0420__Pens
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DisposalErrors.htm
    public partial  class frmDisposalErrors:Form
    {
        public frmDisposalErrors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisposalErrors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);

            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Name = "frmDisposalErrors";
            this.Text = "frmDisposalErrors";
            this.Load += new System.EventHandler(this.frmDisposalErrors_Load);
            this.ResumeLayout(false);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = Pens.Black;

            p.Dispose();
        }
        private void frmDisposalErrors_Load(object sender, EventArgs e)
        {

        }
    }
}
