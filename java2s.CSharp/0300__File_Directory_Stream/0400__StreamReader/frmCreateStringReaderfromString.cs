using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0400__StreamReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreateStringReaderfromString.htm
    public partial  class frmCreateStringReaderfromString:Form
    {
        public frmCreateStringReaderfromString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateStringReaderfromString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateStringReaderfromString";
            this.Text = "frmCreateStringReaderfromString";
            this.Load += new System.EventHandler(this.frmCreateStringReaderfromString_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateStringReaderfromString_Load(object sender, EventArgs e)
        {

        }
    }
}
