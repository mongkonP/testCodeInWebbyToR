using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0200__Command_Line
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Seeifargumentsarepresent.htm
    public partial  class frmSeeifargumentsarepresent:Form
    {
        public frmSeeifargumentsarepresent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSeeifargumentsarepresent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSeeifargumentsarepresent";
            this.Text = "frmSeeifargumentsarepresent";
            this.Load += new System.EventHandler(this.frmSeeifargumentsarepresent_Load);
            this.ResumeLayout(false);

        }

        private void frmSeeifargumentsarepresent_Load(object sender, EventArgs e)
        {

        }
    }
}
