using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0780__EventArgs
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/EventArgsDemo.htm
    public partial  class frmEventArgsDemo:Form
    {
        public frmEventArgsDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventArgsDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventArgsDemo";
            this.Text = "frmEventArgsDemo";
            this.Load += new System.EventHandler(this.frmEventArgsDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmEventArgsDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
