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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Createdirectorystructure.htm
    public partial  class frmCreatedirectorystructure:Form
    {
        public frmCreatedirectorystructure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatedirectorystructure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatedirectorystructure";
            this.Text = "frmCreatedirectorystructure";
            this.Load += new System.EventHandler(this.frmCreatedirectorystructure_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatedirectorystructure_Load(object sender, EventArgs e)
        {

        }
    }
}
