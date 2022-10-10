using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0040__Registry_Save
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/SetStringvaluetotheRegistry.htm
    public partial  class frmSetStringvaluetotheRegistry:Form
    {
        public frmSetStringvaluetotheRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetStringvaluetotheRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetStringvaluetotheRegistry";
            this.Text = "frmSetStringvaluetotheRegistry";
            this.Load += new System.EventHandler(this.frmSetStringvaluetotheRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmSetStringvaluetotheRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
