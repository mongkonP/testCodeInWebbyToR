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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/MaxonStringarray.htm
    public partial  class frmMaxonStringarray:Form
    {
        public frmMaxonStringarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMaxonStringarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMaxonStringarray";
            this.Text = "frmMaxonStringarray";
            this.Load += new System.EventHandler(this.frmMaxonStringarray_Load);
            this.ResumeLayout(false);

        }

        private void frmMaxonStringarray_Load(object sender, EventArgs e)
        {

        }
    }
}
