using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0180__OrderBy
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderedbyPetName.htm
    public partial  class frmOrderedbyPetName:Form
    {
        public frmOrderedbyPetName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderedbyPetName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderedbyPetName";
            this.Text = "frmOrderedbyPetName";
            this.Load += new System.EventHandler(this.frmOrderedbyPetName_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderedbyPetName_Load(object sender, EventArgs e)
        {

        }
    }
}
