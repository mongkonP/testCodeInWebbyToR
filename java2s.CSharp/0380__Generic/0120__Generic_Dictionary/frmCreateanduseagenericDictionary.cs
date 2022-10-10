using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0120__Generic_Dictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/CreateanduseagenericDictionary.htm
    public partial  class frmCreateanduseagenericDictionary:Form
    {
        public frmCreateanduseagenericDictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateanduseagenericDictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateanduseagenericDictionary";
            this.Text = "frmCreateanduseagenericDictionary";
            this.Load += new System.EventHandler(this.frmCreateanduseagenericDictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateanduseagenericDictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
