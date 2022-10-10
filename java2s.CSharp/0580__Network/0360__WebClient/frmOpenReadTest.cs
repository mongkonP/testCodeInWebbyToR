using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0360__WebClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/OpenReadTest.htm
    public partial  class frmOpenReadTest:Form
    {
        public frmOpenReadTest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenReadTest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenReadTest";
            this.Text = "frmOpenReadTest";
            this.Load += new System.EventHandler(this.frmOpenReadTest_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenReadTest_Load(object sender, EventArgs e)
        {

        }
    }
}
