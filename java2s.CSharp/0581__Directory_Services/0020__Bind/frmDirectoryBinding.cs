using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0020__Bind
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/DirectoryBinding.htm
    public partial  class frmDirectoryBinding:Form
    {
        public frmDirectoryBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDirectoryBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDirectoryBinding";
            this.Text = "frmDirectoryBinding";
            this.Load += new System.EventHandler(this.frmDirectoryBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmDirectoryBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
