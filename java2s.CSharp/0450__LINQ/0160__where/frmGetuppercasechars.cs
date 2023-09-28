using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Getuppercasechars.htm
    public partial  class frmGetuppercasechars:Form
    {
        public frmGetuppercasechars()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetuppercasechars
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetuppercasechars";
            this.Text = "frmGetuppercasechars";
            this.Load += new System.EventHandler(this.frmGetuppercasechars_Load);
            this.ResumeLayout(false);

        }

        private void frmGetuppercasechars_Load(object sender, EventArgs e)
        {

        }
    }
}
