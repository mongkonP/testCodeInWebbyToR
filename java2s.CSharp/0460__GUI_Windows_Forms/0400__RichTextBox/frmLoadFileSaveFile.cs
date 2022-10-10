using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0400__RichTextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/LoadFileSaveFile.htm
    public partial  class frmLoadFileSaveFile:Form
    {
        public frmLoadFileSaveFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadFileSaveFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadFileSaveFile";
            this.Text = "frmLoadFileSaveFile";
            this.Load += new System.EventHandler(this.frmLoadFileSaveFile_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadFileSaveFile_Load(object sender, EventArgs e)
        {

        }
    }
}
