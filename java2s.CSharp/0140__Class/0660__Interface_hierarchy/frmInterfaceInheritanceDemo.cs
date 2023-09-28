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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InterfaceInheritanceDemo.htm
    public partial  class frmInterfaceInheritanceDemo:Form
    {
        public frmInterfaceInheritanceDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterfaceInheritanceDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterfaceInheritanceDemo";
            this.Text = "frmInterfaceInheritanceDemo";
            this.Load += new System.EventHandler(this.frmInterfaceInheritanceDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmInterfaceInheritanceDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
