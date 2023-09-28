using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0420__StreamWriter
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateStringWriterfromStringBuilder.htm
    public partial  class frmCreateStringWriterfromStringBuilder:Form
    {
        public frmCreateStringWriterfromStringBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateStringWriterfromStringBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateStringWriterfromStringBuilder";
            this.Text = "frmCreateStringWriterfromStringBuilder";
            this.Load += new System.EventHandler(this.frmCreateStringWriterfromStringBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateStringWriterfromStringBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
