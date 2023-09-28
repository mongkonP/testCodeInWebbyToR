using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0520__double_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Displaywith2decimalplaces.htm
    public partial  class frmDisplaywith2decimalplaces:Form
    {
        public frmDisplaywith2decimalplaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaywith2decimalplaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaywith2decimalplaces";
            this.Text = "frmDisplaywith2decimalplaces";
            this.Load += new System.EventHandler(this.frmDisplaywith2decimalplaces_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaywith2decimalplaces_Load(object sender, EventArgs e)
        {

        }
    }
}
