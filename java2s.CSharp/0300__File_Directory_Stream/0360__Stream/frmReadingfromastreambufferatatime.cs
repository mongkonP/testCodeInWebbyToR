using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0360__Stream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Readingfromastreambufferatatime.htm
    public partial  class frmReadingfromastreambufferatatime:Form
    {
        public frmReadingfromastreambufferatatime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingfromastreambufferatatime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingfromastreambufferatatime";
            this.Text = "frmReadingfromastreambufferatatime";
            this.Load += new System.EventHandler(this.frmReadingfromastreambufferatatime_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingfromastreambufferatatime_Load(object sender, EventArgs e)
        {

        }
    }
}
