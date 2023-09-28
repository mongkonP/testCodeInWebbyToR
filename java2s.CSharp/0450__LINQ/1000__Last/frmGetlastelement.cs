using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1000__Last
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Getlastelement.htm
    public partial  class frmGetlastelement:Form
    {
        public frmGetlastelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetlastelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetlastelement";
            this.Text = "frmGetlastelement";
            this.Load += new System.EventHandler(this.frmGetlastelement_Load);
            this.ResumeLayout(false);

        }

        private void frmGetlastelement_Load(object sender, EventArgs e)
        {

        }
    }
}
