using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0440__ToList
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/callingToList.htm
    public partial  class frmcallingToList:Form
    {
        public frmcallingToList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmcallingToList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmcallingToList";
            this.Text = "frmcallingToList";
            this.Load += new System.EventHandler(this.frmcallingToList_Load);
            this.ResumeLayout(false);

        }

        private void frmcallingToList_Load(object sender, EventArgs e)
        {

        }
    }
}
