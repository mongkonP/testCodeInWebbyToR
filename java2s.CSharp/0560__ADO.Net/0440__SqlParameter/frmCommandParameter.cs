using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0440__SqlParameter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CommandParameter.htm
    public partial  class frmCommandParameter:Form
    {
        public frmCommandParameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCommandParameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCommandParameter";
            this.Text = "frmCommandParameter";
            this.Load += new System.EventHandler(this.frmCommandParameter_Load);
            this.ResumeLayout(false);

        }

        private void frmCommandParameter_Load(object sender, EventArgs e)
        {

        }
    }
}
