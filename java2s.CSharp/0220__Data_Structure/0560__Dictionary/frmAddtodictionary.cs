using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0560__Dictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Addtodictionary.htm
    public partial  class frmAddtodictionary:Form
    {
        public frmAddtodictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddtodictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddtodictionary";
            this.Text = "frmAddtodictionary";
            this.Load += new System.EventHandler(this.frmAddtodictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmAddtodictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
