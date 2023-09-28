using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0920__checked
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ACheckedBlockExample.htm
    public partial  class frmACheckedBlockExample:Form
    {
        public frmACheckedBlockExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmACheckedBlockExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmACheckedBlockExample";
            this.Text = "frmACheckedBlockExample";
            this.Load += new System.EventHandler(this.frmACheckedBlockExample_Load);
            this.ResumeLayout(false);

        }

        private void frmACheckedBlockExample_Load(object sender, EventArgs e)
        {

        }
    }
}
