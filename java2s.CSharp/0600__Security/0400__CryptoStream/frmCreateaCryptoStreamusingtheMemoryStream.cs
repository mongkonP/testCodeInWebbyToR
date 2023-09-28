using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0400__CryptoStream
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/CreateaCryptoStreamusingtheMemoryStream.htm
    public partial  class frmCreateaCryptoStreamusingtheMemoryStream:Form
    {
        public frmCreateaCryptoStreamusingtheMemoryStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaCryptoStreamusingtheMemoryStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaCryptoStreamusingtheMemoryStream";
            this.Text = "frmCreateaCryptoStreamusingtheMemoryStream";
            this.Load += new System.EventHandler(this.frmCreateaCryptoStreamusingtheMemoryStream_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaCryptoStreamusingtheMemoryStream_Load(object sender, EventArgs e)
        {

        }
    }
}
