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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Getrelativepath.htm
    public partial  class frmGetrelativepath:Form
    {
        public frmGetrelativepath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetrelativepath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetrelativepath";
            this.Text = "frmGetrelativepath";
            this.Load += new System.EventHandler(this.frmGetrelativepath_Load);
            this.ResumeLayout(false);

        }

        private void frmGetrelativepath_Load(object sender, EventArgs e)
        {

        }
    }
}
