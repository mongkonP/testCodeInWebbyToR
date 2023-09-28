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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfacesInheritingInterfaces.htm
    public partial  class frmInterfacesInheritingInterfaces:Form
    {
        public frmInterfacesInheritingInterfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfacesInheritingInterfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfacesInheritingInterfaces";
            this.Text = "frmInterfacesInheritingInterfaces";
            this.Load += new System.EventHandler(this.frmInterfacesInheritingInterfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfacesInheritingInterfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
