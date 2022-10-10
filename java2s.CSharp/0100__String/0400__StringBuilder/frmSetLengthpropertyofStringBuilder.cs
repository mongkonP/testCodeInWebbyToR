using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0400__StringBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/SetLengthpropertyofStringBuilder.htm
    public partial  class frmSetLengthpropertyofStringBuilder:Form
    {
        public frmSetLengthpropertyofStringBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetLengthpropertyofStringBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetLengthpropertyofStringBuilder";
            this.Text = "frmSetLengthpropertyofStringBuilder";
            this.Load += new System.EventHandler(this.frmSetLengthpropertyofStringBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmSetLengthpropertyofStringBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
