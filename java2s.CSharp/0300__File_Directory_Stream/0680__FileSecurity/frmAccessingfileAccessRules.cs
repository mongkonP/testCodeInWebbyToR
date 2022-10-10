using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0680__FileSecurity
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/AccessingfileAccessRules.htm
    public partial  class frmAccessingfileAccessRules:Form
    {
        public frmAccessingfileAccessRules()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingfileAccessRules
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingfileAccessRules";
            this.Text = "frmAccessingfileAccessRules";
            this.Load += new System.EventHandler(this.frmAccessingfileAccessRules_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingfileAccessRules_Load(object sender, EventArgs e)
        {

        }
    }
}
