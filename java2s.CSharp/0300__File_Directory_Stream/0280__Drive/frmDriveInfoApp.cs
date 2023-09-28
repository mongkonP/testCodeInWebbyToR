using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0280__Drive
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DriveInfoApp.htm
    public partial  class frmDriveInfoApp:Form
    {
        public frmDriveInfoApp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDriveInfoApp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDriveInfoApp";
            this.Text = "frmDriveInfoApp";
            this.Load += new System.EventHandler(this.frmDriveInfoApp_Load);
            this.ResumeLayout(false);

        }

        private void frmDriveInfoApp_Load(object sender, EventArgs e)
        {

        }
    }
}
