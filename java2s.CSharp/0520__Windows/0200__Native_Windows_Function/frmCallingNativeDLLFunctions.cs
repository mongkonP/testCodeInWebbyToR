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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CallingNativeDLLFunctions.htm
    public partial  class frmCallingNativeDLLFunctions:Form
    {
        public frmCallingNativeDLLFunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallingNativeDLLFunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallingNativeDLLFunctions";
            this.Text = "frmCallingNativeDLLFunctions";
            this.Load += new System.EventHandler(this.frmCallingNativeDLLFunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmCallingNativeDLLFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
