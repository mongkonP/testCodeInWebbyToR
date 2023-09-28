using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0520__double_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Displayapercentage.htm
    public partial  class frmDisplayapercentage:Form
    {
        public frmDisplayapercentage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayapercentage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayapercentage";
            this.Text = "frmDisplayapercentage";
            this.Load += new System.EventHandler(this.frmDisplayapercentage_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayapercentage_Load(object sender, EventArgs e)
        {

        }
    }
}
