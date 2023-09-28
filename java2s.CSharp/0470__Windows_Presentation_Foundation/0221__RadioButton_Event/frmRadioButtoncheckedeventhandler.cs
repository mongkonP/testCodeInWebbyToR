using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0221__RadioButton_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RadioButtoncheckedeventhandler.htm
    public partial  class frmRadioButtoncheckedeventhandler:Form
    {
        public frmRadioButtoncheckedeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRadioButtoncheckedeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRadioButtoncheckedeventhandler";
            this.Text = "frmRadioButtoncheckedeventhandler";
            this.Load += new System.EventHandler(this.frmRadioButtoncheckedeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmRadioButtoncheckedeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
