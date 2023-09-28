using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0020__Data_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/DefaultValueComparison.htm
    public partial  class frmDefaultValueComparison:Form
    {
        public frmDefaultValueComparison()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefaultValueComparison
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefaultValueComparison";
            this.Text = "frmDefaultValueComparison";
            this.Load += new System.EventHandler(this.frmDefaultValueComparison_Load);
            this.ResumeLayout(false);

        }

        private void frmDefaultValueComparison_Load(object sender, EventArgs e)
        {

        }
    }
}
