using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2snamespace
{
    //url
    public partial  class frmClass:Form
    {
        public frmClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClass";
            this.Text = "frmClass";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.ResumeLayout(false);

        }

        private void frmClass_Load(object sender, EventArgs e)
        {

        }
    }
}
