using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0340__XPath
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/SelectAllBooks.htm
    public partial  class frmSelectAllBooks:Form
    {
        public frmSelectAllBooks()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectAllBooks
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectAllBooks";
            this.Text = "frmSelectAllBooks";
            this.Load += new System.EventHandler(this.frmSelectAllBooks_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectAllBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
