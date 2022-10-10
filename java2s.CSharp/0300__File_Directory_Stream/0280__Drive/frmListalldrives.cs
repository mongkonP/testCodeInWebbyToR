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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Listalldrives.htm
    public partial  class frmListalldrives:Form
    {
        public frmListalldrives()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListalldrives
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListalldrives";
            this.Text = "frmListalldrives";
            this.Load += new System.EventHandler(this.frmListalldrives_Load);
            this.ResumeLayout(false);

        }

        private void frmListalldrives_Load(object sender, EventArgs e)
        {

        }
    }
}
