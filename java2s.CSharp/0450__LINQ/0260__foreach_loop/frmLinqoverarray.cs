using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0260__foreach_loop
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Linqoverarray.htm
    public partial  class frmLinqoverarray:Form
    {
        public frmLinqoverarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinqoverarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinqoverarray";
            this.Text = "frmLinqoverarray";
            this.Load += new System.EventHandler(this.frmLinqoverarray_Load);
            this.ResumeLayout(false);

        }

        private void frmLinqoverarray_Load(object sender, EventArgs e)
        {

        }
    }
}
