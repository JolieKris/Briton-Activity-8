namespace User
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            btnGet = new Button();
            txtOutput = new TextBox();
            groupBox2 = new GroupBox();
            btnPost = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBio = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGet);
            groupBox1.Controls.Add(txtOutput);
            groupBox1.Location = new Point(42, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.IndianRed;
            btnGet.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGet.ForeColor = SystemColors.ButtonHighlight;
            btnGet.Location = new Point(369, 160);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(112, 34);
            btnGet.TabIndex = 1;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.LightGray;
            txtOutput.Location = new Point(70, 30);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(411, 124);
            txtOutput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPost);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtBio);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Location = new Point(42, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(559, 430);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.IndianRed;
            btnPost.Font = new Font("Dubai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPost.ForeColor = SystemColors.ButtonHighlight;
            btnPost.Location = new Point(369, 390);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(112, 34);
            btnPost.TabIndex = 8;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(70, 325);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 7;
            label4.Text = "Bio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(70, 242);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(70, 143);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(70, 353);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(411, 31);
            txtBio.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(411, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(70, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(411, 31);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(70, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(411, 31);
            txtUsername.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(641, 709);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "MySQL API";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGet;
        private TextBox txtOutput;
        private Button btnPost;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBio;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ContextMenuStrip contextMenuStrip1;
    }
}