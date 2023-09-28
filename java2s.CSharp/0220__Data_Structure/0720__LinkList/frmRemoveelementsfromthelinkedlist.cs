using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0720__LinkList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Removeelementsfromthelinkedlist.htm
    public partial  class frmRemoveelementsfromthelinkedlist:Form
    {
        public frmRemoveelementsfromthelinkedlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveelementsfromthelinkedlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveelementsfromthelinkedlist";
            this.Text = "frmRemoveelementsfromthelinkedlist";
            this.Load += new System.EventHandler(this.frmRemoveelementsfromthelinkedlist_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveelementsfromthelinkedlist_Load(object sender, EventArgs e)
        {

        }
    }
}
