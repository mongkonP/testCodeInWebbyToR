using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0120__Regex_Match
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/UsingMatchCollection.htm
    public partial  class frmUsingMatchCollection:Form
    {
        public frmUsingMatchCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingMatchCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingMatchCollection";
            this.Text = "frmUsingMatchCollection";
            this.Load += new System.EventHandler(this.frmUsingMatchCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingMatchCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
