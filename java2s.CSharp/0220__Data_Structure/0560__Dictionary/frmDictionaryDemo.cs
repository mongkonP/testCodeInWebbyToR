using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0560__Dictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/DictionaryDemo.htm
    public partial  class frmDictionaryDemo:Form
    {
        public frmDictionaryDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDictionaryDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDictionaryDemo";
            this.Text = "frmDictionaryDemo";
            this.Load += new System.EventHandler(this.frmDictionaryDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmDictionaryDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
