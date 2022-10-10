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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Oneinterfacecaninheritanother.htm
    public partial  class frmOneinterfacecaninheritanother:Form
    {
        public frmOneinterfacecaninheritanother()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOneinterfacecaninheritanother
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOneinterfacecaninheritanother";
            this.Text = "frmOneinterfacecaninheritanother";
            this.Load += new System.EventHandler(this.frmOneinterfacecaninheritanother_Load);
            this.ResumeLayout(false);

        }

        private void frmOneinterfacecaninheritanother_Load(object sender, EventArgs e)
        {

        }
    }
}
