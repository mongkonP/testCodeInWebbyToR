using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0780__Virtual_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/VirtualProperties.htm
    public partial  class frmVirtualProperties:Form
    {
        public frmVirtualProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualProperties";
            this.Text = "frmVirtualProperties";
            this.Load += new System.EventHandler(this.frmVirtualProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
