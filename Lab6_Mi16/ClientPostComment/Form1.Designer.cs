﻿namespace ClientPostComment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgp = new System.Windows.Forms.DataGridView();
            this.dgc = new System.Windows.Forms.DataGridView();
            this.bazaDeDateDataSet = new ClientPostComment.BazaDeDateDataSet();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new ClientPostComment.BazaDeDateDataSetTableAdapters.PostsTableAdapter();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDeDateDataSet1 = new ClientPostComment.BazaDeDateDataSet1();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new ClientPostComment.BazaDeDateDataSet1TableAdapters.CommentsTableAdapter();
            this.commentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postPostIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgp
            // 
            this.dgp.AutoGenerateColumns = false;
            this.dgp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.domainDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgp.DataSource = this.postsBindingSource;
            this.dgp.Location = new System.Drawing.Point(0, 0);
            this.dgp.Name = "dgp";
            this.dgp.Size = new System.Drawing.Size(477, 150);
            this.dgp.TabIndex = 0;
            this.dgp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgc
            // 
            this.dgc.AutoGenerateColumns = false;
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.postPostIdDataGridViewTextBoxColumn});
            this.dgc.DataSource = this.commentsBindingSource;
            this.dgc.Location = new System.Drawing.Point(0, 220);
            this.dgc.Name = "dgc";
            this.dgc.Size = new System.Drawing.Size(477, 150);
            this.dgc.TabIndex = 1;
            // 
            // bazaDeDateDataSet
            // 
            this.bazaDeDateDataSet.DataSetName = "BazaDeDateDataSet";
            this.bazaDeDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.bazaDeDateDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // domainDataGridViewTextBoxColumn
            // 
            this.domainDataGridViewTextBoxColumn.DataPropertyName = "Domain";
            this.domainDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // postsBindingSource1
            // 
            this.postsBindingSource1.DataMember = "Posts";
            this.postsBindingSource1.DataSource = this.bazaDeDateDataSet;
            // 
            // bazaDeDateDataSet1
            // 
            this.bazaDeDateDataSet1.DataSetName = "BazaDeDateDataSet1";
            this.bazaDeDateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.bazaDeDateDataSet1;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // commentIdDataGridViewTextBoxColumn
            // 
            this.commentIdDataGridViewTextBoxColumn.DataPropertyName = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.HeaderText = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.Name = "commentIdDataGridViewTextBoxColumn";
            this.commentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // postPostIdDataGridViewTextBoxColumn
            // 
            this.postPostIdDataGridViewTextBoxColumn.DataPropertyName = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.HeaderText = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.Name = "postPostIdDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgc);
            this.Controls.Add(this.dgp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgp;
        private System.Windows.Forms.DataGridView dgc;
        private BazaDeDateDataSet bazaDeDateDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private BazaDeDateDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postsBindingSource1;
        private BazaDeDateDataSet1 bazaDeDateDataSet1;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private BazaDeDateDataSet1TableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postPostIdDataGridViewTextBoxColumn;
    }
}

