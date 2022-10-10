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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Sealedmethods.htm
    public partial  class frmSealedmethods:Form
    {
        public frmSealedmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSealedmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSealedmethods";
            this.Text = "frmSealedmethods";
            this.Load += new System.EventHandler(this.frmSealedmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmSealedmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
