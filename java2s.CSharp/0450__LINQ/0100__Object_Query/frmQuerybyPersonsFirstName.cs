using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0100__Object_Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/QuerybyPersonsFirstName.htm
    public partial  class frmQuerybyPersonsFirstName:Form
    {
        public frmQuerybyPersonsFirstName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQuerybyPersonsFirstName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQuerybyPersonsFirstName";
            this.Text = "frmQuerybyPersonsFirstName";
            this.Load += new System.EventHandler(this.frmQuerybyPersonsFirstName_Load);
            this.ResumeLayout(false);

        }

        private void frmQuerybyPersonsFirstName_Load(object sender, EventArgs e)
        {

        }
    }
}
