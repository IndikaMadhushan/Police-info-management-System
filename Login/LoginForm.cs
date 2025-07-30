using Forms.UserdashBoard;  // use the namespace of DashboardForm
using Forms.UserdashBoard.Dforms;
using Forms.DataAccess;
using Forms.BusinessLogic;
using Forms.Factories;
using Forms.Models;

namespace login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            //string password = "Admin@123";
            //string hashed = PasswordHasher.HashPassword(password);
            //txtUsername.Text = ("Hashed password: " + hashed);

            // //Admin = userName = admin3; password = Admin@123
            //  //User = userName = user; password = User@123

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = AuthenticationService.Authenticate(username, password);


            if (user != null)
            {
                Form dashboard = DashboardFactory.GetDashboard(user);
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            







            //Database conneciona start

            // bool test = DatabaseConnection.TestConnectin();

            //if (test)
            //{
            //    Console.WriteLine("Database connection successful.");

            //    string username = txtUsername.Text;
            //    string password = txtPassword.Text;

            //    //if (AuthService.ValidateUser(username, password))
            //    //{
            //    // Create and show the new form


            //UserDashboard dashboard = new UserDashboard();
            //dashboard.FormClosed += (s, args) => this.Close();
            //dashboard.Show(); //or ShowDialog() if you want it to be modal



            //    // Close this (login) form
            //    this.Hide();      // optional: hide it first
            //                      // actually closes the form
            //                      //}
            //                      //else
            //                      //{
            //                      //    MessageBox.Show("Invalid username or password.");
            //                      //}
            //}
            //else
            //{
            //    txtConnect.Text = "Incorrect User Name or Password!";
            //    txtConnect.ForeColor = Color.Red;
            //    // MessageBox.Show("Database connection failed. Please check your connection settings.");
            //}
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
