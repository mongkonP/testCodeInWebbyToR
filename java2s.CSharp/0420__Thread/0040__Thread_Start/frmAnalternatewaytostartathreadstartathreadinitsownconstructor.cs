using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0040__Thread_Start
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Analternatewaytostartathreadstartathreadinitsownconstructor.htm
    public partial  class frmAnalternatewaytostartathreadstartathreadinitsownconstructor:Form
    {
        public frmAnalternatewaytostartathreadstartathreadinitsownconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnalternatewaytostartathreadstartathreadinitsownconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnalternatewaytostartathreadstartathreadinitsownconstructor";
            this.Text = "frmAnalternatewaytostartathreadstartathreadinitsownconstructor";
            this.Load += new System.EventHandler(this.frmAnalternatewaytostartathreadstartathreadinitsownconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmAnalternatewaytostartathreadstartathreadinitsownconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
