using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Classwithoutdefaultconstructor.htm
    public partial  class frmClasswithoutdefaultconstructor:Form
    {
        public frmClasswithoutdefaultconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClasswithoutdefaultconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClasswithoutdefaultconstructor";
            this.Text = "frmClasswithoutdefaultconstructor";
            this.Load += new System.EventHandler(this.frmClasswithoutdefaultconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmClasswithoutdefaultconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
