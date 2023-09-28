using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Getallprocessesrunningonthelocalcomputer.htm
    public partial  class frmGetallprocessesrunningonthelocalcomputer:Form
    {
        public frmGetallprocessesrunningonthelocalcomputer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetallprocessesrunningonthelocalcomputer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetallprocessesrunningonthelocalcomputer";
            this.Text = "frmGetallprocessesrunningonthelocalcomputer";
            this.Load += new System.EventHandler(this.frmGetallprocessesrunningonthelocalcomputer_Load);
            this.ResumeLayout(false);

        }

        private void frmGetallprocessesrunningonthelocalcomputer_Load(object sender, EventArgs e)
        {

        }
    }
}
