using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0300__Directory
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Listfilesunderadirectory.htm
    public partial  class frmListfilesunderadirectory:Form
    {
        public frmListfilesunderadirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListfilesunderadirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListfilesunderadirectory";
            this.Text = "frmListfilesunderadirectory";
            this.Load += new System.EventHandler(this.frmListfilesunderadirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmListfilesunderadirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
