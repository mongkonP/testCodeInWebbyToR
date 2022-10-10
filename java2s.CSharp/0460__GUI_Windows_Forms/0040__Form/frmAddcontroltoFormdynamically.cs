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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddcontroltoFormdynamically.htm
    public partial  class frmAddcontroltoFormdynamically:Form
    {
        public frmAddcontroltoFormdynamically()
        {
            InitializeComponent();
        }
        Button MyButton;
        private void InitializeComponent()
        {
            this.SuspendLayout();
             MyButton = new Button();

            Text = "Button Test";
            MyButton.Location = new Point(25, 25);
            MyButton.Text = "Click Me";
            MyButton.Click += new EventHandler(MyButtonClicked);
            Controls.Add(MyButton);
            // 
            // frmAddcontroltoFormdynamically
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddcontroltoFormdynamically";
            this.Text = "frmAddcontroltoFormdynamically";
            this.Load += new System.EventHandler(this.frmAddcontroltoFormdynamically_Load);
            this.ResumeLayout(false);

        }
        public void MyButtonClicked(object sender, EventArgs Arguments)
        {
            MessageBox.Show("The button has been clicked.");
        }
        private void frmAddcontroltoFormdynamically_Load(object sender, EventArgs e)
        {

        }
    }
}
