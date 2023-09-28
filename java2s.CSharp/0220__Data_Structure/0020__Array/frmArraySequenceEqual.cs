using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0020__Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArraySequenceEqual.htm
    public partial  class frmArraySequenceEqual:Form
    {
        public frmArraySequenceEqual()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArraySequenceEqual
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArraySequenceEqual";
            this.Text = "frmArraySequenceEqual";
            this.Load += new System.EventHandler(this.frmArraySequenceEqual_Load);
            this.ResumeLayout(false);

        }

        private void frmArraySequenceEqual_Load(object sender, EventArgs e)
        {

        }
    }
}
