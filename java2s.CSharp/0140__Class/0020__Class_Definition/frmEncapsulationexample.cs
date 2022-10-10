using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Encapsulationexample.htm
    public partial  class frmEncapsulationexample:Form
    {
        public frmEncapsulationexample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEncapsulationexample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEncapsulationexample";
            this.Text = "frmEncapsulationexample";
            this.Load += new System.EventHandler(this.frmEncapsulationexample_Load);
            this.ResumeLayout(false);

        }

        private void frmEncapsulationexample_Load(object sender, EventArgs e)
        {

        }
    }
}
