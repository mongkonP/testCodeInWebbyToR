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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CalculateDirectorySize.htm
    public partial  class frmCalculateDirectorySize:Form
    {
        public frmCalculateDirectorySize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalculateDirectorySize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCalculateDirectorySize";
            this.Text = "frmCalculateDirectorySize";
            this.Load += new System.EventHandler(this.frmCalculateDirectorySize_Load);
            this.ResumeLayout(false);

        }

        private void frmCalculateDirectorySize_Load(object sender, EventArgs e)
        {

        }
    }
}
