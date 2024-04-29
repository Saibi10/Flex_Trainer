
using Flex_Trainer.Classes;


namespace Flex_Trainer
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.admin_tab = new Guna.UI2.WinForms.Guna2TabControl();
            this.performance_gym = new System.Windows.Forms.TabPage();
            this.owner_request = new System.Windows.Forms.TabPage();
            this.flow_gym_request = new System.Windows.Forms.FlowLayoutPanel();
            this.remove_gym = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.username_link = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.notifications_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flow_remove_gym = new System.Windows.Forms.FlowLayoutPanel();
            this.admin_tab.SuspendLayout();
            this.owner_request.SuspendLayout();
            this.remove_gym.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_tab
            // 
            this.admin_tab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.admin_tab.Controls.Add(this.performance_gym);
            this.admin_tab.Controls.Add(this.owner_request);
            this.admin_tab.Controls.Add(this.remove_gym);
            this.admin_tab.Controls.Add(this.tabPage1);
            this.admin_tab.Controls.Add(this.tabPage2);
            this.admin_tab.ItemSize = new System.Drawing.Size(150, 60);
            this.admin_tab.Location = new System.Drawing.Point(35, 47);
            this.admin_tab.Name = "admin_tab";
            this.admin_tab.Padding = new System.Drawing.Point(0, 0);
            this.admin_tab.SelectedIndex = 0;
            this.admin_tab.Size = new System.Drawing.Size(1135, 614);
            this.admin_tab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.admin_tab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.admin_tab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.admin_tab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.admin_tab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.admin_tab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.admin_tab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.admin_tab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.admin_tab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.admin_tab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.admin_tab.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.admin_tab.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.admin_tab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.admin_tab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.admin_tab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.admin_tab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.admin_tab.TabButtonSize = new System.Drawing.Size(150, 60);
            this.admin_tab.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.admin_tab.TabIndex = 0;
            this.admin_tab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.admin_tab.SelectedIndexChanged += new System.EventHandler(this.admin_tab_SelectedIndexChanged);
            // 
            // performance_gym
            // 
            this.performance_gym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.performance_gym.Location = new System.Drawing.Point(154, 4);
            this.performance_gym.Name = "performance_gym";
            this.performance_gym.Padding = new System.Windows.Forms.Padding(3);
            this.performance_gym.Size = new System.Drawing.Size(977, 606);
            this.performance_gym.TabIndex = 0;
            this.performance_gym.Text = "Gym Performance";
            // 
            // owner_request
            // 
            this.owner_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.owner_request.Controls.Add(this.flow_gym_request);
            this.owner_request.Location = new System.Drawing.Point(154, 4);
            this.owner_request.Name = "owner_request";
            this.owner_request.Padding = new System.Windows.Forms.Padding(3);
            this.owner_request.Size = new System.Drawing.Size(977, 606);
            this.owner_request.TabIndex = 1;
            this.owner_request.Text = "Gym Request";
            // 
            // flow_gym_request
            // 
            this.flow_gym_request.AutoScroll = true;
            this.flow_gym_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.flow_gym_request.Location = new System.Drawing.Point(6, 29);
            this.flow_gym_request.Name = "flow_gym_request";
            this.flow_gym_request.Size = new System.Drawing.Size(975, 571);
            this.flow_gym_request.TabIndex = 0;
            // 
            // remove_gym
            // 
            this.remove_gym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(213)))), ((int)(((byte)(198)))));
            this.remove_gym.Controls.Add(this.flow_remove_gym);
            this.remove_gym.Location = new System.Drawing.Point(154, 4);
            this.remove_gym.Name = "remove_gym";
            this.remove_gym.Size = new System.Drawing.Size(977, 606);
            this.remove_gym.TabIndex = 2;
            this.remove_gym.Text = "Revoke Gym";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(977, 606);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(977, 606);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "View Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "______________________________________________";
            // 
            // username_link
            // 
            this.username_link.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.username_link.LinkColor = System.Drawing.Color.White;
            this.username_link.Location = new System.Drawing.Point(47, 14);
            this.username_link.Name = "username_link";
            this.username_link.Size = new System.Drawing.Size(100, 23);
            this.username_link.TabIndex = 2;
            this.username_link.TabStop = true;
            this.username_link.Text = "hussnain";
            this.username_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(46, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 63);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(33, 28);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 122);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(33, 28);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 4;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(3, 177);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(33, 28);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 5;
            this.guna2PictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = "\r\n\r\n____________________________";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(4, 300);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(33, 28);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox5.TabIndex = 7;
            this.guna2PictureBox5.TabStop = false;
            // 
            // notifications_btn
            // 
            this.notifications_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.notifications_btn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.notifications_btn.Image = ((System.Drawing.Image)(resources.GetObject("notifications_btn.Image")));
            this.notifications_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.notifications_btn.ImageRotate = 0F;
            this.notifications_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.notifications_btn.Location = new System.Drawing.Point(1052, 6);
            this.notifications_btn.Name = "notifications_btn";
            this.notifications_btn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.notifications_btn.Size = new System.Drawing.Size(57, 38);
            this.notifications_btn.TabIndex = 0;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1116, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Size = new System.Drawing.Size(57, 38);
            this.guna2ImageButton1.TabIndex = 8;
            // 
            // flow_remove_gym
            // 
            this.flow_remove_gym.AutoScroll = true;
            this.flow_remove_gym.Location = new System.Drawing.Point(3, 25);
            this.flow_remove_gym.Name = "flow_remove_gym";
            this.flow_remove_gym.Size = new System.Drawing.Size(971, 578);
            this.flow_remove_gym.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1168, 658);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.notifications_btn);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.username_link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_tab);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.admin_tab.ResumeLayout(false);
            this.owner_request.ResumeLayout(false);
            this.remove_gym.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl admin_tab;
        private System.Windows.Forms.TabPage performance_gym;
        private System.Windows.Forms.TabPage owner_request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel username_link;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.TabPage remove_gym;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flow_gym_request;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2ImageButton notifications_btn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flow_remove_gym;
    }
}