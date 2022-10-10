using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0300__Directory
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Getthefilesfromtherootdirectory.htm
    public partial  class frmGetthefilesfromtherootdirectory:Form
    {
        public frmGetthefilesfromtherootdirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthefilesfromtherootdirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthefilesfromtherootdirectory";
            this.Text = "frmGetthefilesfromtherootdirectory";
            this.Load += new System.EventHandler(this.frmGetthefilesfromtherootdirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthefilesfromtherootdirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
