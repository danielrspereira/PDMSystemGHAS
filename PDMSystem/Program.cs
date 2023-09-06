namespace PDMSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            string[] users = Users.GetAllUsers();
            string userName = Environment.UserName;

            if (users.Contains(userName))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Your user does not have rights to use this application!" + Environment.NewLine+ Environment.NewLine+ "For further information, please contact Daniel Pereira.", "Error - User: " + userName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
    }
}
