using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0880__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Showmethodwithmessageandwindowtitle.htm
    public partial  class frmShowmethodwithmessageandwindowtitle:Form
    {
        public frmShowmethodwithmessageandwindowtitle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowmethodwithmessageandwindowtitle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowmethodwithmessageandwindowtitle";
            this.Text = "frmShowmethodwithmessageandwindowtitle";
            this.Load += new System.EventHandler(this.frmShowmethodwithmessageandwindowtitle_Load);
            this.ResumeLayout(false);

        }

        private void frmShowmethodwithmessageandwindowtitle_Load(object sender, EventArgs e)
        {

        }
    }
}
