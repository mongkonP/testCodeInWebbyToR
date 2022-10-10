using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1360__Polyline
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/XAMLButtonwithPolylineandLabel.htm
    public partial  class frmXAMLButtonwithPolylineandLabel:Form
    {
        public frmXAMLButtonwithPolylineandLabel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmXAMLButtonwithPolylineandLabel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmXAMLButtonwithPolylineandLabel";
            this.Text = "frmXAMLButtonwithPolylineandLabel";
            this.Load += new System.EventHandler(this.frmXAMLButtonwithPolylineandLabel_Load);
            this.ResumeLayout(false);

        }

        private void frmXAMLButtonwithPolylineandLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
