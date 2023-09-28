using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1060__Max
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Maxonobjectlist.htm
    public partial  class frmMaxonobjectlist:Form
    {
        public frmMaxonobjectlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMaxonobjectlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMaxonobjectlist";
            this.Text = "frmMaxonobjectlist";
            this.Load += new System.EventHandler(this.frmMaxonobjectlist_Load);
            this.ResumeLayout(false);

        }

        private void frmMaxonobjectlist_Load(object sender, EventArgs e)
        {

        }
    }
}
