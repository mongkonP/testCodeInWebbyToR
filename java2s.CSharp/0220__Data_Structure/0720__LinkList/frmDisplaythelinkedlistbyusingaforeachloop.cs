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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Displaythelinkedlistbyusingaforeachloop.htm
    public partial  class frmDisplaythelinkedlistbyusingaforeachloop:Form
    {
        public frmDisplaythelinkedlistbyusingaforeachloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythelinkedlistbyusingaforeachloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythelinkedlistbyusingaforeachloop";
            this.Text = "frmDisplaythelinkedlistbyusingaforeachloop";
            this.Load += new System.EventHandler(this.frmDisplaythelinkedlistbyusingaforeachloop_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythelinkedlistbyusingaforeachloop_Load(object sender, EventArgs e)
        {

        }
    }
}
