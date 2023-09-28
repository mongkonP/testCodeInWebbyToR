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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PassingaNullValuetoaQueryParameter.htm
    public partial  class frmPassingaNullValuetoaQueryParameter:Form
    {
        public frmPassingaNullValuetoaQueryParameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassingaNullValuetoaQueryParameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassingaNullValuetoaQueryParameter";
            this.Text = "frmPassingaNullValuetoaQueryParameter";
            this.Load += new System.EventHandler(this.frmPassingaNullValuetoaQueryParameter_Load);
            this.ResumeLayout(false);

        }

        private void frmPassingaNullValuetoaQueryParameter_Load(object sender, EventArgs e)
        {

        }
    }
}
