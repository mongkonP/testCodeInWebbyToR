using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/QuerywithanException.htm
    public partial  class frmQuerywithanException:Form
    {
        public frmQuerywithanException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQuerywithanException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQuerywithanException";
            this.Text = "frmQuerywithanException";
            this.Load += new System.EventHandler(this.frmQuerywithanException_Load);
            this.ResumeLayout(false);

        }

        private void frmQuerywithanException_Load(object sender, EventArgs e)
        {

        }
    }
}
