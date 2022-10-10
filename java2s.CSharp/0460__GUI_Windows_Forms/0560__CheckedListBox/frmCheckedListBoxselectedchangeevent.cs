using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0560__CheckedListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CheckedListBoxselectedchangeevent.htm
    public partial  class frmCheckedListBoxselectedchangeevent:Form
    {
        public frmCheckedListBoxselectedchangeevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckedListBoxselectedchangeevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckedListBoxselectedchangeevent";
            this.Text = "frmCheckedListBoxselectedchangeevent";
            this.Load += new System.EventHandler(this.frmCheckedListBoxselectedchangeevent_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckedListBoxselectedchangeevent_Load(object sender, EventArgs e)
        {

        }
    }
}
