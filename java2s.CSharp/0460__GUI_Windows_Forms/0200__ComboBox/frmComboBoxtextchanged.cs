using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0200__ComboBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ComboBoxtextchanged.htm
    public partial  class frmComboBoxtextchanged:Form
    {
        public frmComboBoxtextchanged()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComboBoxtextchanged
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComboBoxtextchanged";
            this.Text = "frmComboBoxtextchanged";
            this.Load += new System.EventHandler(this.frmComboBoxtextchanged_Load);
            this.ResumeLayout(false);

        }

        private void frmComboBoxtextchanged_Load(object sender, EventArgs e)
        {

        }
    }
}
