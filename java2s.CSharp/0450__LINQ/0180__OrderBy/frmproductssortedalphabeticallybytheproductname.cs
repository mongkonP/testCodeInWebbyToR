using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/productssortedalphabeticallybytheproductname.htm
    public partial  class frmproductssortedalphabeticallybytheproductname:Form
    {
        public frmproductssortedalphabeticallybytheproductname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmproductssortedalphabeticallybytheproductname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmproductssortedalphabeticallybytheproductname";
            this.Text = "frmproductssortedalphabeticallybytheproductname";
            this.Load += new System.EventHandler(this.frmproductssortedalphabeticallybytheproductname_Load);
            this.ResumeLayout(false);

        }

        private void frmproductssortedalphabeticallybytheproductname_Load(object sender, EventArgs e)
        {

        }
    }
}
