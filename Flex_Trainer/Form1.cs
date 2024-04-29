using Flex_Trainer.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;


namespace Flex_Trainer
{
    public partial class Form1 : Form
    {
        DB_Access database = new DB_Access();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //----------------------------------- Login Tab -------------------------------------------
        private void login_button_Click_1(object sender, EventArgs e)
        {
            string query1 = "select * from account where username = '" + username_text_tab1.Text + "' AND password = '" + password_text_tab1.Text + "'";

            DataTable dt = database.search_to_check(query1);

            if(dt.Rows.Count == 0)
            {
                error_label_tab1.Text = "Invalid Credentials";
            }
            else
            {
                dt = null;
                //first check if a member
                string query2 = "select * from member where username = '" + username_text_tab1.Text + "'";
                dt = database.search_to_check(query2); 
                if(dt.Rows.Count > 0) //user is a member of gym
                {
                    //open form over here
                    return;
                }
                dt = null;
                query2 = "select * from gym_owner where username = '" + username_text_tab1.Text + "'";
                dt = database.search_to_check(query2);
                if (dt.Rows.Count > 0) //user is a  gymowner
                {
                    //open form over here
                    return;
                }
                dt = null;
                query2 = "select * from trainer where username = '" + username_text_tab1.Text + "'";
                dt = database.search_to_check(query2);
                if (dt.Rows.Count > 0) //user is a  trainer
                {
                    //open form over here
                    return;
                }
                dt = null;
                query2 = "select * from admin where username = '" + username_text_tab1.Text + "'";
                dt = database.search_to_check(query2);
                if (dt.Rows.Count > 0) //user is a  trainer
                {
                    Admin adminlogin = new Admin();
                    this.Hide();
                    adminlogin.username = dt.Rows[0][1].ToString();
                    adminlogin.firstname = dt.Rows[0][2].ToString();
                    adminlogin.lastname = dt.Rows[0][3].ToString(); 
                    adminlogin.contactNo = dt.Rows[0][4].ToString();


                    MessageBox.Show(adminlogin.firstname);
                    adminlogin.Show();
                    return;
                }
            }
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            main_control_tab.SelectTab(1);
        }

        //----------------------------------- Register Tab -------------------------------------------

        private void signup_btn_tab2_Click_1(object sender, EventArgs e) //register button click
        {
            if (username_text_tab2.Text == "")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }
            else if (password_text_tab2.Text == "")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }
            else if (contact_info_txt_tab2.Text == "")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }
            else if (gender_combobox_tab2.Text == "Gender")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }
            else if (password_text_tab2.Text == "")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }
            else if (confirm_password_text_tab2.Text == "")
            {
                error_message_tab2.Text = "Please fill all fields";
                return;
            }

            //check in users
            string query1 = "select * from account where username = '" + username_text_tab2.Text + "'";

            DataTable dt = database.search_to_check(query1);

            if (dt.Rows.Count > 0)
            {
                username_text_tab2.Text = "";
                error_message_tab2.Text = "Username already exist";
            }
            else
            {
                if (password_text_tab2.Text != confirm_password_text_tab2.Text)
                {
                    error_message_tab2.Text = "password does not match";
                    return;
                }

                string query2 = "insert into account values('" + username_text_tab2.Text + "' , '" + email_text_tab2.Text + "' ," +
                                "'" + password_text_tab2.Text + "')";

                database.query_data(query2);

                string query3 = "insert into member values('" + username_text_tab2.Text+"' , '"+firstname_tab2.Text+"' ," +
                    "'"+lastname_tab2.Text + "' , '"+contact_info_txt_tab2.Text + "' , '"+gender_combobox_tab2.Text + "' , '"+0+"' )";

                database.query_data(query3);

                username_text_tab2.Text = "";
                firstname_tab2.Text = "";
                lastname_tab2.Text = "";
                confirm_password_text_tab2.Text = "";
                password_text_tab2.Text = "";
                gender_combobox_tab2.StartIndex = 0;
                email_text_tab2.Text = "";

                main_control_tab.SelectTab(0);
            }
        }


        private void signin_btn_tab1_Click(object sender, EventArgs e)
        {
            main_control_tab.SelectTab(0);
        }


        //--------------------------------------------------------------



    }
}
