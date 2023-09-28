using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Selectonlypetname.htm
    public partial  class frmSelectonlypetname:Form
    {
        public frmSelectonlypetname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectonlypetname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectonlypetname";
            this.Text = "frmSelectonlypetname";
            this.Load += new System.EventHandler(this.frmSelectonlypetname_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectonlypetname_Load(object sender, EventArgs e)
        {

        }
    }
}
