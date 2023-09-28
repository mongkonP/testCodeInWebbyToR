using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0300__Array_ForEach
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/foreachwithArrays.htm
    public partial  class frmforeachwithArrays:Form
    {
        public frmforeachwithArrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmforeachwithArrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmforeachwithArrays";
            this.Text = "frmforeachwithArrays";
            this.Load += new System.EventHandler(this.frmforeachwithArrays_Load);
            this.ResumeLayout(false);

        }

        private void frmforeachwithArrays_Load(object sender, EventArgs e)
        {

        }
    }
}
