using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0660__SortedList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Showintegerindexesofentries.htm
    public partial  class frmShowintegerindexesofentries:Form
    {
        public frmShowintegerindexesofentries()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowintegerindexesofentries
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowintegerindexesofentries";
            this.Text = "frmShowintegerindexesofentries";
            this.Load += new System.EventHandler(this.frmShowintegerindexesofentries_Load);
            this.ResumeLayout(false);

        }

        private void frmShowintegerindexesofentries_Load(object sender, EventArgs e)
        {

        }
    }
}
