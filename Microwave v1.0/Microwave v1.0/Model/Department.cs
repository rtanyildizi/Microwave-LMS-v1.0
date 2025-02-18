﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using System.Data;


namespace Microwave_v1._0.Classes
{
    public class Department
    {
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];

        public static int point_y = 5;
        public static int point_x = 35;
        private string name;
        private int department_id;
        private int staff_count;
        private string cover_path_file;
        static Microwave main_page = null;
        private Department_Info info;



        public string Name { get => name; set => name = value; }
        public int Department_id { get => department_id; set => department_id = value; }
        public int Staff_count { get => staff_count; set => staff_count = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public Department_Info Info { get => info; set => info = value; }

        public Department(int department_id, string name, string Cover_path_file)
        {
            this.department_id = department_id;
            this.name = name;
            this.cover_path_file = Cover_path_file;
            main_page = (Microwave)Application.OpenForms["Microwave"];
        }
        public Department()
        {

        }
        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Department (NAME, COVER_PATH)";
            values = string.Format("VALUES('{0}','{1}')", name, cover_path_file);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, data_source);

            info = new Department_Info();
            Take_Id_From_Database();


            info.Initialize_Department_Info(department_id, name, cover_path_file);


            main_page.Main_department_list.Add_Department_to_List(this);
            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            info.Draw_Department_Obj(ref Department.point_x, ref Department.point_y);

        }
        public void Edit()
        {
            string title = "UPDATE Department ";
            string query = title + string.Format("SET NAME = '{0}', COVER_PATH = '{1}' WHERE DEPARTMENT_ID = '{2}'", name, cover_path_file, department_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }


            info.Initialize_Department_Info(department_id, name, cover_path_file);
            info.Select_Department_Info();

        }
        public void Set_Department()
        {
            info = new Department_Info();
            info.Initialize_Department_Info(department_id, name, cover_path_file);
        }

        public void Delete()
        {

            string title1 = "UPDATE Employee ";
            string query1 = title1 + string.Format("SET DEPARTMENT_ID = 0 WHERE Employee.DEPARTMENT_ID = '{0}'", this.department_id);

            DataBaseEvents.ExecuteNonQuery(query1, data_source);

            string title = "DELETE FROM Department ";
            string query = title + string.Format("Where DEPARTMENT_ID = '{0}' ;", department_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            if (result <= 0)
            {
                MessageBox.Show("Delete is not valid");
                return;
            }
        }

        private void Take_Id_From_Database()
        {

            string title = "SELECT Department.DEPARTMENT_ID FROM Department ";
            string query = title + string.Format("Where NAME = '{0}';", name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.department_id = id;

            this.Info.Department_id = id;
        }
        static public void Show_All_Departments(Microwave main_page)
        {
            string query = "SELECT * FROM Department";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            main_page.Main_department_list.Fill_Department_list(dt);
            main_page.Main_department_list.Draw_All_Dep_Infos();

        }
    }
}

