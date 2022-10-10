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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Getalllogicaldrives.htm
    public partial  class frmGetalllogicaldrives:Form
    {
        public frmGetalllogicaldrives()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetalllogicaldrives
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetalllogicaldrives";
            this.Text = "frmGetalllogicaldrives";
            this.Load += new System.EventHandler(this.frmGetalllogicaldrives_Load);
            this.ResumeLayout(false);

        }

        private void frmGetalllogicaldrives_Load(object sender, EventArgs e)
        {

        }
    }
}
