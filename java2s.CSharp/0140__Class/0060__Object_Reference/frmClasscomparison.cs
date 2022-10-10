using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0060__Object_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Classcomparison.htm
    public partial  class frmClasscomparison:Form
    {
        public frmClasscomparison()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClasscomparison
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClasscomparison";
            this.Text = "frmClasscomparison";
            this.Load += new System.EventHandler(this.frmClasscomparison_Load);
            this.ResumeLayout(false);

        }

        private void frmClasscomparison_Load(object sender, EventArgs e)
        {

        }
    }
}
