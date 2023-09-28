using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0220__Anonymous
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AnonymousType.htm
    public partial  class frmAnonymousType:Form
    {
        public frmAnonymousType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousType";
            this.Text = "frmAnonymousType";
            this.Load += new System.EventHandler(this.frmAnonymousType_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousType_Load(object sender, EventArgs e)
        {

        }
    }
}
