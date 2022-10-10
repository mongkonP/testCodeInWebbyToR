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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Displayusingscientificnotation.htm
    public partial  class frmDisplayusingscientificnotation:Form
    {
        public frmDisplayusingscientificnotation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayusingscientificnotation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayusingscientificnotation";
            this.Text = "frmDisplayusingscientificnotation";
            this.Load += new System.EventHandler(this.frmDisplayusingscientificnotation_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayusingscientificnotation_Load(object sender, EventArgs e)
        {

        }
    }
}
