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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ExplicitInterfaceImplementation.htm
    public partial  class frmExplicitInterfaceImplementation:Form
    {
        public frmExplicitInterfaceImplementation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExplicitInterfaceImplementation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExplicitInterfaceImplementation";
            this.Text = "frmExplicitInterfaceImplementation";
            this.Load += new System.EventHandler(this.frmExplicitInterfaceImplementation_Load);
            this.ResumeLayout(false);

        }

        private void frmExplicitInterfaceImplementation_Load(object sender, EventArgs e)
        {

        }
    }
}
