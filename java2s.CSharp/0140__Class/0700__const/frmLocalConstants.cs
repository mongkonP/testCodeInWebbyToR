using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0700__const
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/LocalConstants.htm
    public partial  class frmLocalConstants:Form
    {
        public frmLocalConstants()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLocalConstants
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLocalConstants";
            this.Text = "frmLocalConstants";
            this.Load += new System.EventHandler(this.frmLocalConstants_Load);
            this.ResumeLayout(false);

        }

        private void frmLocalConstants_Load(object sender, EventArgs e)
        {

        }
    }
}
