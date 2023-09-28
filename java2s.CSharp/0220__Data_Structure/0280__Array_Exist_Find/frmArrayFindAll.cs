using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0280__Array_Exist_Find
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayFindAll.htm
    public partial  class frmArrayFindAll:Form
    {
        public frmArrayFindAll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayFindAll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayFindAll";
            this.Text = "frmArrayFindAll";
            this.Load += new System.EventHandler(this.frmArrayFindAll_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayFindAll_Load(object sender, EventArgs e)
        {

        }
    }
}
