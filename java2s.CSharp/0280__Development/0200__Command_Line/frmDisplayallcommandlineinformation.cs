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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Displayallcommandlineinformation.htm
    public partial  class frmDisplayallcommandlineinformation:Form
    {
        public frmDisplayallcommandlineinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayallcommandlineinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayallcommandlineinformation";
            this.Text = "frmDisplayallcommandlineinformation";
            this.Load += new System.EventHandler(this.frmDisplayallcommandlineinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayallcommandlineinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
