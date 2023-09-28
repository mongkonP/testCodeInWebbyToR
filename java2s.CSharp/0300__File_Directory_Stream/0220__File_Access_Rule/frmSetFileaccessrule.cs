using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0220__File_Access_Rule
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/SetFileaccessrule.htm
    public partial  class frmSetFileaccessrule:Form
    {
        public frmSetFileaccessrule()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetFileaccessrule
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetFileaccessrule";
            this.Text = "frmSetFileaccessrule";
            this.Load += new System.EventHandler(this.frmSetFileaccessrule_Load);
            this.ResumeLayout(false);

        }

        private void frmSetFileaccessrule_Load(object sender, EventArgs e)
        {

        }
    }
}
