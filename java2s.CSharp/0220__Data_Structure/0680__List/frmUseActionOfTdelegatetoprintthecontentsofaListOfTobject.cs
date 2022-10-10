using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UseActionOfTdelegatetoprintthecontentsofaListOfTobject.htm
    public partial  class frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject:Form
    {
        public frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject";
            this.Text = "frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject";
            this.Load += new System.EventHandler(this.frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUseActionOfTdelegatetoprintthecontentsofaListOfTobject_Load(object sender, EventArgs e)
        {

        }
    }
}
