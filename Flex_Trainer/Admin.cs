using Flex_Trainer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Admin : Form
    {
        bool check = false;
        bool check1 = false;
        DB_Access database = new DB_Access();
        public string username {  get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string contactNo { get; set; }
        public string gender { get; set; }
        public Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Admin_Load;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            username_link.Text = username;
        }

        private void admin_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(admin_tab.SelectedIndex == 1)
            {
                if(check)
                {
                    return;
                }
                check = true;
                string query = "select gym_owner_request.member_id ,gym_owner_request.name , gym_owner_request.address , gym_owner_request.membership_price , CONCAT(member.firstname,' ' , member.lastname) as fullname , member.phone" +
                " from gym_owner_request" +
                " join member on member.userid = gym_owner_request.member_id";

                DataTable dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++ i)
                {
                    requestDiv request = new requestDiv()
                    {
                        get_set_name = dt.Rows[i][4].ToString(),
                        get_set_gymaddress = dt.Rows[i][2].ToString(),
                        get_set_contactnumber = dt.Rows[i][5].ToString(),
                        get_set_price = dt.Rows[i][3].ToString(),
                        get_set_gymname = dt.Rows[i][1].ToString(),
                        get_set_userid = int.Parse(dt.Rows[i][0].ToString())
                    };
                    request.acceptBtn += AcceptRequest;
                    request.declineBtn += declineRequest;
                    flow_gym_request.Controls.Add(request);                   
                }
            }
            else if(admin_tab.SelectedIndex == 2)
            {
                if(check1)
                {
                    return ;
                }
                check1 = true;
                string query = "select gym.gymid , gym.name , gym.address , gym_owner.userid , gym_owner.username , concat(gym_owner.firstname, ' ', gym_owner.lastname) as full_name, gym_owner.phone" +
                                " from gym" +
                                " join gym_owner on gym.owner_id = gym_owner.userid";

                
                DataTable dt = database.search_to_check(query);
                //MessageBox.Show(dt.Rows.Count.ToString());

                for (int i = 0; i < dt.Rows.Count; ++ i)
                {
                    removeDiv remove = new removeDiv()
                    {
                        get_set_gymid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_gymname = dt.Rows[i][1].ToString(),
                        get_set_address = dt.Rows[i][2].ToString(),
                        get_set_userid = int.Parse(dt.Rows[i][3].ToString()),
                        get_set_username = dt.Rows[i][4].ToString(),
                        get_set_ownername = dt.Rows[i][5].ToString(),
                        get_set_contactno = dt.Rows[i][6].ToString()
                    };
                    remove.removeBtn += removeGym;
                    flow_remove_gym.Controls.Add(remove);
                }
            }

        }

        private void AcceptRequest(object sender , EventArgs e)
        {
            requestDiv user = (requestDiv)sender;

            //select the user from member
            string query = "select * from member where userid = '" + user.get_set_userid + "'";
            //delete user from member
            string query2 = "delete from member where userid = '" + user.get_set_userid + "' ";
            
            //delete request 
            string query3 = "delete from gym_owner_request where member_id = '" + user.get_set_userid + "'";

            DataTable dt = database.search_to_check(query);
            database.query_data(query3);
            database.query_data(query2);
            

            //insert the user to gym owner
            query = "insert into gym_owner values('" + dt.Rows[0][1] + "' , '" + dt.Rows[0][2] + "' ,'" + dt.Rows[0][3] + "','" + dt.Rows[0][4] + "' ,'" + dt.Rows[0][5] + "')";

            database.query_data(query);

            //select the gymowner id from ggmowner table 
            query = "select * from gym_owner where username = '" + dt.Rows[0][1] + "'";

            DataTable dt2 = database.search_to_check(query);

            query = "insert into gym values ('" + user.get_set_gymname + "' ,'" + user.get_set_gymaddress + "' , '" + dt2.Rows[0][0] + "' ,'" + user.get_set_price + "' )";

            database.query_data(query);

            flow_gym_request.Controls.Remove(user);

        }

        private void declineRequest(object sender, EventArgs e)
        {
            requestDiv user = (requestDiv)sender;
            string query3 = "delete from gym_owner_request where member_id = '" + user.get_set_userid + "'";
            database.query_data(query3);
            flow_gym_request.Controls.Remove(user);
        }

        private void removeGym(object sender, EventArgs e)
        {
            removeDiv user = (removeDiv)sender;

            string query = "select * from trainer where gym_id = '" + user.get_set_gymid + "'";

            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //delete all the appointment related to the this gym with some trainer
                query = "delete from appointment where trainer_id = '" + dt.Rows[i][0] + "'";
                database.query_data(query);
                //delete all the feedback of the trainer realted to this gym
                query = "delete  from feedback where trainer_id = '" + dt.Rows[i][0] + "'";
                database.query_data(query);
                //get all workout plan
                query = "select * from workout_plan where creator = '" + dt.Rows[i][1] + "'";
                DataTable dt2 = database.search_to_check(query);

                for(int j = 0; j < dt2.Rows.Count; j++)
                {
                    string query2 = "delete from exercise where plan_id = '" + dt2.Rows[i][0] + "'";
                    database.query_data(query2);
                    query2 = "delete from member_workout where workout_plan = '" + dt2.Rows[i][0] + "'";
                    database.query_data(query2);
                }

                //delete all workout plan from the trainers
                query = "delete from workout_plan where creator = '" + dt.Rows[i][1] + "'";
                database.query_data(query);
            }
         
            //delete all the membership of this gym
            query = "delete from membership where gym_id = '" + user.get_set_gymid + "'";
            database.query_data(query);



            //delete all the the trainer
            query = "delete from trainer where gym_id = '" + user.get_set_gymid + "'";
            database.query_data(query);


            query = "delete from gym_review where gym_id = '"+user.get_set_gymid+"'";
            database.query_data(query);


            for (int i = 0; i < dt.Rows.Count;i++)
            {
                //demote all the trainer to member
                query = "insert into member values('" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "','" + dt.Rows[i][4] + "', '" + dt.Rows[i][5] + "')";
                database.query_data(query);
            }

            query = "delete from trainer_request where gym_id= '" + user.get_set_gymid + "'";
            database.query_data(query);

            query = "delete from gym where gymid = '" + user.get_set_gymid + "'";
            database.query_data(query);

            query = "select * from gym_owner where userid = '" + user.get_set_userid + "'";
            dt = database.search_to_check(query);

            query = "delete from gym_owner where userid = '" + user.get_set_userid + "'";
            database.query_data(query);

            query = "insert into member values('" + dt.Rows[0][1] + "','" + dt.Rows[0][2] + "','" + dt.Rows[0][3] + "','" + dt.Rows[0][4] + "', '" + dt.Rows[0][5] + "')";
            database.query_data(query);

            flow_remove_gym.Controls.Remove(user);
        }
    }
}
