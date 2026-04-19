namespace ChatRoomApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loginButton = new Button();
            createAccountButton = new Button();
            createAccountPanel = new Panel();
            enterAccountCreation = new Button();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            menuPanel = new Panel();
            loggedInPanel = new Panel();
            joinRoomButton = new Button();
            createRoomButton = new Button();
            label2 = new Label();
            loggingInPanel = new Panel();
            logAccount = new Button();
            logPassword = new TextBox();
            logUsername = new TextBox();
            createRoomPanel = new Panel();
            postCreateRoom = new Button();
            roomPassBox = new TextBox();
            roomUsernameBox = new TextBox();
            joinRoomPanel = new Panel();
            viewRoomsButton = new Button();
            createAccountPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            loggedInPanel.SuspendLayout();
            loggingInPanel.SuspendLayout();
            createRoomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 100F);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(683, 177);
            label1.TabIndex = 0;
            label1.Text = "chat room";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(191, 279);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(548, 360);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(75, 23);
            createAccountButton.TabIndex = 2;
            createAccountButton.Text = "signup";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // createAccountPanel
            // 
            createAccountPanel.Controls.Add(enterAccountCreation);
            createAccountPanel.Controls.Add(passwordBox);
            createAccountPanel.Controls.Add(usernameBox);
            createAccountPanel.Dock = DockStyle.Fill;
            createAccountPanel.Location = new Point(0, 0);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(800, 450);
            createAccountPanel.TabIndex = 3;
            createAccountPanel.Visible = false;
            // 
            // enterAccountCreation
            // 
            enterAccountCreation.Location = new Point(336, 298);
            enterAccountCreation.Name = "enterAccountCreation";
            enterAccountCreation.Size = new Size(75, 23);
            enterAccountCreation.TabIndex = 2;
            enterAccountCreation.Text = "create";
            enterAccountCreation.UseVisualStyleBackColor = true;
            enterAccountCreation.Click += enterAccountCreation_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(328, 178);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(328, 76);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(createAccountButton);
            menuPanel.Controls.Add(loginButton);
            menuPanel.Controls.Add(label1);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(800, 450);
            menuPanel.TabIndex = 3;
            // 
            // loggedInPanel
            // 
            loggedInPanel.Controls.Add(viewRoomsButton);
            loggedInPanel.Controls.Add(joinRoomButton);
            loggedInPanel.Controls.Add(createRoomButton);
            loggedInPanel.Controls.Add(label2);
            loggedInPanel.Dock = DockStyle.Fill;
            loggedInPanel.Location = new Point(0, 0);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.Size = new Size(800, 450);
            loggedInPanel.TabIndex = 3;
            // 
            // joinRoomButton
            // 
            joinRoomButton.Location = new Point(539, 241);
            joinRoomButton.Name = "joinRoomButton";
            joinRoomButton.Size = new Size(75, 23);
            joinRoomButton.TabIndex = 2;
            joinRoomButton.Text = "join room";
            joinRoomButton.UseVisualStyleBackColor = true;
            joinRoomButton.Click += joinRoomButton_Click;
            // 
            // createRoomButton
            // 
            createRoomButton.Location = new Point(146, 241);
            createRoomButton.Name = "createRoomButton";
            createRoomButton.Size = new Size(169, 23);
            createRoomButton.TabIndex = 1;
            createRoomButton.Text = "create room";
            createRoomButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(247, 46);
            label2.Name = "label2";
            label2.Size = new Size(284, 37);
            label2.TabIndex = 0;
            label2.Text = "you are now logged in";
            // 
            // loggingInPanel
            // 
            loggingInPanel.Controls.Add(logAccount);
            loggingInPanel.Controls.Add(logPassword);
            loggingInPanel.Controls.Add(logUsername);
            loggingInPanel.Dock = DockStyle.Fill;
            loggingInPanel.Location = new Point(0, 0);
            loggingInPanel.Name = "loggingInPanel";
            loggingInPanel.Size = new Size(800, 450);
            loggingInPanel.TabIndex = 0;
            // 
            // logAccount
            // 
            logAccount.Location = new Point(336, 327);
            logAccount.Name = "logAccount";
            logAccount.Size = new Size(75, 23);
            logAccount.TabIndex = 2;
            logAccount.Text = "login";
            logAccount.UseVisualStyleBackColor = true;
            logAccount.Click += logAccount_Click;
            // 
            // logPassword
            // 
            logPassword.Location = new Point(334, 219);
            logPassword.Name = "logPassword";
            logPassword.Size = new Size(100, 23);
            logPassword.TabIndex = 1;
            // 
            // logUsername
            // 
            logUsername.Location = new Point(334, 113);
            logUsername.Name = "logUsername";
            logUsername.Size = new Size(100, 23);
            logUsername.TabIndex = 0;
            // 
            // createRoomPanel
            // 
            createRoomPanel.Controls.Add(postCreateRoom);
            createRoomPanel.Controls.Add(roomPassBox);
            createRoomPanel.Controls.Add(roomUsernameBox);
            createRoomPanel.Dock = DockStyle.Fill;
            createRoomPanel.Location = new Point(0, 0);
            createRoomPanel.Name = "createRoomPanel";
            createRoomPanel.Size = new Size(800, 450);
            createRoomPanel.TabIndex = 4;
            // 
            // postCreateRoom
            // 
            postCreateRoom.Location = new Point(367, 327);
            postCreateRoom.Name = "postCreateRoom";
            postCreateRoom.Size = new Size(75, 23);
            postCreateRoom.TabIndex = 0;
            postCreateRoom.Text = "create";
            postCreateRoom.Click += postCreateRoom_Click;
            // 
            // roomPassBox
            // 
            roomPassBox.Location = new Point(367, 219);
            roomPassBox.Name = "roomPassBox";
            roomPassBox.Size = new Size(100, 23);
            roomPassBox.TabIndex = 1;
            // 
            // roomUsernameBox
            // 
            roomUsernameBox.Location = new Point(367, 79);
            roomUsernameBox.Name = "roomUsernameBox";
            roomUsernameBox.Size = new Size(100, 23);
            roomUsernameBox.TabIndex = 0;
            // 
            // joinRoomPanel
            // 
            joinRoomPanel.Dock = DockStyle.Fill;
            joinRoomPanel.Location = new Point(0, 0);
            joinRoomPanel.Name = "joinRoomPanel";
            joinRoomPanel.Size = new Size(800, 450);
            joinRoomPanel.TabIndex = 0;
            // 
            // viewRoomsButton
            // 
            viewRoomsButton.Location = new Point(346, 335);
            viewRoomsButton.Name = "viewRoomsButton";
            viewRoomsButton.Size = new Size(75, 23);
            viewRoomsButton.TabIndex = 3;
            viewRoomsButton.Text = "view room";
            viewRoomsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loggedInPanel);
            Controls.Add(createAccountPanel);
            Controls.Add(menuPanel);
            Controls.Add(loggingInPanel);
            Controls.Add(joinRoomPanel);
            Controls.Add(createRoomPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            createAccountPanel.ResumeLayout(false);
            createAccountPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            loggedInPanel.ResumeLayout(false);
            loggedInPanel.PerformLayout();
            loggingInPanel.ResumeLayout(false);
            loggingInPanel.PerformLayout();
            createRoomPanel.ResumeLayout(false);
            createRoomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private Button createAccountButton;
        private Panel createAccountPanel;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button enterAccountCreation;
        private Panel menuPanel;
        private Panel loggedInPanel;
        private Panel loggingInPanel;
        private Button logAccount;
        private TextBox logPassword;
        private TextBox logUsername;
        private Button joinRoomButton;
        private Button createRoomButton;
        private Label label2;
        private Panel createRoomPanel;
        private Panel joinRoomPanel;
        private Button postCreateRoom;
        private TextBox roomPassBox;
        private TextBox roomUsernameBox;
        private Button viewRoomsButton;
    }
}
