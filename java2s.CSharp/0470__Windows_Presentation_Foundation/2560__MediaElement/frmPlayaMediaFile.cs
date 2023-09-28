using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2560__MediaElement
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PlayaMediaFile.htm
    public partial  class frmPlayaMediaFile:Form
    {
        public frmPlayaMediaFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlayaMediaFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlayaMediaFile";
            this.Text = "frmPlayaMediaFile";
            this.Load += new System.EventHandler(this.frmPlayaMediaFile_Load);
            this.ResumeLayout(false);

        }

        private void frmPlayaMediaFile_Load(object sender, EventArgs e)
        {

        }
    }
}
