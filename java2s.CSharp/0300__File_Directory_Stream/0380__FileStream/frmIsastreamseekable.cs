using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0380__FileStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Isastreamseekable.htm
    public partial  class frmIsastreamseekable:Form
    {
        public frmIsastreamseekable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsastreamseekable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsastreamseekable";
            this.Text = "frmIsastreamseekable";
            this.Load += new System.EventHandler(this.frmIsastreamseekable_Load);
            this.ResumeLayout(false);

        }

        private void frmIsastreamseekable_Load(object sender, EventArgs e)
        {

        }
    }
}
