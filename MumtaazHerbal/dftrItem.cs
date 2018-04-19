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

namespace MumtaazHerbal
{
    public partial class dftrItem : DevExpress.XtraEditors.XtraForm
    {
        
        
        public dftrItem()
        {
            InitializeComponent();
        }

        private void dftrItem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-J5QHE7L\SQLEXPRESS;Initial Catalog = MumtaazDB; Integrated Security = True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [tb_daftar_item]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridControl1.DataSource = dt;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhItem))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhItem item = new tmbhItem();
            item.MdiParent = this.ParentForm;
            item.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}