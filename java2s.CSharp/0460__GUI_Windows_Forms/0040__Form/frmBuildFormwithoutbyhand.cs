using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0040__Form
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BuildFormwithoutbyhand.htm
    public partial  class frmBuildFormwithoutbyhand:Form
    {
        private TextBox firstNameBox = new TextBox();
        private Button btnShowControls = new Button();

        public frmBuildFormwithoutbyhand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            firstNameBox.Text = "Text";
            firstNameBox.Size = new Size(150, 50);
            firstNameBox.Location = new Point(10, 10);
            this.Controls.Add(firstNameBox);

            btnShowControls.Text = "Click Me";
            btnShowControls.Size = new Size(90, 90);
            btnShowControls.Location = new Point(10, 70);
            btnShowControls.Click += new EventHandler(btnShowControls_Clicked);
            this.Controls.Add(btnShowControls);

           
            // 
            // frmBuildFormwithoutbyhand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBuildFormwithoutbyhand";
            this.Text = "frmBuildFormwithoutbyhand";
            this.Load += new System.EventHandler(this.frmBuildFormwithoutbyhand_Load);
            this.ResumeLayout(false);

        }
        protected void btnShowControls_Clicked(object sender, EventArgs e)
        {
            Control.ControlCollection coll = this.Controls;
            foreach (Control c in coll)
            {
                if (c != null)
                    Console.WriteLine(string.Format("Index: {0}, Text: {1}\n", coll.GetChildIndex(c, false), c.Text));
            }
            MessageBox.Show("Message", "Index and Text values for each control");
        }
        private void frmBuildFormwithoutbyhand_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
