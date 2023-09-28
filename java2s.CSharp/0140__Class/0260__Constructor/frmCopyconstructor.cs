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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Copyconstructor.htm
    public partial  class frmCopyconstructor:Form
    {
        public frmCopyconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyconstructor";
            this.Text = "frmCopyconstructor";
            this.Load += new System.EventHandler(this.frmCopyconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
