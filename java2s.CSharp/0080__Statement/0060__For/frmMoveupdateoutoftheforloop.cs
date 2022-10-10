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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Moveupdateoutoftheforloop.htm
    public partial  class frmMoveupdateoutoftheforloop:Form
    {
        public frmMoveupdateoutoftheforloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMoveupdateoutoftheforloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMoveupdateoutoftheforloop";
            this.Text = "frmMoveupdateoutoftheforloop";
            this.Load += new System.EventHandler(this.frmMoveupdateoutoftheforloop_Load);
            this.ResumeLayout(false);

        }

        private void frmMoveupdateoutoftheforloop_Load(object sender, EventArgs e)
        {

        }
    }
}
