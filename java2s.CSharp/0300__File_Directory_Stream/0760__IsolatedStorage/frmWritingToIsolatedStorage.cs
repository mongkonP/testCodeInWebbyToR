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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/WritingToIsolatedStorage.htm
    public partial  class frmWritingToIsolatedStorage:Form
    {
        public frmWritingToIsolatedStorage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritingToIsolatedStorage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritingToIsolatedStorage";
            this.Text = "frmWritingToIsolatedStorage";
            this.Load += new System.EventHandler(this.frmWritingToIsolatedStorage_Load);
            this.ResumeLayout(false);

        }

        private void frmWritingToIsolatedStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
