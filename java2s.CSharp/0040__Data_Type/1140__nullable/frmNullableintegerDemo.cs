using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1140__nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NullableintegerDemo.htm
    public partial  class frmNullableintegerDemo:Form
    {
        public frmNullableintegerDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNullableintegerDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNullableintegerDemo";
            this.Text = "frmNullableintegerDemo";
            this.Load += new System.EventHandler(this.frmNullableintegerDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmNullableintegerDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
