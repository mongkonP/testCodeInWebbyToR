using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0640__interface
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfacesandInheritance.htm
    public partial  class frmInterfacesandInheritance:Form
    {
        public frmInterfacesandInheritance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfacesandInheritance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfacesandInheritance";
            this.Text = "frmInterfacesandInheritance";
            this.Load += new System.EventHandler(this.frmInterfacesandInheritance_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfacesandInheritance_Load(object sender, EventArgs e)
        {

        }
    }
}
