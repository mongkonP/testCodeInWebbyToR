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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Displayimage.htm
    public partial  class frmDisplayimage:Form
    {
        public frmDisplayimage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayimage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayimage";
            this.Text = "frmDisplayimage";
            this.Load += new System.EventHandler(this.frmDisplayimage_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayimage_Load(object sender, EventArgs e)
        {

        }
    }
}
