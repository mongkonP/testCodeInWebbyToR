using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0540__Abstract_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/PolymorphismandVirtualFunctions.htm
    public partial  class frmPolymorphismandVirtualFunctions:Form
    {
        public frmPolymorphismandVirtualFunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolymorphismandVirtualFunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolymorphismandVirtualFunctions";
            this.Text = "frmPolymorphismandVirtualFunctions";
            this.Load += new System.EventHandler(this.frmPolymorphismandVirtualFunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmPolymorphismandVirtualFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
