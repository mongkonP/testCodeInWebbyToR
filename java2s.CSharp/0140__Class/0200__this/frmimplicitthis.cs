using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0200__this
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/implicitthis.htm
    public partial  class frmimplicitthis:Form
    {
        public frmimplicitthis()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmimplicitthis
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmimplicitthis";
            this.Text = "frmimplicitthis";
            this.Load += new System.EventHandler(this.frmimplicitthis_Load);
            this.ResumeLayout(false);

        }

        private void frmimplicitthis_Load(object sender, EventArgs e)
        {

        }
    }
}
