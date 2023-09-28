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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Demonstratestackalloc.htm
    public partial  class frmDemonstratestackalloc:Form
    {
        public frmDemonstratestackalloc()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratestackalloc
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratestackalloc";
            this.Text = "frmDemonstratestackalloc";
            this.Load += new System.EventHandler(this.frmDemonstratestackalloc_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratestackalloc_Load(object sender, EventArgs e)
        {

        }
    }
}
