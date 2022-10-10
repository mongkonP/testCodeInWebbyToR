using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Methodparameterhidestheclassmemberfield.htm
    public partial  class frmMethodparameterhidestheclassmemberfield:Form
    {
        public frmMethodparameterhidestheclassmemberfield()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMethodparameterhidestheclassmemberfield
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMethodparameterhidestheclassmemberfield";
            this.Text = "frmMethodparameterhidestheclassmemberfield";
            this.Load += new System.EventHandler(this.frmMethodparameterhidestheclassmemberfield_Load);
            this.ResumeLayout(false);

        }

        private void frmMethodparameterhidestheclassmemberfield_Load(object sender, EventArgs e)
        {

        }
    }
}
