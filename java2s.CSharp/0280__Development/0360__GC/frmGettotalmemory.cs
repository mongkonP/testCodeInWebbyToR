using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0360__GC
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Gettotalmemory.htm
    public partial  class frmGettotalmemory:Form
    {
        public frmGettotalmemory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettotalmemory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettotalmemory";
            this.Text = "frmGettotalmemory";
            this.Load += new System.EventHandler(this.frmGettotalmemory_Load);
            this.ResumeLayout(false);

        }

        private void frmGettotalmemory_Load(object sender, EventArgs e)
        {

        }
    }
}
