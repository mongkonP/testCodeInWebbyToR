using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0140__Variable_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Dynamicinitialization.htm
    public partial  class frmDynamicinitialization:Form
    {
        public frmDynamicinitialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicinitialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicinitialization";
            this.Text = "frmDynamicinitialization";
            this.Load += new System.EventHandler(this.frmDynamicinitialization_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicinitialization_Load(object sender, EventArgs e)
        {

        }
    }
}
