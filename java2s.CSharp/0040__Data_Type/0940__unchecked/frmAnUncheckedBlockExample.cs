using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0940__unchecked
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/AnUncheckedBlockExample.htm
    public partial  class frmAnUncheckedBlockExample:Form
    {
        public frmAnUncheckedBlockExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnUncheckedBlockExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnUncheckedBlockExample";
            this.Text = "frmAnUncheckedBlockExample";
            this.Load += new System.EventHandler(this.frmAnUncheckedBlockExample_Load);
            this.ResumeLayout(false);

        }

        private void frmAnUncheckedBlockExample_Load(object sender, EventArgs e)
        {

        }
    }
}
