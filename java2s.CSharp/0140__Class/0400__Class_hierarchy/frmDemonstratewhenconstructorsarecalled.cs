using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0400__Class_hierarchy
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Demonstratewhenconstructorsarecalled.htm
    public partial  class frmDemonstratewhenconstructorsarecalled:Form
    {
        public frmDemonstratewhenconstructorsarecalled()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratewhenconstructorsarecalled
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratewhenconstructorsarecalled";
            this.Text = "frmDemonstratewhenconstructorsarecalled";
            this.Load += new System.EventHandler(this.frmDemonstratewhenconstructorsarecalled_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratewhenconstructorsarecalled_Load(object sender, EventArgs e)
        {

        }
    }
}
