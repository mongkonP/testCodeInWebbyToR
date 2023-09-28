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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AllDirectoriestraversesallsubdirectoriesundertheroot.htm
    public partial  class frmAllDirectoriestraversesallsubdirectoriesundertheroot:Form
    {
        public frmAllDirectoriestraversesallsubdirectoriesundertheroot()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllDirectoriestraversesallsubdirectoriesundertheroot
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllDirectoriestraversesallsubdirectoriesundertheroot";
            this.Text = "frmAllDirectoriestraversesallsubdirectoriesundertheroot";
            this.Load += new System.EventHandler(this.frmAllDirectoriestraversesallsubdirectoriesundertheroot_Load);
            this.ResumeLayout(false);

        }

        private void frmAllDirectoriestraversesallsubdirectoriesundertheroot_Load(object sender, EventArgs e)
        {

        }
    }
}
