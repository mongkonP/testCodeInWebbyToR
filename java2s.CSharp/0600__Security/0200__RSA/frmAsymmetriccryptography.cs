using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0200__RSA
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Asymmetriccryptography.htm
    public partial  class frmAsymmetriccryptography:Form
    {
        public frmAsymmetriccryptography()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsymmetriccryptography
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsymmetriccryptography";
            this.Text = "frmAsymmetriccryptography";
            this.Load += new System.EventHandler(this.frmAsymmetriccryptography_Load);
            this.ResumeLayout(false);

        }

        private void frmAsymmetriccryptography_Load(object sender, EventArgs e)
        {

        }
    }
}
