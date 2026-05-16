using ChatApp;
using ChatApp.Controllers;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net;

namespace ChatRoomApplication
{
    public partial class Form1 : Form
    {
        SQL Sql;
        API api = new API();
        int userId;
        int roomId;
        string roomName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\GMRDC1\\Folder Redirection\\Veer.Shah\\Documents\\Visual Studio 2022\\Projects\\SQLAPIs\\ChatApp\\DBLibrary\\ChatRoomDB.mdf\";Integrated Security=True");
            menuPanel.Visible = true;
            createAccountPanel.Visible = false;
            loggedInPanel.Visible = false;
            loggingInPanel.Visible = false;
            createRoomPanel.Visible = false;
            joinRoomPanel.Visible = false;
            viewRoomPanel.Visible = false;
            roomPanel.Visible = false;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            createAccountPanel.Visible = true;
            menuPanel.Visible = false;
        }

        private void enterAccountCreation_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            object id;
            if (Sql.CreateAccount(username, password, out id))
            {
                loggedInPanel.Visible = true;
                createAccountPanel.Visible = false;
            }

            userId = (int)id;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            loggingInPanel.Visible = true;
        }

        private void logAccount_Click(object sender, EventArgs e)
        {
            
            string username = logUsername.Text;
            string password = logPassword.Text;
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string jsonBody = $"\"{username},{password}\"";
                    string result = client.UploadString("http://localhost:7141/ChatRoom/Login", username, password);
                    //Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
            object id;
            Exception error;
            if (Sql.Login(username, password, out id, out error))
            {
                api.Login(username, password);
                loggingInPanel.Visible = false;
                loggedInPanel.Visible = true;
            }
            else
            {
                Console.WriteLine("invalid username or password");
            }
            userId = (int)id;

        }

        private void postCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = roomUsernameBox.Text;
            string roomPass = roomPassBox.Text;
            object roomId;
            if (Sql.CreateRoom(roomName, roomPass, out roomId))
            {
                createRoomPanel.Visible = false;
                loggedInPanel.Visible = true;
                if (Sql.JoinRoom(roomName, roomPass))
                {
                    Sql.CreateAccountRoom(userId, (int)roomId);
                }
            }

        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            joinRoomPanel.Visible = true;
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            createRoomPanel.Visible = true;
        }

        private void getJoinRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = joinRoomUsernameBox.Text;
            string roomPassword = joinRoomPasswordBox.Text;
            object roomId;
            if (Sql.JoinRoom(roomName, roomPassword, out roomId))
            {
                if (Sql.CreateAccountRoom(userId, (int)roomId))
                {
                    joinRoomPanel.Visible = false;
                    loggedInPanel.Visible = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid room");
            }
        }


        private void viewRoomsButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            List<int> roomIds = Sql.GetRooms(userId);
            List<string> roomNames = Sql.GetRoomNames(roomIds);
            viewRoomPanel.Visible = true;
            int availableHeight = Size.Height;
            if (roomIds.Count == 0)
            {
                return;
            }
            int labelHeight = availableHeight / roomIds.Count;

            for (int i = 0; i < availableHeight / labelHeight; i++)
            {
                Label label = new Label();
                viewRoomPanel.Controls.Add(label);
                label.Location = new Point(0, i * labelHeight);
                label.AutoSize = true;
                label.Font = new Font("Segoe UI", labelHeight / 2);
                label.Text = roomNames[i];
                label.Click += room_Click;
            }
        }

        private void room_Click(object sender, EventArgs e)
        {
            viewRoomPanel.Visible = false;
            string roomName = ((Label)sender).Text;
            roomNameLabel.Text = roomName;
            roomPanel.Visible = true;
            object roomId;
            Sql.GetRoomID(roomName, out roomId);
            this.roomId = (int)roomId;
            messageUpdateTimer.Enabled = true;
            messageUpdateTimer.Start();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string content = messageBox.Text;

            if (Sql.SendText(userId, roomId, content, out object textId, out DateTime dt))
            {
                object username;
                Sql.GetUsername(userId, out username);
                Label label = new Label();
                label.Text = $"{(string)username}: {content}";
                label.AutoSize = true;
                label.Font = new Font("Segoe UI", 12);
                label.Location = new Point(0, messageBox.Bottom);
                messagePanel.Controls.Add(label);
            }
        }
        private void messageUpdateTimer_Tick(object sender, EventArgs e)
        {
            List<Text> messages = new List<Text>();
            messages = Sql.GetTextInformation(roomId);
            messagePanel.Controls.Clear();
            for (int i = 0; i < messages.Count; i++)
            {
                object username;
                Sql.GetUsername(messages[i].AccountID, out username);
                Label label = new Label();
                messagePanel.Controls.Add(label);

                label.Text = $"{(string)username}: {messages[i].Content}";
                label.AutoSize = true;
                label.Font = new Font("Segoe UI", 12);
                label.Location = new Point(0, messagePanel.Height - (50 + i * 50));
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            roomPanel.Visible = false;
            loggedInPanel.Visible = true;
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            viewRoomPanel.Visible = false;
            loggedInPanel.Visible = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            menuPanel.Visible = true;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            joinRoomPanel.Visible = false;
            loggedInPanel.Visible = true;
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            createRoomPanel.Visible = false;
            loggedInPanel.Visible = true;
        }

        private void backButton5_Click(object sender, EventArgs e)
        {
            createAccountPanel.Visible = false;
            menuPanel.Visible = true;
        }

        private void backButton6_Click(object sender, EventArgs e)
        {
            loggingInPanel.Visible = false;
            menuPanel.Visible = true;
        }
    }
}
