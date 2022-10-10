using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0840__First
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Getthefirstelement.htm
    public partial  class frmGetthefirstelement:Form
    {
        public frmGetthefirstelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthefirstelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthefirstelement";
            this.Text = "frmGetthefirstelement";
            this.Load += new System.EventHandler(this.frmGetthefirstelement_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthefirstelement_Load(object sender, EventArgs e)
        {

        }
    }
}
