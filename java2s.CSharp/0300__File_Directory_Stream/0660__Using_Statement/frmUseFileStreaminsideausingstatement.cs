using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0660__Using_Statement
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseFileStreaminsideausingstatement.htm
    public partial  class frmUseFileStreaminsideausingstatement:Form
    {
        public frmUseFileStreaminsideausingstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFileStreaminsideausingstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFileStreaminsideausingstatement";
            this.Text = "frmUseFileStreaminsideausingstatement";
            this.Load += new System.EventHandler(this.frmUseFileStreaminsideausingstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFileStreaminsideausingstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
