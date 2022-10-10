using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0180__ComboBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlesComboBoxItemSelectedevents.htm
    public partial  class frmHandlesComboBoxItemSelectedevents:Form
    {
        public frmHandlesComboBoxItemSelectedevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlesComboBoxItemSelectedevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlesComboBoxItemSelectedevents";
            this.Text = "frmHandlesComboBoxItemSelectedevents";
            this.Load += new System.EventHandler(this.frmHandlesComboBoxItemSelectedevents_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlesComboBoxItemSelectedevents_Load(object sender, EventArgs e)
        {

        }
    }
}
