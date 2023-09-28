using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0700__IList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IListTprintsomespecificelementindexes.htm
    public partial  class frmIListTprintsomespecificelementindexes:Form
    {
        public frmIListTprintsomespecificelementindexes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIListTprintsomespecificelementindexes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIListTprintsomespecificelementindexes";
            this.Text = "frmIListTprintsomespecificelementindexes";
            this.Load += new System.EventHandler(this.frmIListTprintsomespecificelementindexes_Load);
            this.ResumeLayout(false);

        }

        private void frmIListTprintsomespecificelementindexes_Load(object sender, EventArgs e)
        {

        }
    }
}
