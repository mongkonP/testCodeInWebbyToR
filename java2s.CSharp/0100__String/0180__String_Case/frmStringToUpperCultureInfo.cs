using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0180__String_Case
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringToUpperCultureInfo.htm
    public partial  class frmStringToUpperCultureInfo:Form
    {
        public frmStringToUpperCultureInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringToUpperCultureInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringToUpperCultureInfo";
            this.Text = "frmStringToUpperCultureInfo";
            this.Load += new System.EventHandler(this.frmStringToUpperCultureInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmStringToUpperCultureInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
