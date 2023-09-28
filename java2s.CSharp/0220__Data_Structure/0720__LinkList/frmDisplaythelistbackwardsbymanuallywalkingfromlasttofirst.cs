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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Displaythelistbackwardsbymanuallywalkingfromlasttofirst.htm
    public partial  class frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst:Form
    {
        public frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst";
            this.Text = "frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst";
            this.Load += new System.EventHandler(this.frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythelistbackwardsbymanuallywalkingfromlasttofirst_Load(object sender, EventArgs e)
        {

        }
    }
}
