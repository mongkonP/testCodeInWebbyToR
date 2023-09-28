using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0340__Try_Catch
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Howtohandleaspecificexception.htm
    public partial  class frmHowtohandleaspecificexception:Form
    {
        public frmHowtohandleaspecificexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHowtohandleaspecificexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHowtohandleaspecificexception";
            this.Text = "frmHowtohandleaspecificexception";
            this.Load += new System.EventHandler(this.frmHowtohandleaspecificexception_Load);
            this.ResumeLayout(false);

        }

        private void frmHowtohandleaspecificexception_Load(object sender, EventArgs e)
        {

        }
    }
}
