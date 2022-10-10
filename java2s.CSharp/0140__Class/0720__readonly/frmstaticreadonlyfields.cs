using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0720__readonly
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/staticreadonlyfields.htm
    public partial  class frmstaticreadonlyfields:Form
    {
        public frmstaticreadonlyfields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmstaticreadonlyfields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmstaticreadonlyfields";
            this.Text = "frmstaticreadonlyfields";
            this.Load += new System.EventHandler(this.frmstaticreadonlyfields_Load);
            this.ResumeLayout(false);

        }

        private void frmstaticreadonlyfields_Load(object sender, EventArgs e)
        {

        }
    }
}
