using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0320__typeof
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Usingtypeof.htm
    public partial  class frmUsingtypeof:Form
    {
        public frmUsingtypeof()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtypeof
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtypeof";
            this.Text = "frmUsingtypeof";
            this.Load += new System.EventHandler(this.frmUsingtypeof_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtypeof_Load(object sender, EventArgs e)
        {

        }
    }
}
