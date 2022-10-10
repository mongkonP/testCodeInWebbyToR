using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0760__IsolatedStorage
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/WritetextoutToIsoStorage.htm
    public partial  class frmWritetextoutToIsoStorage:Form
    {
        public frmWritetextoutToIsoStorage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritetextoutToIsoStorage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritetextoutToIsoStorage";
            this.Text = "frmWritetextoutToIsoStorage";
            this.Load += new System.EventHandler(this.frmWritetextoutToIsoStorage_Load);
            this.ResumeLayout(false);

        }

        private void frmWritetextoutToIsoStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
