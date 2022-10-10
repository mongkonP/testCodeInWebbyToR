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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/NumericAdditionoverflowforabyte.htm
    public partial  class frmNumericAdditionoverflowforabyte:Form
    {
        public frmNumericAdditionoverflowforabyte()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNumericAdditionoverflowforabyte
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNumericAdditionoverflowforabyte";
            this.Text = "frmNumericAdditionoverflowforabyte";
            this.Load += new System.EventHandler(this.frmNumericAdditionoverflowforabyte_Load);
            this.ResumeLayout(false);

        }

        private void frmNumericAdditionoverflowforabyte_Load(object sender, EventArgs e)
        {

        }
    }
}
