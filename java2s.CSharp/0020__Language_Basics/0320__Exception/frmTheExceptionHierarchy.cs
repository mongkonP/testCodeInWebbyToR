using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0320__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/TheExceptionHierarchy.htm
    public partial  class frmTheExceptionHierarchy:Form
    {
        public frmTheExceptionHierarchy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheExceptionHierarchy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheExceptionHierarchy";
            this.Text = "frmTheExceptionHierarchy";
            this.Load += new System.EventHandler(this.frmTheExceptionHierarchy_Load);
            this.ResumeLayout(false);

        }

        private void frmTheExceptionHierarchy_Load(object sender, EventArgs e)
        {

        }
    }
}
