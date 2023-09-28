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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/AnonymousTypes.htm
    public partial  class frmAnonymousTypes:Form
    {
        public frmAnonymousTypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousTypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousTypes";
            this.Text = "frmAnonymousTypes";
            this.Load += new System.EventHandler(this.frmAnonymousTypes_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
