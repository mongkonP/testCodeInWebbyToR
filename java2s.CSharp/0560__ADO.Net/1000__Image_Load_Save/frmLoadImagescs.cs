using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C1000__Image_Load_Save
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoadImagescs.htm
    public partial  class frmLoadImagescs:Form
    {
        public frmLoadImagescs()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadImagescs
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadImagescs";
            this.Text = "frmLoadImagescs";
            this.Load += new System.EventHandler(this.frmLoadImagescs_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadImagescs_Load(object sender, EventArgs e)
        {

        }
    }
}
