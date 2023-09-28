using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0260__FileInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/FileSorter.htm
    public partial  class frmFileSorter:Form
    {
        public frmFileSorter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileSorter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileSorter";
            this.Text = "frmFileSorter";
            this.Load += new System.EventHandler(this.frmFileSorter_Load);
            this.ResumeLayout(false);

        }

        private void frmFileSorter_Load(object sender, EventArgs e)
        {

        }
    }
}
