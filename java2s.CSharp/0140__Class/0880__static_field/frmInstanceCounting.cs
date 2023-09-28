using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/InstanceCounting.htm
    public partial  class frmInstanceCounting:Form
    {
        public frmInstanceCounting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInstanceCounting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInstanceCounting";
            this.Text = "frmInstanceCounting";
            this.Load += new System.EventHandler(this.frmInstanceCounting_Load);
            this.ResumeLayout(false);

        }

        private void frmInstanceCounting_Load(object sender, EventArgs e)
        {

        }
    }
}
