﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace SQLite_DataBaseManager
{
    public partial class Form1 : Form
    {
        SQLite db = new SQLite();
        CreateViewForm viewForm;
        CreateDatabaseForm createForm;
        CreateTableForm createTableForm;
        CreateIndexForm indexform;
        EditTableForm editTableform;
        CreateTriggerForm triggerForm;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabases();
        }

        private void InitializeDatabases()
        {
            DatabaseTree.Nodes.Clear();
            DatabaseTree.Nodes.Add("Databases", "Databases","server.png","server.png");
            DatabaseTree.Nodes["Databases"].ContextMenuStrip = DatabasesMenuStrip;
            string[] files = Directory.GetFiles("C:/Users/dell/Documents/Visual Studio 2013/Projects/SQLite_DataBaseManager/SQLite_DataBaseManager/bin/Debug");
            string[] dabatases;
            foreach (string file in files)
            {
                if (file.EndsWith(".sqlite"))
                {
                    dabatases = file.Split('\\','.');
                    DatabaseTree.Nodes[0].Nodes.Add(dabatases[dabatases.Length - 2].ToString(),
                        dabatases[dabatases.Length - 2].ToString(),0,0);
                }
            }
            int n = DatabaseTree.Nodes[0].Nodes.Count;
            for (int i = 0; i < n; i++)
            {
                DatabaseTree.Nodes[0].Nodes[i].ContextMenuStrip = DatabaseMenuStrip;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void connectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseTree.SelectedNode.Text != "Databases")
            {
                try
                {
                    db.ConnectDatabase(DatabaseTree.SelectedNode.Text.ToString());
                    DatabaseTree.SelectedNode.Nodes.Add("Tables", "Tables", 5, 5);
                    DatabaseTree.SelectedNode.Nodes["Tables"].ContextMenuStrip = TablesMenuStrip;
                    LoadTables();
                    DatabaseTree.SelectedNode.Nodes.Add("Views", "Views", 6, 6);
                    DatabaseTree.SelectedNode.Nodes["Views"].ContextMenuStrip = ViewsMenuStrip;
                    LoadViews();
                    DatabaseTree.SelectedNode.Expand();
                }
                catch (Exception ex)
                {
                    AppendText(ex.Message, Color.Red);
                }
            }
            
            
        }
        private void LoadTables()
        {
            DataTable dt = db.GetTables();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[0].ToString(),
                    5,5);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].ContextMenuStrip = TableMenuStrip;

                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes.Add("Columns", "Columns", 9, 9);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes["Columns"].ContextMenuStrip = ColumnsMenuStrip;

                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes.Add("Indexes", "Indexes",9,9);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes["Indexes"].ContextMenuStrip = IndexesMenuStrip;

                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes.Add("Triggers", "Triggers",10,10);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Nodes["Triggers"].ContextMenuStrip = TriggerMenuStrip;


                string tableName = DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[i].Text; 
                LoadColumns(tableName);
                LoadIndexes(dt.Rows[i].ItemArray[0].ToString());
                LoadTriggers(tableName);
            }
                
        }

        private void LoadTriggers(string table)
        {
            DataTable dt = db.GetTriggers(table);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[table].Nodes["Indexes"].Nodes.Add(dt.Rows[i].ItemArray[0].ToString(),
                    dt.Rows[i].ItemArray[0].ToString(), 5, 5);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[table].Nodes["Indexes"].Nodes[i].ContextMenuStrip = IndexMenuStrip;
            }
        }

        private void LoadIndexes(string table)
        {
            DataTable dt = db.GetIndexes(table);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[table].Nodes["Indexes"].Nodes.Add(dt.Rows[i].ItemArray[0].ToString(),
                    dt.Rows[i].ItemArray[0].ToString(), 5, 5);
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[table].Nodes["Indexes"].Nodes[i].ContextMenuStrip = IndexMenuStrip;
            }
        }

        private void LoadColumns(string table)
        {
            DataTable dt = db.GetTableColumns(table);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseTree.SelectedNode.Nodes["Tables"].Nodes[table].Nodes["Columns"].Nodes.Add(dt.Rows[i].ItemArray[1].ToString(),
                    dt.Rows[i].ItemArray[1].ToString(),5, 5);
            }
        }
        private void LoadViews()
        {
            DataTable dt = db.GetViews();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseTree.SelectedNode.Nodes["Views"].Nodes.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[0].ToString(),
                    5, 5);
            }

        }

        private void CreateDatabaseAction_Click(object sender, EventArgs e)
        {
            createForm = new CreateDatabaseForm(db);
            createForm.ShowDialog();
        }

        private void RefreshDatabasesAction_Click(object sender, EventArgs e)
        {
            InitializeDatabases();
            DatabaseTree.Nodes[0].Expand();
        }

        private void removeTheDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Drop database: " + DatabaseTree.SelectedNode.Text.ToString() + "?", "Drop database",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                db.DeleteDatabase(DatabaseTree.SelectedNode.Text.ToString());
                RefreshDatabasesAction_Click(sender, e);
            }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openSDLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void disconnectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.CloseConnection();
            InitializeDatabases(); 
            DatabaseTree.Nodes[0].Expand();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

           
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CreateView_Click(object sender, EventArgs e)
        {
            viewForm = new CreateViewForm(db);
            viewForm.ShowDialog();
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            viewForm = new CreateViewForm(db);
            viewForm.ShowDialog();
        }
        

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTableForm = new CreateTableForm(db);
            createTableForm.ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            indexform = new CreateIndexForm(db,this.DatabaseTree.SelectedNode.Parent.Text);
            indexform.ShowDialog();
        }

        private void RunAction_Click(object sender, EventArgs e)
        {
            string sql;
            if (!String.IsNullOrEmpty(QueryTextBox.SelectedText))
            {
                sql = QueryTextBox.SelectedText;
            }
            else{
                sql = this.QueryTextBox.Text;
            }
            
            if (!String.IsNullOrEmpty(sql))
            {
                try
                {
                    DataTable dt = new DataTable();
                    this.dataGridView1.DataSource = db.ExecuteWithResults(sql);
                    tabControl1.SelectedIndex = 0;
                    string message= "sql Excecuted successfully";
                    AppendText(message, Color.Blue);
                }
                catch (Exception ex)
                {
                    AppendText(ex.Message, Color.Red);
                }
            }
            else
            {
                string message = "Cannot execute empty query.";
                AppendText(message, Color.Black);
                
            }
            
        }
        private void AppendText(string message,Color color)
        {
            int length = statusTextBox.TextLength;
            statusTextBox.AppendText(DateTime.Now.ToString()+" "+message+"\n");
            statusTextBox.SelectionStart = length;
            statusTextBox.SelectionLength = message.Length+DateTime.Now.ToString().Length+1;
            statusTextBox.SelectionColor = color;
            statusTextBox.SelectionStart = statusTextBox.Text.Length;
            statusTextBox.ScrollToCaret();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            InitializeDatabases();
        }

        private void ConnectDatabase_Click(object sender, EventArgs e)
        {
            connectToDatabaseToolStripMenuItem_Click(sender, e);
        }

        private void DisconnectDatabase_Click(object sender, EventArgs e)
        {
            disconnectToDatabaseToolStripMenuItem_Click(sender, e);
        }

        private void RemoveDatabase_Click(object sender, EventArgs e)
        {
            removeTheDatabaseToolStripMenuItem_Click(sender, e);
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createToolStripMenuItem_Click(sender, e);
        }

        private void viewDataToolStripMenuItem_Click(object send, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string tableName = "";
            tableName += DatabaseTree.SelectedNode.Text;
            this.dataGridView1.DataSource =  db.ExecuteWithResults("SELECT * FROM "+tableName);
        }

        private void DatabaseTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DatabaseTree.SelectedNode = e.Node;
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Drop table: " + DatabaseTree.SelectedNode.Text.ToString() + "?", "Drop table",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                db.ExecuteWithResults("DROP TABLE " + DatabaseTree.SelectedNode.Text.ToString());
                RefreshDatabasesAction_Click(sender, e);
            }
        }

        private void editTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTableform = new EditTableForm(db);
            editTableform.ShowDialog();
        }

        private void insertDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataForm dataform = new AddDataForm(DatabaseTree.SelectedNode.Text, db);
            dataform.Show();
        }

        private void createIndexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createToolStripMenuItem1_Click(sender, e);
        }

        private void createTriggerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            triggerForm = new CreateTriggerForm(db,DatabaseTree.SelectedNode.Parent.Text);
            triggerForm.ShowDialog();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Drop index: " + DatabaseTree.SelectedNode.Text.ToString() + "?", "Drop index",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                db.ExecuteWithResults("DROP INDEX " + DatabaseTree.SelectedNode.Text.ToString());
                RefreshDatabasesAction_Click(sender, e);
            }
        }

        private void deleteViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Drop view: " + DatabaseTree.SelectedNode.Text.ToString() + "?", "Drop view",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                db.ExecuteWithResults("DROP VIEW " + DatabaseTree.SelectedNode.Text.ToString());
                RefreshDatabasesAction_Click(sender, e);
            }
        }

        private void DatabaseTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (DatabaseTree.SelectedNode.Parent != null)
            {
                if (DatabaseTree.SelectedNode.Parent.Text == "Databases")
                {
                    this.connectToDatabaseToolStripMenuItem_Click(sender, e);
                }
                else if (DatabaseTree.SelectedNode.Parent.Text == "Tables")
                {
                    this.DDL_TextBox.Text = db.GetDDL(DatabaseTree.SelectedNode.Text, "table");
                }
                else if (DatabaseTree.SelectedNode.Parent.Text == "Views")
                {
                    this.DDL_TextBox.Text = db.GetDDL(DatabaseTree.SelectedNode.Text, "view");
                }
                else if (DatabaseTree.SelectedNode.Parent.Text == "Indexes")
                {
                    this.DDL_TextBox.Text = db.GetDDL(DatabaseTree.SelectedNode.Text, "index");
                }
                else if (DatabaseTree.SelectedNode.Parent.Text == "Triggers")
                {
                    this.DDL_TextBox.Text = db.GetDDL(DatabaseTree.SelectedNode.Text, "trigger");
                }
                tabControl1.SelectedIndex = 1;
            }
            
        }

        private void OpenFileAction_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void SaveFileAction_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }
      
        
    }
}
