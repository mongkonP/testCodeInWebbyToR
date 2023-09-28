using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0080__Member_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Definemethods.htm
    public partial  class frmDefinemethods:Form
    {
        public frmDefinemethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefinemethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefinemethods";
            this.Text = "frmDefinemethods";
            this.Load += new System.EventHandler(this.frmDefinemethods_Load);
            this.ResumeLayout(false);

        }

        private void frmDefinemethods_Load(object sender, EventArgs e)
        {

        }
    }
}
