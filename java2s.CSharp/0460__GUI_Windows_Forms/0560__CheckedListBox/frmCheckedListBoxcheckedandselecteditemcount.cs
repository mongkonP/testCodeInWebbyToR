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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CheckedListBoxcheckedandselecteditemcount.htm
    public partial  class frmCheckedListBoxcheckedandselecteditemcount:Form
    {
        public frmCheckedListBoxcheckedandselecteditemcount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckedListBoxcheckedandselecteditemcount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckedListBoxcheckedandselecteditemcount";
            this.Text = "frmCheckedListBoxcheckedandselecteditemcount";
            this.Load += new System.EventHandler(this.frmCheckedListBoxcheckedandselecteditemcount_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckedListBoxcheckedandselecteditemcount_Load(object sender, EventArgs e)
        {

        }
    }
}
