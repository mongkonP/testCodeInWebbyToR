using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0020__IntPtr
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/FixingManagedDatainMemory.htm
    public partial  class frmFixingManagedDatainMemory:Form
    {
        public frmFixingManagedDatainMemory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFixingManagedDatainMemory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFixingManagedDatainMemory";
            this.Text = "frmFixingManagedDatainMemory";
            this.Load += new System.EventHandler(this.frmFixingManagedDatainMemory_Load);
            this.ResumeLayout(false);

        }

        private void frmFixingManagedDatainMemory_Load(object sender, EventArgs e)
        {

        }
    }
}
