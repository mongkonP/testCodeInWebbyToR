using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0180__struct_interface
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/InterfacesandStructs.htm
    public partial  class frmInterfacesandStructs:Form
    {
        public frmInterfacesandStructs()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfacesandStructs
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfacesandStructs";
            this.Text = "frmInterfacesandStructs";
            this.Load += new System.EventHandler(this.frmInterfacesandStructs_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfacesandStructs_Load(object sender, EventArgs e)
        {

        }
    }
}
