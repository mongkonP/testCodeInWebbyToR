using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0740__sealed
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/SealedClasses.htm
    public partial  class frmSealedClasses:Form
    {
        public frmSealedClasses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSealedClasses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSealedClasses";
            this.Text = "frmSealedClasses";
            this.Load += new System.EventHandler(this.frmSealedClasses_Load);
            this.ResumeLayout(false);

        }

        private void frmSealedClasses_Load(object sender, EventArgs e)
        {

        }
    }
}
