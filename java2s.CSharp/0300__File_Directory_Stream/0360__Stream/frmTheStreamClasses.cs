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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/TheStreamClasses.htm
    public partial  class frmTheStreamClasses:Form
    {
        public frmTheStreamClasses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheStreamClasses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheStreamClasses";
            this.Text = "frmTheStreamClasses";
            this.Load += new System.EventHandler(this.frmTheStreamClasses_Load);
            this.ResumeLayout(false);

        }

        private void frmTheStreamClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
