using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0400__Guid
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/GetGUID.htm
    public partial  class frmGetGUID:Form
    {
        public frmGetGUID()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetGUID
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetGUID";
            this.Text = "frmGetGUID";
            this.Load += new System.EventHandler(this.frmGetGUID_Load);
            this.ResumeLayout(false);

        }

        private void frmGetGUID_Load(object sender, EventArgs e)
        {

        }
    }
}
