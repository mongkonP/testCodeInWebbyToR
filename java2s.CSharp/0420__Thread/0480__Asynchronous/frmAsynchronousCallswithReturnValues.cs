using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsynchronousCallswithReturnValues.htm
    public partial  class frmAsynchronousCallswithReturnValues:Form
    {
        public frmAsynchronousCallswithReturnValues()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousCallswithReturnValues
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousCallswithReturnValues";
            this.Text = "frmAsynchronousCallswithReturnValues";
            this.Load += new System.EventHandler(this.frmAsynchronousCallswithReturnValues_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousCallswithReturnValues_Load(object sender, EventArgs e)
        {

        }
    }
}
