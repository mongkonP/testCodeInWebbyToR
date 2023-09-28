using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Namespacespreventnameconflicts.htm
    public partial  class frmNamespacespreventnameconflicts:Form
    {
        public frmNamespacespreventnameconflicts()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNamespacespreventnameconflicts
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNamespacespreventnameconflicts";
            this.Text = "frmNamespacespreventnameconflicts";
            this.Load += new System.EventHandler(this.frmNamespacespreventnameconflicts_Load);
            this.ResumeLayout(false);

        }

        private void frmNamespacespreventnameconflicts_Load(object sender, EventArgs e)
        {

        }
    }
}
