using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0740__Generic_LinkedList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/LinkedListTAddFirstAddLastAddBefore.htm
    public partial  class frmLinkedListTAddFirstAddLastAddBefore:Form
    {
        public frmLinkedListTAddFirstAddLastAddBefore()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinkedListTAddFirstAddLastAddBefore
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinkedListTAddFirstAddLastAddBefore";
            this.Text = "frmLinkedListTAddFirstAddLastAddBefore";
            this.Load += new System.EventHandler(this.frmLinkedListTAddFirstAddLastAddBefore_Load);
            this.ResumeLayout(false);

        }

        private void frmLinkedListTAddFirstAddLastAddBefore_Load(object sender, EventArgs e)
        {

        }
    }
}
