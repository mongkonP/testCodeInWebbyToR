using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0420__ToDictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ToDictionaryforanobjectlist.htm
    public partial  class frmToDictionaryforanobjectlist:Form
    {
        public frmToDictionaryforanobjectlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToDictionaryforanobjectlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToDictionaryforanobjectlist";
            this.Text = "frmToDictionaryforanobjectlist";
            this.Load += new System.EventHandler(this.frmToDictionaryforanobjectlist_Load);
            this.ResumeLayout(false);

        }

        private void frmToDictionaryforanobjectlist_Load(object sender, EventArgs e)
        {

        }
    }
}
