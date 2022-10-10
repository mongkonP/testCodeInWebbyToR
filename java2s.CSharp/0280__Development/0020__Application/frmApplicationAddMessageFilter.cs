using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0020__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ApplicationAddMessageFilter.htm
    public partial  class frmApplicationAddMessageFilter:Form
    {
        public frmApplicationAddMessageFilter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationAddMessageFilter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationAddMessageFilter";
            this.Text = "frmApplicationAddMessageFilter";
            this.Load += new System.EventHandler(this.frmApplicationAddMessageFilter_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationAddMessageFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
