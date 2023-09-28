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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UploadData.htm
    public partial  class frmUploadData:Form
    {
        public frmUploadData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUploadData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUploadData";
            this.Text = "frmUploadData";
            this.Load += new System.EventHandler(this.frmUploadData_Load);
            this.ResumeLayout(false);

        }

        private void frmUploadData_Load(object sender, EventArgs e)
        {

        }
    }
}
