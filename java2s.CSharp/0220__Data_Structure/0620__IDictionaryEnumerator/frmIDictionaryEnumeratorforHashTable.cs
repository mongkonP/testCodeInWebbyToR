using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0620__IDictionaryEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IDictionaryEnumeratorforHashTable.htm
    public partial  class frmIDictionaryEnumeratorforHashTable:Form
    {
        public frmIDictionaryEnumeratorforHashTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIDictionaryEnumeratorforHashTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIDictionaryEnumeratorforHashTable";
            this.Text = "frmIDictionaryEnumeratorforHashTable";
            this.Load += new System.EventHandler(this.frmIDictionaryEnumeratorforHashTable_Load);
            this.ResumeLayout(false);

        }

        private void frmIDictionaryEnumeratorforHashTable_Load(object sender, EventArgs e)
        {

        }
    }
}
