using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0900__static_method
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/StaticMemberFunctions.htm
    public partial  class frmStaticMemberFunctions:Form
    {
        public frmStaticMemberFunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticMemberFunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticMemberFunctions";
            this.Text = "frmStaticMemberFunctions";
            this.Load += new System.EventHandler(this.frmStaticMemberFunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticMemberFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
