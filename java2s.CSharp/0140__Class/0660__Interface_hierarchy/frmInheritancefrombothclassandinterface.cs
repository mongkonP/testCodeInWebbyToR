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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Inheritancefrombothclassandinterface.htm
    public partial  class frmInheritancefrombothclassandinterface:Form
    {
        public frmInheritancefrombothclassandinterface()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritancefrombothclassandinterface
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritancefrombothclassandinterface";
            this.Text = "frmInheritancefrombothclassandinterface";
            this.Load += new System.EventHandler(this.frmInheritancefrombothclassandinterface_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritancefrombothclassandinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
