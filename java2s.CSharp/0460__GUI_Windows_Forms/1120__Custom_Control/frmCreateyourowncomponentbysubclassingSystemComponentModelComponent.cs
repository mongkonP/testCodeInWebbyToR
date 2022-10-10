using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1120__Custom_Control
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CreateyourowncomponentbysubclassingSystemComponentModelComponent.htm
    public partial  class frmCreateyourowncomponentbysubclassingSystemComponentModelComponent:Form
    {
        public frmCreateyourowncomponentbysubclassingSystemComponentModelComponent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateyourowncomponentbysubclassingSystemComponentModelComponent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateyourowncomponentbysubclassingSystemComponentModelComponent";
            this.Text = "frmCreateyourowncomponentbysubclassingSystemComponentModelComponent";
            this.Load += new System.EventHandler(this.frmCreateyourowncomponentbysubclassingSystemComponentModelComponent_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateyourowncomponentbysubclassingSystemComponentModelComponent_Load(object sender, EventArgs e)
        {

        }
    }
}
