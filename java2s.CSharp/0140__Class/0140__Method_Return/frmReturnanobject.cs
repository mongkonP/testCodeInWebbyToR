using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0140__Method_Return
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Returnanobject.htm
    public partial  class frmReturnanobject:Form
    {
        public frmReturnanobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnanobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnanobject";
            this.Text = "frmReturnanobject";
            this.Load += new System.EventHandler(this.frmReturnanobject_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnanobject_Load(object sender, EventArgs e)
        {

        }
    }
}
