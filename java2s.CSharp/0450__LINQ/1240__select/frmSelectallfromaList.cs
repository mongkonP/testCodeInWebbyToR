using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SelectallfromaList.htm
    public partial  class frmSelectallfromaList:Form
    {
        public frmSelectallfromaList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectallfromaList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectallfromaList";
            this.Text = "frmSelectallfromaList";
            this.Load += new System.EventHandler(this.frmSelectallfromaList_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectallfromaList_Load(object sender, EventArgs e)
        {

        }
    }
}
