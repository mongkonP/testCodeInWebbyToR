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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Getallprocessesrunningontheremotecomputer.htm
    public partial  class frmGetallprocessesrunningontheremotecomputer:Form
    {
        public frmGetallprocessesrunningontheremotecomputer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetallprocessesrunningontheremotecomputer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetallprocessesrunningontheremotecomputer";
            this.Text = "frmGetallprocessesrunningontheremotecomputer";
            this.Load += new System.EventHandler(this.frmGetallprocessesrunningontheremotecomputer_Load);
            this.ResumeLayout(false);

        }

        private void frmGetallprocessesrunningontheremotecomputer_Load(object sender, EventArgs e)
        {

        }
    }
}
