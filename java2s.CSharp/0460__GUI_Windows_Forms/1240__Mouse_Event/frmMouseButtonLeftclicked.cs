using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1240__Mouse_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MouseButtonLeftclicked.htm
    public partial  class frmMouseButtonLeftclicked:Form
    {
        public frmMouseButtonLeftclicked()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMouseButtonLeftclicked
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMouseButtonLeftclicked";
            this.Text = "frmMouseButtonLeftclicked";
            this.Load += new System.EventHandler(this.frmMouseButtonLeftclicked_Load);
            this.ResumeLayout(false);

        }

        private void frmMouseButtonLeftclicked_Load(object sender, EventArgs e)
        {

        }
    }
}
