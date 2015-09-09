﻿namespace SQLite_DataBaseManager
{
    partial class CreateIndexForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.PartialCheck = new System.Windows.Forms.CheckBox();
            this.TablesGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UniqueCheck = new System.Windows.Forms.CheckBox();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndexName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GeneratedSQL = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Size = new System.Drawing.Size(476, 491);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 396);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Leave += new System.EventHandler(this.tabControl1_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.PartialCheck);
            this.tabPage1.Controls.Add(this.TablesGrid);
            this.tabPage1.Controls.Add(this.UniqueCheck);
            this.tabPage1.Controls.Add(this.TablesComboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtIndexName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Index";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(17, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(412, 87);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // PartialCheck
            // 
            this.PartialCheck.AutoSize = true;
            this.PartialCheck.Location = new System.Drawing.Point(17, 213);
            this.PartialCheck.Name = "PartialCheck";
            this.PartialCheck.Size = new System.Drawing.Size(170, 21);
            this.PartialCheck.TabIndex = 6;
            this.PartialCheck.Text = "Partial Index Condition";
            this.PartialCheck.UseVisualStyleBackColor = true;
            this.PartialCheck.CheckedChanged += new System.EventHandler(this.PartialCheck_CheckedChanged);
            // 
            // TablesGrid
            // 
            this.TablesGrid.AllowUserToAddRows = false;
            this.TablesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.TablesGrid.GridColor = System.Drawing.SystemColors.Control;
            this.TablesGrid.Location = new System.Drawing.Point(17, 107);
            this.TablesGrid.Name = "TablesGrid";
            this.TablesGrid.RowTemplate.Height = 24;
            this.TablesGrid.Size = new System.Drawing.Size(412, 100);
            this.TablesGrid.TabIndex = 5;
            this.TablesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablesGrid_CellClick);
            this.TablesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablesGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Collation";
            this.Column2.Items.AddRange(new object[] {
            "BINARY",
            "NOCASE",
            "RTIM"});
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sort";
            this.Column3.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.Column3.Name = "Column3";
            // 
            // UniqueCheck
            // 
            this.UniqueCheck.AutoSize = true;
            this.UniqueCheck.Location = new System.Drawing.Point(17, 79);
            this.UniqueCheck.Name = "UniqueCheck";
            this.UniqueCheck.Size = new System.Drawing.Size(75, 21);
            this.UniqueCheck.TabIndex = 4;
            this.UniqueCheck.Text = "Unique";
            this.UniqueCheck.UseVisualStyleBackColor = true;
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.CausesValidation = false;
            this.TablesComboBox.Enabled = false;
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(140, 36);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(289, 24);
            this.TablesComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "On table";
            // 
            // txtIndexName
            // 
            this.txtIndexName.Location = new System.Drawing.Point(140, 7);
            this.txtIndexName.Name = "txtIndexName";
            this.txtIndexName.Size = new System.Drawing.Size(289, 22);
            this.txtIndexName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GeneratedSQL);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GeneratedSQL
            // 
            this.GeneratedSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedSQL.Location = new System.Drawing.Point(3, 3);
            this.GeneratedSQL.Name = "GeneratedSQL";
            this.GeneratedSQL.Size = new System.Drawing.Size(462, 361);
            this.GeneratedSQL.TabIndex = 0;
            this.GeneratedSQL.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(120, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(21, 25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 34);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // CreateIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 491);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(494, 538);
            this.MinimumSize = new System.Drawing.Size(494, 538);
            this.Name = "CreateIndexForm";
            this.Text = "Create Index";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox PartialCheck;
        private System.Windows.Forms.DataGridView TablesGrid;
        private System.Windows.Forms.CheckBox UniqueCheck;
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndexName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox GeneratedSQL;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}