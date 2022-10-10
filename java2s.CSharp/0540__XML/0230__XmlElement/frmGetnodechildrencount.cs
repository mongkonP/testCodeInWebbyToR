using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0230__XmlElement
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/Getnodechildrencount.htm
    public partial  class frmGetnodechildrencount:Form
    {
        public frmGetnodechildrencount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetnodechildrencount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetnodechildrencount";
            this.Text = "frmGetnodechildrencount";
            this.Load += new System.EventHandler(this.frmGetnodechildrencount_Load);
            this.ResumeLayout(false);

        }

        private void frmGetnodechildrencount_Load(object sender, EventArgs e)
        {

        }
    }
}
