using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0340__Directory_Size
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DisplayDirinformationrecursivly.htm
    public partial  class frmDisplayDirinformationrecursivly:Form
    {
        public frmDisplayDirinformationrecursivly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayDirinformationrecursivly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayDirinformationrecursivly";
            this.Text = "frmDisplayDirinformationrecursivly";
            this.Load += new System.EventHandler(this.frmDisplayDirinformationrecursivly_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayDirinformationrecursivly_Load(object sender, EventArgs e)
        {

        }
    }
}
