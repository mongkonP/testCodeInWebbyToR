using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0460__virtual
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/VirtualAccessor.htm
    public partial  class frmVirtualAccessor:Form
    {
        public frmVirtualAccessor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualAccessor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualAccessor";
            this.Text = "frmVirtualAccessor";
            this.Load += new System.EventHandler(this.frmVirtualAccessor_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualAccessor_Load(object sender, EventArgs e)
        {

        }
    }
}
