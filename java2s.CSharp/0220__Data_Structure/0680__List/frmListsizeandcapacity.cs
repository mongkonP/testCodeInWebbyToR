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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Listsizeandcapacity.htm
    public partial  class frmListsizeandcapacity:Form
    {
        public frmListsizeandcapacity()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListsizeandcapacity
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListsizeandcapacity";
            this.Text = "frmListsizeandcapacity";
            this.Load += new System.EventHandler(this.frmListsizeandcapacity_Load);
            this.ResumeLayout(false);

        }

        private void frmListsizeandcapacity_Load(object sender, EventArgs e)
        {

        }
    }
}
