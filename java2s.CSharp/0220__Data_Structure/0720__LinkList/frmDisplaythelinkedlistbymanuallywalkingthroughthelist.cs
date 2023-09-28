using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0720__LinkList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Displaythelinkedlistbymanuallywalkingthroughthelist.htm
    public partial  class frmDisplaythelinkedlistbymanuallywalkingthroughthelist:Form
    {
        public frmDisplaythelinkedlistbymanuallywalkingthroughthelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythelinkedlistbymanuallywalkingthroughthelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythelinkedlistbymanuallywalkingthroughthelist";
            this.Text = "frmDisplaythelinkedlistbymanuallywalkingthroughthelist";
            this.Load += new System.EventHandler(this.frmDisplaythelinkedlistbymanuallywalkingthroughthelist_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythelinkedlistbymanuallywalkingthroughthelist_Load(object sender, EventArgs e)
        {

        }
    }
}
