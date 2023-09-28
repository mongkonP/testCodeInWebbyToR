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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/forloop.htm
    public partial  class frmforloop:Form
    {
        public frmforloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmforloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmforloop";
            this.Text = "frmforloop";
            this.Load += new System.EventHandler(this.frmforloop_Load);
            this.ResumeLayout(false);

        }

        private void frmforloop_Load(object sender, EventArgs e)
        {

        }
    }
}
