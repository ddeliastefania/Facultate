namespace FormProiect2020
{
    partial class SpecialPropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataID = new System.Windows.Forms.TextBox();
            this.propertyName = new System.Windows.Forms.TextBox();
            this.propertyDescription = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.propertyID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Property Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "DataID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataID
            // 
            this.dataID.Location = new System.Drawing.Point(196, 12);
            this.dataID.Multiline = true;
            this.dataID.Name = "dataID";
            this.dataID.Size = new System.Drawing.Size(138, 30);
            this.dataID.TabIndex = 3;
            // 
            // propertyName
            // 
            this.propertyName.Location = new System.Drawing.Point(196, 48);
            this.propertyName.Multiline = true;
            this.propertyName.Name = "propertyName";
            this.propertyName.Size = new System.Drawing.Size(138, 30);
            this.propertyName.TabIndex = 4;
            // 
            // propertyDescription
            // 
            this.propertyDescription.Location = new System.Drawing.Point(196, 91);
            this.propertyDescription.Multiline = true;
            this.propertyDescription.Name = "propertyDescription";
            this.propertyDescription.Size = new System.Drawing.Size(138, 30);
            this.propertyDescription.TabIndex = 5;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(210, 134);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(104, 41);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(514, 55);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 41);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(50, 134);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 41);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // propertyID
            // 
            this.propertyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyID.Location = new System.Drawing.Point(366, 9);
            this.propertyID.Name = "propertyID";
            this.propertyID.Size = new System.Drawing.Size(108, 30);
            this.propertyID.TabIndex = 10;
            this.propertyID.Text = "PropertyID:";
            this.propertyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 30);
            this.textBox1.TabIndex = 11;
            // 
            // SpecialPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 198);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.propertyID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.create);
            this.Controls.Add(this.propertyDescription);
            this.Controls.Add(this.propertyName);
            this.Controls.Add(this.dataID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpecialPropertiesForm";
            this.Text = "SpecialProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataID;
        private System.Windows.Forms.TextBox propertyName;
        private System.Windows.Forms.TextBox propertyDescription;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label propertyID;
        private System.Windows.Forms.TextBox textBox1;
    }
}