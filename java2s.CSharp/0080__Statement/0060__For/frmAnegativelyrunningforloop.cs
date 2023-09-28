using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0060__For
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Anegativelyrunningforloop.htm
    public partial  class frmAnegativelyrunningforloop:Form
    {
        public frmAnegativelyrunningforloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnegativelyrunningforloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnegativelyrunningforloop";
            this.Text = "frmAnegativelyrunningforloop";
            this.Load += new System.EventHandler(this.frmAnegativelyrunningforloop_Load);
            this.ResumeLayout(false);

        }

        private void frmAnegativelyrunningforloop_Load(object sender, EventArgs e)
        {

        }
    }
}
