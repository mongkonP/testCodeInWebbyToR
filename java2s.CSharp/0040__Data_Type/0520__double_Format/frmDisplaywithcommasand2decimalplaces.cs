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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Displaywithcommasand2decimalplaces.htm
    public partial  class frmDisplaywithcommasand2decimalplaces:Form
    {
        public frmDisplaywithcommasand2decimalplaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaywithcommasand2decimalplaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaywithcommasand2decimalplaces";
            this.Text = "frmDisplaywithcommasand2decimalplaces";
            this.Load += new System.EventHandler(this.frmDisplaywithcommasand2decimalplaces_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaywithcommasand2decimalplaces_Load(object sender, EventArgs e)
        {

        }
    }
}
