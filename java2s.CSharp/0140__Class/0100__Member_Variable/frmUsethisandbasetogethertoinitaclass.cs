using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0100__Member_Variable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usethisandbasetogethertoinitaclass.htm
    public partial  class frmUsethisandbasetogethertoinitaclass:Form
    {
        public frmUsethisandbasetogethertoinitaclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethisandbasetogethertoinitaclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethisandbasetogethertoinitaclass";
            this.Text = "frmUsethisandbasetogethertoinitaclass";
            this.Load += new System.EventHandler(this.frmUsethisandbasetogethertoinitaclass_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethisandbasetogethertoinitaclass_Load(object sender, EventArgs e)
        {

        }
    }
}
