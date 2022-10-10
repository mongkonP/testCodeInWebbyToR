using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0320__Generic_Hiearchy
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Anongenericclasscanbethebaseclassofagenericderivedclass.htm
    public partial  class frmAnongenericclasscanbethebaseclassofagenericderivedclass:Form
    {
        public frmAnongenericclasscanbethebaseclassofagenericderivedclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnongenericclasscanbethebaseclassofagenericderivedclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnongenericclasscanbethebaseclassofagenericderivedclass";
            this.Text = "frmAnongenericclasscanbethebaseclassofagenericderivedclass";
            this.Load += new System.EventHandler(this.frmAnongenericclasscanbethebaseclassofagenericderivedclass_Load);
            this.ResumeLayout(false);

        }

        private void frmAnongenericclasscanbethebaseclassofagenericderivedclass_Load(object sender, EventArgs e)
        {

        }
    }
}
