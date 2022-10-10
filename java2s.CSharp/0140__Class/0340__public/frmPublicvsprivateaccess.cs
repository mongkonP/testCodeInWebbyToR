using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0340__public
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Publicvsprivateaccess.htm
    public partial  class frmPublicvsprivateaccess:Form
    {
        public frmPublicvsprivateaccess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPublicvsprivateaccess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPublicvsprivateaccess";
            this.Text = "frmPublicvsprivateaccess";
            this.Load += new System.EventHandler(this.frmPublicvsprivateaccess_Load);
            this.ResumeLayout(false);

        }

        private void frmPublicvsprivateaccess_Load(object sender, EventArgs e)
        {

        }
    }
}
