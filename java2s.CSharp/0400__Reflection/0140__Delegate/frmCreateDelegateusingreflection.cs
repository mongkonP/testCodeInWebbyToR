using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0140__Delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/CreateDelegateusingreflection.htm
    public partial  class frmCreateDelegateusingreflection:Form
    {
        public frmCreateDelegateusingreflection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateDelegateusingreflection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateDelegateusingreflection";
            this.Text = "frmCreateDelegateusingreflection";
            this.Load += new System.EventHandler(this.frmCreateDelegateusingreflection_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateDelegateusingreflection_Load(object sender, EventArgs e)
        {

        }
    }
}
