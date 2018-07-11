﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;
using MumtaazHerbal.Function;

namespace MumtaazHerbal
{
    public partial class connection : DevExpress.XtraEditors.XtraForm
    {
        public connection()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmMain();
            frm.Show();
        }

        private void connection_Load(object sender, EventArgs e)
        {
            comboServer.Properties.Items.Add(".");
            comboServer.Properties.Items.Add("(local)");
            comboServer.Properties.Items.Add(@".\SQLEXPRESS");
            comboServer.Properties.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            comboServer.SelectedIndex = 0;
        }

        //get list database
        public List<string> GetDatabasesList()
        {
            var list = new List<string>();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MumtaazFix"].ConnectionString))
            {
                cn.Open();

                var cmd = new SqlCommand("SELECT name FROM sys.databases", cn);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                    list.Add(dr[0].ToString());

            }
            return list;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboServer.Text) || string.IsNullOrEmpty(listBoxDatabase.Text))
            {
                MessageBox.Show("Mohon isi server dan nama database", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dbhelper = new DbHelper();
            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI;", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            var main = new frmMain();
            main.Show();
            this.Close();
        }

        //cari database
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            listBoxDatabase.DataSource = GetDatabasesList();

        }

        //btn create database
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            createDB create = new createDB();
            create.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboServer.Text) || string.IsNullOrEmpty(listBoxDatabase.Text))
            {
                MessageBox.Show("Mohon isi server dan nama database", "Mumtaaz Herbal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dbhelper = new DbHelper();
            Properties.Settings.Default.ConnectionString = string.Format("data source={0};initial catalog={1};integrated security=SSPI;", comboServer.Text, listBoxDatabase.SelectedValue.ToString());
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }
    }
}