using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Createsanamespacewithasingleclass.htm
    public partial  class frmCreatesanamespacewithasingleclass:Form
    {
        public frmCreatesanamespacewithasingleclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatesanamespacewithasingleclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatesanamespacewithasingleclass";
            this.Text = "frmCreatesanamespacewithasingleclass";
            this.Load += new System.EventHandler(this.frmCreatesanamespacewithasingleclass_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatesanamespacewithasingleclass_Load(object sender, EventArgs e)
        {

        }
    }
}
