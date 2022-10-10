using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0220__Anonymous
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Arrayofanonymoustypes.htm
    public partial  class frmArrayofanonymoustypes:Form
    {
        public frmArrayofanonymoustypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayofanonymoustypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayofanonymoustypes";
            this.Text = "frmArrayofanonymoustypes";
            this.Load += new System.EventHandler(this.frmArrayofanonymoustypes_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayofanonymoustypes_Load(object sender, EventArgs e)
        {

        }
    }
}
