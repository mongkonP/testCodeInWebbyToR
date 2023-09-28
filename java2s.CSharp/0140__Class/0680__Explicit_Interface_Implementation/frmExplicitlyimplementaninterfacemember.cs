using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0680__Explicit_Interface_Implementation
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Explicitlyimplementaninterfacemember.htm
    public partial  class frmExplicitlyimplementaninterfacemember:Form
    {
        public frmExplicitlyimplementaninterfacemember()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExplicitlyimplementaninterfacemember
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExplicitlyimplementaninterfacemember";
            this.Text = "frmExplicitlyimplementaninterfacemember";
            this.Load += new System.EventHandler(this.frmExplicitlyimplementaninterfacemember_Load);
            this.ResumeLayout(false);

        }

        private void frmExplicitlyimplementaninterfacemember_Load(object sender, EventArgs e)
        {

        }
    }
}
