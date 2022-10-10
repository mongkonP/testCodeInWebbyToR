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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/ExploringFilesAndSubdirectories.htm
    public partial  class frmExploringFilesAndSubdirectories:Form
    {
        public frmExploringFilesAndSubdirectories()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExploringFilesAndSubdirectories
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExploringFilesAndSubdirectories";
            this.Text = "frmExploringFilesAndSubdirectories";
            this.Load += new System.EventHandler(this.frmExploringFilesAndSubdirectories_Load);
            this.ResumeLayout(false);

        }

        private void frmExploringFilesAndSubdirectories_Load(object sender, EventArgs e)
        {

        }
    }
}
