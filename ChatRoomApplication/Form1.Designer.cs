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
            loggingInPanel = new Panel();
            logAccount = new Button();
            logPassword = new TextBox();
            logUsername = new TextBox();
            label2 = new Label();
            createRoomButton = new Button();
            this.joinRoomButton = new Button();
            this.viewRoomsButton = new Button();
            createAccountPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            loggedInPanel.SuspendLayout();
            loggingInPanel.SuspendLayout();
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
            loggedInPanel.Controls.Add(this.viewRoomsButton);
            loggedInPanel.Controls.Add(this.joinRoomButton);
            loggedInPanel.Controls.Add(createRoomButton);
            loggedInPanel.Controls.Add(label2);
            loggedInPanel.Dock = DockStyle.Fill;
            loggedInPanel.Location = new Point(0, 0);
            loggedInPanel.Name = "loggedInPanel";
            loggedInPanel.Size = new Size(800, 450);
            loggedInPanel.TabIndex = 3;
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
            // createRoomButton
            // 
            createRoomButton.Location = new Point(146, 241);
            createRoomButton.Name = "createRoomButton";
            createRoomButton.Size = new Size(91, 23);
            createRoomButton.TabIndex = 1;
            createRoomButton.Text = "Create room";
            createRoomButton.UseVisualStyleBackColor = true;
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.Location = new Point(539, 241);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new Size(75, 23);
            this.joinRoomButton.TabIndex = 2;
            this.joinRoomButton.Text = "Join room";
            this.joinRoomButton.UseVisualStyleBackColor = true;
            // 
            // viewRoomsButton
            // 
            this.viewRoomsButton.Location = new Point(353, 337);
            this.viewRoomsButton.Name = "viewRoomsButton";
            this.viewRoomsButton.Size = new Size(116, 23);
            this.viewRoomsButton.TabIndex = 3;
            this.viewRoomsButton.Text = "View your rooms";
            this.viewRoomsButton.UseVisualStyleBackColor = true;
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
        private Button button3;
        private Button button2;
        private Button createRoomButton;
        private Label label2;
    }
}
