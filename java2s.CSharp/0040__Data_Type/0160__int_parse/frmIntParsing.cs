using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0160__int_parse
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/IntParsing.htm
    public partial  class frmIntParsing:Form
    {
        public frmIntParsing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntParsing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntParsing";
            this.Text = "frmIntParsing";
            this.Load += new System.EventHandler(this.frmIntParsing_Load);
            this.ResumeLayout(false);

        }

        private void frmIntParsing_Load(object sender, EventArgs e)
        {

        }
    }
}
