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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ComboBoxfocusleaveevent.htm
    public partial  class frmComboBoxfocusleaveevent:Form
    {
        public frmComboBoxfocusleaveevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComboBoxfocusleaveevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComboBoxfocusleaveevent";
            this.Text = "frmComboBoxfocusleaveevent";
            this.Load += new System.EventHandler(this.frmComboBoxfocusleaveevent_Load);
            this.ResumeLayout(false);

        }

        private void frmComboBoxfocusleaveevent_Load(object sender, EventArgs e)
        {

        }
    }
}
