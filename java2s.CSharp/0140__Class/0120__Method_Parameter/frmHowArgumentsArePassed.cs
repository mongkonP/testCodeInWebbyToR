using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/HowArgumentsArePassed.htm
    public partial  class frmHowArgumentsArePassed:Form
    {
        public frmHowArgumentsArePassed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHowArgumentsArePassed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHowArgumentsArePassed";
            this.Text = "frmHowArgumentsArePassed";
            this.Load += new System.EventHandler(this.frmHowArgumentsArePassed_Load);
            this.ResumeLayout(false);

        }

        private void frmHowArgumentsArePassed_Load(object sender, EventArgs e)
        {

        }
    }
}
