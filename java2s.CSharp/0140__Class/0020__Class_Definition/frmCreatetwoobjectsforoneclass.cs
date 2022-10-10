using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Createtwoobjectsforoneclass.htm
    public partial  class frmCreatetwoobjectsforoneclass:Form
    {
        public frmCreatetwoobjectsforoneclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatetwoobjectsforoneclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatetwoobjectsforoneclass";
            this.Text = "frmCreatetwoobjectsforoneclass";
            this.Load += new System.EventHandler(this.frmCreatetwoobjectsforoneclass_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatetwoobjectsforoneclass_Load(object sender, EventArgs e)
        {

        }
    }
}
