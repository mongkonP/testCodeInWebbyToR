using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0260__Memory
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/AllocatememorywithSystemRuntimeMemoryFailPoint.htm
    public partial  class frmAllocatememorywithSystemRuntimeMemoryFailPoint:Form
    {
        public frmAllocatememorywithSystemRuntimeMemoryFailPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllocatememorywithSystemRuntimeMemoryFailPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllocatememorywithSystemRuntimeMemoryFailPoint";
            this.Text = "frmAllocatememorywithSystemRuntimeMemoryFailPoint";
            this.Load += new System.EventHandler(this.frmAllocatememorywithSystemRuntimeMemoryFailPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmAllocatememorywithSystemRuntimeMemoryFailPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
