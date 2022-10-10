using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MasterDetailBinding.htm
    public partial  class frmMasterDetailBinding:Form
    {
        public frmMasterDetailBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMasterDetailBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMasterDetailBinding";
            this.Text = "frmMasterDetailBinding";
            this.Load += new System.EventHandler(this.frmMasterDetailBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmMasterDetailBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
