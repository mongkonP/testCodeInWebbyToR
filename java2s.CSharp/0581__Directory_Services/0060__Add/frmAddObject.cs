using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0060__Add
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/AddObject.htm
    public partial  class frmAddObject:Form
    {
        public frmAddObject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddObject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddObject";
            this.Text = "frmAddObject";
            this.Load += new System.EventHandler(this.frmAddObject_Load);
            this.ResumeLayout(false);

        }

        private void frmAddObject_Load(object sender, EventArgs e)
        {

        }
    }
}
