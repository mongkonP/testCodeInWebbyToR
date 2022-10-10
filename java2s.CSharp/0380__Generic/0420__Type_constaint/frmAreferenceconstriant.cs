using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0420__Type_constaint
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Areferenceconstriant.htm
    public partial  class frmAreferenceconstriant:Form
    {
        public frmAreferenceconstriant()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAreferenceconstriant
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAreferenceconstriant";
            this.Text = "frmAreferenceconstriant";
            this.Load += new System.EventHandler(this.frmAreferenceconstriant_Load);
            this.ResumeLayout(false);

        }

        private void frmAreferenceconstriant_Load(object sender, EventArgs e)
        {

        }
    }
}
