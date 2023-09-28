using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0720__FileSystemWatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileWatch.htm
    public partial  class frmFileWatch:Form
    {
        public frmFileWatch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileWatch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileWatch";
            this.Text = "frmFileWatch";
            this.Load += new System.EventHandler(this.frmFileWatch_Load);
            this.ResumeLayout(false);

        }

        private void frmFileWatch_Load(object sender, EventArgs e)
        {

        }
    }
}
