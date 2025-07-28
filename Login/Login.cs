using Forms.UserdashBoard;  // use the namespace of DashboardForm
using Microsoft.VisualBasic.ApplicationServices;
using Forms.UserdashBoard.Dforms;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {     
            string path = @"C:\Users\asus\OneDrive\Desktop\forms\login\Resources\logo.jpg";

            if (File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at: " + path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //if (AuthService.ValidateUser(username, password))
            //{
            // Create and show the new form


            userdashboard dashboard = new userdashboard();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show(); //or ShowDialog() if you want it to be modal

           // home = new Home();
            //home.Show();

            // Close this (login) form
            this.Hide();      // optional: hide it first
            // actually closes the form
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password.");
            //}
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
