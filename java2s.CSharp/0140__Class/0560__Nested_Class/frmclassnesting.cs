using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0560__Nested_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/classnesting.htm
    public partial  class frmclassnesting:Form
    {
        public frmclassnesting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmclassnesting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmclassnesting";
            this.Text = "frmclassnesting";
            this.Load += new System.EventHandler(this.frmclassnesting_Load);
            this.ResumeLayout(false);

        }

        private void frmclassnesting_Load(object sender, EventArgs e)
        {

        }
    }
}
