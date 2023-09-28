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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/CatchSystemNullReferenceException.htm
    public partial  class frmCatchSystemNullReferenceException:Form
    {
        public frmCatchSystemNullReferenceException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchSystemNullReferenceException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchSystemNullReferenceException";
            this.Text = "frmCatchSystemNullReferenceException";
            this.Load += new System.EventHandler(this.frmCatchSystemNullReferenceException_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchSystemNullReferenceException_Load(object sender, EventArgs e)
        {

        }
    }
}
