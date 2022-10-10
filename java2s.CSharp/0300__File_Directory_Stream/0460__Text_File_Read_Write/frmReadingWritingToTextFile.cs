using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0460__Text_File_Read_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ReadingWritingToTextFile.htm
    public partial  class frmReadingWritingToTextFile:Form
    {
        public frmReadingWritingToTextFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingWritingToTextFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingWritingToTextFile";
            this.Text = "frmReadingWritingToTextFile";
            this.Load += new System.EventHandler(this.frmReadingWritingToTextFile_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingWritingToTextFile_Load(object sender, EventArgs e)
        {

        }
    }
}
