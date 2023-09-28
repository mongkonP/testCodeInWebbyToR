using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/UsingloadlibraryfromDll.htm
    public partial  class frmUsingloadlibraryfromDll:Form
    {
        public frmUsingloadlibraryfromDll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingloadlibraryfromDll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingloadlibraryfromDll";
            this.Text = "frmUsingloadlibraryfromDll";
            this.Load += new System.EventHandler(this.frmUsingloadlibraryfromDll_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingloadlibraryfromDll_Load(object sender, EventArgs e)
        {

        }
    }
}
