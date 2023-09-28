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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/OpenWriteTest.htm
    public partial  class frmOpenWriteTest:Form
    {
        public frmOpenWriteTest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenWriteTest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenWriteTest";
            this.Text = "frmOpenWriteTest";
            this.Load += new System.EventHandler(this.frmOpenWriteTest_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenWriteTest_Load(object sender, EventArgs e)
        {

        }
    }
}
