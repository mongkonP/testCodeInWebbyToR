using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreateaTimerthatrunstwiceasecondstartinginonesecond.htm
    public partial  class frmCreateaTimerthatrunstwiceasecondstartinginonesecond:Form
    {
        public frmCreateaTimerthatrunstwiceasecondstartinginonesecond()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaTimerthatrunstwiceasecondstartinginonesecond
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaTimerthatrunstwiceasecondstartinginonesecond";
            this.Text = "frmCreateaTimerthatrunstwiceasecondstartinginonesecond";
            this.Load += new System.EventHandler(this.frmCreateaTimerthatrunstwiceasecondstartinginonesecond_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaTimerthatrunstwiceasecondstartinginonesecond_Load(object sender, EventArgs e)
        {

        }
    }
}
