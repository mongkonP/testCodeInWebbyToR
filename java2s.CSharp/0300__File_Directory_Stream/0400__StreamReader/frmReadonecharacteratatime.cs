using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0400__StreamReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Readonecharacteratatime.htm
    public partial  class frmReadonecharacteratatime:Form
    {
        public frmReadonecharacteratatime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadonecharacteratatime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadonecharacteratatime";
            this.Text = "frmReadonecharacteratatime";
            this.Load += new System.EventHandler(this.frmReadonecharacteratatime_Load);
            this.ResumeLayout(false);

        }

        private void frmReadonecharacteratatime_Load(object sender, EventArgs e)
        {

        }
    }
}
