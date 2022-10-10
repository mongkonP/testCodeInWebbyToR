using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0080__Main
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/MainEntryPoint.htm
    public partial  class frmMainEntryPoint:Form
    {
        public frmMainEntryPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMainEntryPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMainEntryPoint";
            this.Text = "frmMainEntryPoint";
            this.Load += new System.EventHandler(this.frmMainEntryPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmMainEntryPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
