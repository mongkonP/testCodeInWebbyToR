using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passintwithoutoutandref.htm
    public partial  class frmPassintwithoutoutandref:Form
    {
        public frmPassintwithoutoutandref()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassintwithoutoutandref
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassintwithoutoutandref";
            this.Text = "frmPassintwithoutoutandref";
            this.Load += new System.EventHandler(this.frmPassintwithoutoutandref_Load);
            this.ResumeLayout(false);

        }

        private void frmPassintwithoutoutandref_Load(object sender, EventArgs e)
        {

        }
    }
}
