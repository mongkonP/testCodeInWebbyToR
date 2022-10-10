using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0580__Hashtable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/MarkaHashtabletobeSynchronized.htm
    public partial  class frmMarkaHashtabletobeSynchronized:Form
    {
        public frmMarkaHashtabletobeSynchronized()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMarkaHashtabletobeSynchronized
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMarkaHashtabletobeSynchronized";
            this.Text = "frmMarkaHashtabletobeSynchronized";
            this.Load += new System.EventHandler(this.frmMarkaHashtabletobeSynchronized_Load);
            this.ResumeLayout(false);

        }

        private void frmMarkaHashtabletobeSynchronized_Load(object sender, EventArgs e)
        {

        }
    }
}
