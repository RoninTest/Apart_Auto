
namespace ApartAutomation
{
    partial class Revenues
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
            this.lblFloorNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ComboBox_FloorNo = new System.Windows.Forms.ComboBox();
            this.nUD_Price = new System.Windows.Forms.NumericUpDown();
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.AutoSize = true;
            this.lblFloorNo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNo.Location = new System.Drawing.Point(6, 25);
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(95, 25);
            this.lblFloorNo.TabIndex = 0;
            this.lblFloorNo.Text = "Floor No";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 25);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // ComboBox_FloorNo
            // 
            this.ComboBox_FloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_FloorNo.FormattingEnabled = true;
            this.ComboBox_FloorNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBox_FloorNo.Location = new System.Drawing.Point(101, 25);
            this.ComboBox_FloorNo.Name = "ComboBox_FloorNo";
            this.ComboBox_FloorNo.Size = new System.Drawing.Size(64, 33);
            this.ComboBox_FloorNo.TabIndex = 3;
            // 
            // nUD_Price
            // 
            this.nUD_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Price.Location = new System.Drawing.Point(101, 86);
            this.nUD_Price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_Price.Name = "nUD_Price";
            this.nUD_Price.Size = new System.Drawing.Size(169, 31);
            this.nUD_Price.TabIndex = 4;
            // 
            // dTP_Date
            // 
            this.dTP_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_Date.Location = new System.Drawing.Point(101, 144);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(275, 29);
            this.dTP_Date.TabIndex = 5;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(132, 201);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(164, 32);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFloorNo);
            this.groupBox1.Controls.Add(this.btn_Register);
            this.groupBox1.Controls.Add(this.ComboBox_FloorNo);
            this.groupBox1.Controls.Add(this.dTP_Date);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.nUD_Price);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ControlPanel";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 291);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 251);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(201, 291);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 251);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(406, 291);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(147, 251);
            this.listBox3.TabIndex = 9;
            // 
            // Revenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(577, 557);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Revenues";
            this.Text = "Revenues";
            this.Load += new System.EventHandler(this.Revenues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox ComboBox_FloorNo;
        private System.Windows.Forms.NumericUpDown nUD_Price;
        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}