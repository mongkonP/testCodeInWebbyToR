using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0640__Random_File_Name
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/GetRandomFileName.htm
    public partial  class frmGetRandomFileName:Form
    {
        public frmGetRandomFileName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetRandomFileName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetRandomFileName";
            this.Text = "frmGetRandomFileName";
            this.Load += new System.EventHandler(this.frmGetRandomFileName_Load);
            this.ResumeLayout(false);

        }

        private void frmGetRandomFileName_Load(object sender, EventArgs e)
        {

        }
    }
}
