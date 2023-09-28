using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UsingtheTrimToSizemethodtoreducethecapacityofArrayList.htm
    public partial  class frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList:Form
    {
        public frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList";
            this.Text = "frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList";
            this.Load += new System.EventHandler(this.frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtheTrimToSizemethodtoreducethecapacityofArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
