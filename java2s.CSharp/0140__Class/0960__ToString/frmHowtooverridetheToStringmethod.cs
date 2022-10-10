using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0960__ToString
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/HowtooverridetheToStringmethod.htm
    public partial  class frmHowtooverridetheToStringmethod:Form
    {
        public frmHowtooverridetheToStringmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHowtooverridetheToStringmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHowtooverridetheToStringmethod";
            this.Text = "frmHowtooverridetheToStringmethod";
            this.Load += new System.EventHandler(this.frmHowtooverridetheToStringmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmHowtooverridetheToStringmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
