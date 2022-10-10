using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0020__var
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Usingvar.htm
    public partial  class frmUsingvar:Form
    {
        public frmUsingvar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingvar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingvar";
            this.Text = "frmUsingvar";
            this.Load += new System.EventHandler(this.frmUsingvar_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingvar_Load(object sender, EventArgs e)
        {

        }
    }
}
