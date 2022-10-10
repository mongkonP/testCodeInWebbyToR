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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/SetDateTimevaluetotheRegistry.htm
    public partial  class frmSetDateTimevaluetotheRegistry:Form
    {
        public frmSetDateTimevaluetotheRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetDateTimevaluetotheRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetDateTimevaluetotheRegistry";
            this.Text = "frmSetDateTimevaluetotheRegistry";
            this.Load += new System.EventHandler(this.frmSetDateTimevaluetotheRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmSetDateTimevaluetotheRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
