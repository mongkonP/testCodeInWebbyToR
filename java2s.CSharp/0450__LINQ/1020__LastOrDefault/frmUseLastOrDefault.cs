using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1020__LastOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseLastOrDefault.htm
    public partial  class frmUseLastOrDefault:Form
    {
        public frmUseLastOrDefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLastOrDefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLastOrDefault";
            this.Text = "frmUseLastOrDefault";
            this.Load += new System.EventHandler(this.frmUseLastOrDefault_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLastOrDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
