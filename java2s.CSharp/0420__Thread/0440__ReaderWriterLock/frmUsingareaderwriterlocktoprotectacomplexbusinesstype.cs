using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0440__ReaderWriterLock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usingareaderwriterlocktoprotectacomplexbusinesstype.htm
    public partial  class frmUsingareaderwriterlocktoprotectacomplexbusinesstype:Form
    {
        public frmUsingareaderwriterlocktoprotectacomplexbusinesstype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingareaderwriterlocktoprotectacomplexbusinesstype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingareaderwriterlocktoprotectacomplexbusinesstype";
            this.Text = "frmUsingareaderwriterlocktoprotectacomplexbusinesstype";
            this.Load += new System.EventHandler(this.frmUsingareaderwriterlocktoprotectacomplexbusinesstype_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingareaderwriterlocktoprotectacomplexbusinesstype_Load(object sender, EventArgs e)
        {

        }
    }
}
