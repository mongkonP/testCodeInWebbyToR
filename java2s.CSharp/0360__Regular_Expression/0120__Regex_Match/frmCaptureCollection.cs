using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0120__Regex_Match
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/CaptureCollection.htm
    public partial  class frmCaptureCollection:Form
    {
        public frmCaptureCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCaptureCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCaptureCollection";
            this.Text = "frmCaptureCollection";
            this.Load += new System.EventHandler(this.frmCaptureCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmCaptureCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
