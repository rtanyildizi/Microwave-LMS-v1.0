﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.UserControls
{
    public partial class Publisher_Info : UserControl
    {
        private Microwave main_page;
        private Publisher_List main_pub_list;
        private Forms.AddPublisher edit_pub_form = null;
        private Detail detail_form = null;

        private string pub_name;
        private string pub_email;
        private string pub_phone_number;
        private string pub_date_of_est;
        private string pub_pic_path_file;
        private bool chosen = false;
        private int publisher_id;
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public string Pub_pic_path_file { get => pub_pic_path_file; set => pub_pic_path_file = value; }

        public Publisher_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_pub_list = main_page.Main_pub_list;
            this.btn_pub_edit.Hide();
            this.btn_pub_remove.Hide();

        }
        public void Initialize_Publisher_Info(int publisher_id, string pub_name, string pub_email, string pub_phone_number, string pub_date_of_est, string pub_pic_path_file)
        {
            this.publisher_id = publisher_id;
            this.lbl_pub_name.Text = pub_name;
            this.pub_name = pub_name;
            this.pub_email = pub_email;
            this.pub_phone_number = pub_phone_number;
            this.pub_date_of_est = pub_date_of_est;
            this.pub_pic_path_file = pub_pic_path_file;
            this.btn_pub_id.Text = publisher_id.ToString();
            this.pb_publisher.Image = Picture_Events.Get_Copy_Image_Bitmap(pub_pic_path_file);
        }

        public void Hide_Info()
        {
            main_page.Pnl_pub_list.Controls.Remove(this);
        }

        public void Draw_Publisher_Obj(ref int x, ref int y)
        {
            main_page.Pnl_pub_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);
            if (x > 500)
            {
                y += 240;
                x = 35;
            }
            else
            {
                x += 180;
            }
            pb_publisher.Image = Picture_Events.Get_Copy_Image_Bitmap(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + pub_pic_path_file);
        }
        public void Select_Publisher_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            Color back_color2 = Color.FromArgb(48, 52, 64);
            this.pnl_pub_name.BackColor = back_color2;
            this.BackColor = back_color;
            this.btn_pub_edit.Show();
            this.btn_pub_remove.Show();

        }
        public void Deselect_Publisher_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.BackColor = back_color;
            Color back_color2 = Color.FromArgb(55, 57, 68);
            this.pnl_pub_name.BackColor = back_color2;
            this.btn_pub_edit.Hide();
            this.btn_pub_remove.Hide();
        }
        public void Publisher_Info_Click(object sender, EventArgs e)
        {
            main_pub_list.Deselect_All_Infos();
            main_page.Publisher_search_list.Deselect_All_Infos();
            this.Select_Publisher_Info();
        }
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this publisher?";
            main_page.Create_Warning_Form(message, Color.DarkRed);
            bool delete_pic = true;

            if(pub_pic_path_file == System.Configuration.ConfigurationManager.AppSettings["def_pb_path"])
            {
                delete_pic = false;
            }

            if (main_page.Warning_form.Result)
                Remove(delete_pic);

            main_page.Warning_form.Refresh_Form();

           
        }
        public void Remove(bool delete_picture = true)
        {
            main_pub_list.Delete_Publisher_from_List(publisher_id, delete_picture);
            this.Dispose();

            Publisher.pub_point_y = 5;
            Publisher.pub_point_x = 35;
            main_page.Pnl_pub_list.VerticalScroll.Value = 0;
            main_page.Publisher_search_list.Delete_All_List();
            main_page.Main_pub_list.Draw_All_Publishers();
            main_page.Publisher_searched_already = false;

            main_page.Main_book_list.Delete_All_List();
            Book.Show_All_Books(main_page);
        }
        private void btn_pub_edit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to edit this publisher?";
            main_page.Create_Warning_Form(message, Color.DarkBlue);
            if (main_page.Warning_form.Result)
                Edit();

            main_page.Warning_form.Refresh_Form();
        }
        private void Edit()
        {
            Publisher current = main_pub_list.Find_Publisher_By_ID(publisher_id);
            // Don't delete the picture from file
            Create_Add_Publisher_Form_With_Publisher(current);
        }
        private void Create_Add_Publisher_Form_With_Publisher(Publisher publisher)
        {

            if (edit_pub_form == null)
            {
                edit_pub_form = new AddPublisher(publisher);
                edit_pub_form.Show();
            }
            else
            {
                try
                {
                    edit_pub_form.Show();
                }
                catch (Exception)
                {
                    edit_pub_form = new AddPublisher(publisher);
                    edit_pub_form.Show();
                }
            }
        }
        private void Create_Pub_Detail_Form(Publisher publisher)
        {

            if (detail_form == null)
            {
                detail_form = new Detail(publisher);
                detail_form.Show();
            }
            else
            {
                try
                {
                    detail_form.Show();
                }
                catch (Exception)
                {
                    detail_form = new Detail(publisher);
                    detail_form.Show();
                }
            }
        }
        public void Pub_Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_pub_name.BackColor = back_color2;
            }
        }
        public void Pub_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_pub_name.BackColor = back_color2;
            }
        }
        private void lbl_pub_name_MouseLeave(object sender, EventArgs e)
        {
            Pub_Mouse_Leave();
        }
        private void lbl_pub_name_MouseEnter(object sender, EventArgs e)
        {
            Pub_Hover();
        }
        private void Publisher_Info_DoubleClick(object sender, EventArgs e)
        {
            Publisher current = main_pub_list.Find_Publisher_By_ID(publisher_id);
            Create_Pub_Detail_Form(current);

        }

    }
}