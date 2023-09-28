using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ListConvertAll.htm
    public partial  class frmListConvertAll:Form
    {
        public frmListConvertAll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListConvertAll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListConvertAll";
            this.Text = "frmListConvertAll";
            this.Load += new System.EventHandler(this.frmListConvertAll_Load);
            this.ResumeLayout(false);

        }

        private void frmListConvertAll_Load(object sender, EventArgs e)
        {

        }
    }
}
