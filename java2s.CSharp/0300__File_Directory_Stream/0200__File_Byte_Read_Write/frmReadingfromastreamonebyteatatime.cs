using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0200__File_Byte_Read_Write
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Readingfromastreamonebyteatatime.htm
    public partial  class frmReadingfromastreamonebyteatatime:Form
    {
        public frmReadingfromastreamonebyteatatime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingfromastreamonebyteatatime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingfromastreamonebyteatatime";
            this.Text = "frmReadingfromastreamonebyteatatime";
            this.Load += new System.EventHandler(this.frmReadingfromastreamonebyteatatime_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingfromastreamonebyteatatime_Load(object sender, EventArgs e)
        {

        }
    }
}
