namespace FormProiect2020
{
    partial class DataForm
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
            this.Submit = new System.Windows.Forms.Button();
            this.creationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datatype = new System.Windows.Forms.ComboBox();
            this.eventname = new System.Windows.Forms.TextBox();
            this.people = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.masterDataSet1 = new FormProiect2020.masterDataSet();
            this.dataID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(360, 19);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(104, 41);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Create";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // creationDate
            // 
            this.creationDate.Location = new System.Drawing.Point(126, 75);
            this.creationDate.Multiline = true;
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(207, 27);
            this.creationDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(-2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "DataType:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datatype
            // 
            this.datatype.FormattingEnabled = true;
            this.datatype.Items.AddRange(new object[] {
            "Movie",
            "Image"});
            this.datatype.Location = new System.Drawing.Point(126, 39);
            this.datatype.Name = "datatype";
            this.datatype.Size = new System.Drawing.Size(207, 21);
            this.datatype.TabIndex = 3;
            // 
            // eventname
            // 
            this.eventname.Location = new System.Drawing.Point(126, 123);
            this.eventname.Multiline = true;
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(207, 27);
            this.eventname.TabIndex = 4;
            // 
            // people
            // 
            this.people.Location = new System.Drawing.Point(126, 173);
            this.people.Multiline = true;
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(207, 27);
            this.people.TabIndex = 5;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(126, 229);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(207, 27);
            this.path.TabIndex = 6;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(126, 292);
            this.location.Multiline = true;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(207, 27);
            this.location.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "CreationDate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(-2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "EventName:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "People:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(-2, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Path:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(-2, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Location:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(619, 75);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 41);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(360, 173);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(104, 41);
            this.load.TabIndex = 14;
            this.load.Text = "Load All";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(360, 96);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 41);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataID
            // 
            this.dataID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataID.Location = new System.Drawing.Point(484, 23);
            this.dataID.Name = "dataID";
            this.dataID.Size = new System.Drawing.Size(114, 36);
            this.dataID.TabIndex = 16;
            this.dataID.Text = "DataID:";
            this.dataID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(604, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 35);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.load);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.path);
            this.Controls.Add(this.people);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.datatype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creationDate);
            this.Controls.Add(this.Submit);
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox creationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox datatype;
        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button update;
        private masterDataSet masterDataSet1;
        private System.Windows.Forms.Label dataID;
        private System.Windows.Forms.TextBox textBox1;
    }
}