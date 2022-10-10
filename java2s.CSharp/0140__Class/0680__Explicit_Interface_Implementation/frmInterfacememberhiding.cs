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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Interfacememberhiding.htm
    public partial  class frmInterfacememberhiding:Form
    {
        public frmInterfacememberhiding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfacememberhiding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfacememberhiding";
            this.Text = "frmInterfacememberhiding";
            this.Load += new System.EventHandler(this.frmInterfacememberhiding_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfacememberhiding_Load(object sender, EventArgs e)
        {

        }
    }
}
