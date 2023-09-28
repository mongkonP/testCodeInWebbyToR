using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0860__FirstOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UsingFirstOrDefault.htm
    public partial  class frmUsingFirstOrDefault:Form
    {
        public frmUsingFirstOrDefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingFirstOrDefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingFirstOrDefault";
            this.Text = "frmUsingFirstOrDefault";
            this.Load += new System.EventHandler(this.frmUsingFirstOrDefault_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingFirstOrDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
