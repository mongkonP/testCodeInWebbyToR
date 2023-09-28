using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0660__Interface_hierarchy
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfacesBasedonInterfaces.htm
    public partial  class frmInterfacesBasedonInterfaces:Form
    {
        public frmInterfacesBasedonInterfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfacesBasedonInterfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfacesBasedonInterfaces";
            this.Text = "frmInterfacesBasedonInterfaces";
            this.Load += new System.EventHandler(this.frmInterfacesBasedonInterfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfacesBasedonInterfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
