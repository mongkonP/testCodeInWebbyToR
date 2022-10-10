using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0120__MVC_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/MVCPatterns.htm
    public partial  class frmMVCPatterns:Form
    {
        public frmMVCPatterns()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMVCPatterns
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMVCPatterns";
            this.Text = "frmMVCPatterns";
            this.Load += new System.EventHandler(this.frmMVCPatterns_Load);
            this.ResumeLayout(false);

        }

        private void frmMVCPatterns_Load(object sender, EventArgs e)
        {

        }
    }
}
