using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetVersionExbyusingkernel32dll.htm
    public partial  class frmGetVersionExbyusingkernel32dll:Form
    {
        public frmGetVersionExbyusingkernel32dll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetVersionExbyusingkernel32dll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetVersionExbyusingkernel32dll";
            this.Text = "frmGetVersionExbyusingkernel32dll";
            this.Load += new System.EventHandler(this.frmGetVersionExbyusingkernel32dll_Load);
            this.ResumeLayout(false);

        }

        private void frmGetVersionExbyusingkernel32dll_Load(object sender, EventArgs e)
        {

        }
    }
}
