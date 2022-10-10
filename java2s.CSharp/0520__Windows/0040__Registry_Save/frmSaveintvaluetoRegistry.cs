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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/SaveintvaluetoRegistry.htm
    public partial  class frmSaveintvaluetoRegistry:Form
    {
        public frmSaveintvaluetoRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveintvaluetoRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveintvaluetoRegistry";
            this.Text = "frmSaveintvaluetoRegistry";
            this.Load += new System.EventHandler(this.frmSaveintvaluetoRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveintvaluetoRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
