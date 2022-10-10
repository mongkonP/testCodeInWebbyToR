using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0960__ToString
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/overrideToStringmethodtwices.htm
    public partial  class frmoverrideToStringmethodtwices:Form
    {
        public frmoverrideToStringmethodtwices()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmoverrideToStringmethodtwices
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmoverrideToStringmethodtwices";
            this.Text = "frmoverrideToStringmethodtwices";
            this.Load += new System.EventHandler(this.frmoverrideToStringmethodtwices_Load);
            this.ResumeLayout(false);

        }

        private void frmoverrideToStringmethodtwices_Load(object sender, EventArgs e)
        {

        }
    }
}
