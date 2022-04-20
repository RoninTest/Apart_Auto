
namespace ApartAutomation
{
    partial class Expenses
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
            this.chk_Electric = new System.Windows.Forms.CheckBox();
            this.chk_Water = new System.Windows.Forms.CheckBox();
            this.chk_Lift = new System.Windows.Forms.CheckBox();
            this.chk_Cleaning = new System.Windows.Forms.CheckBox();
            this.lblPricee = new System.Windows.Forms.Label();
            this.lblDatee = new System.Windows.Forms.Label();
            this.dTP_Date = new System.Windows.Forms.DateTimePicker();
            this.nUD_Price = new System.Windows.Forms.NumericUpDown();
            this.btn_Register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Electric
            // 
            this.chk_Electric.AutoSize = true;
            this.chk_Electric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Electric.Location = new System.Drawing.Point(31, 24);
            this.chk_Electric.Name = "chk_Electric";
            this.chk_Electric.Size = new System.Drawing.Size(88, 24);
            this.chk_Electric.TabIndex = 0;
            this.chk_Electric.Text = "Electric";
            this.chk_Electric.UseVisualStyleBackColor = true;
            // 
            // chk_Water
            // 
            this.chk_Water.AutoSize = true;
            this.chk_Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Water.Location = new System.Drawing.Point(31, 54);
            this.chk_Water.Name = "chk_Water";
            this.chk_Water.Size = new System.Drawing.Size(76, 24);
            this.chk_Water.TabIndex = 1;
            this.chk_Water.Text = "Water";
            this.chk_Water.UseVisualStyleBackColor = true;
            // 
            // chk_Lift
            // 
            this.chk_Lift.AutoSize = true;
            this.chk_Lift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Lift.Location = new System.Drawing.Point(31, 84);
            this.chk_Lift.Name = "chk_Lift";
            this.chk_Lift.Size = new System.Drawing.Size(54, 24);
            this.chk_Lift.TabIndex = 2;
            this.chk_Lift.Text = "Lift";
            this.chk_Lift.UseVisualStyleBackColor = true;
            // 
            // chk_Cleaning
            // 
            this.chk_Cleaning.AutoSize = true;
            this.chk_Cleaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Cleaning.Location = new System.Drawing.Point(31, 114);
            this.chk_Cleaning.Name = "chk_Cleaning";
            this.chk_Cleaning.Size = new System.Drawing.Size(98, 24);
            this.chk_Cleaning.TabIndex = 3;
            this.chk_Cleaning.Text = "Cleaning";
            this.chk_Cleaning.UseVisualStyleBackColor = true;
            // 
            // lblPricee
            // 
            this.lblPricee.AutoSize = true;
            this.lblPricee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricee.Location = new System.Drawing.Point(284, 24);
            this.lblPricee.Name = "lblPricee";
            this.lblPricee.Size = new System.Drawing.Size(49, 20);
            this.lblPricee.TabIndex = 5;
            this.lblPricee.Text = "Price";
            // 
            // lblDatee
            // 
            this.lblDatee.AutoSize = true;
            this.lblDatee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatee.Location = new System.Drawing.Point(284, 74);
            this.lblDatee.Name = "lblDatee";
            this.lblDatee.Size = new System.Drawing.Size(48, 20);
            this.lblDatee.TabIndex = 6;
            this.lblDatee.Text = "Date";
            // 
            // dTP_Date
            // 
            this.dTP_Date.Location = new System.Drawing.Point(380, 74);
            this.dTP_Date.Name = "dTP_Date";
            this.dTP_Date.Size = new System.Drawing.Size(200, 21);
            this.dTP_Date.TabIndex = 7;
            // 
            // nUD_Price
            // 
            this.nUD_Price.Location = new System.Drawing.Point(380, 23);
            this.nUD_Price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_Price.Name = "nUD_Price";
            this.nUD_Price.Size = new System.Drawing.Size(200, 21);
            this.nUD_Price.TabIndex = 8;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(380, 129);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(174, 30);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Register);
            this.groupBox1.Controls.Add(this.nUD_Price);
            this.groupBox1.Controls.Add(this.dTP_Date);
            this.groupBox1.Controls.Add(this.lblDatee);
            this.groupBox1.Controls.Add(this.lblPricee);
            this.groupBox1.Controls.Add(this.chk_Cleaning);
            this.groupBox1.Controls.Add(this.chk_Lift);
            this.groupBox1.Controls.Add(this.chk_Water);
            this.groupBox1.Controls.Add(this.chk_Electric);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenses";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(149, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(315, 227);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(477, 227);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 199);
            this.listBox3.TabIndex = 13;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Electric;
        private System.Windows.Forms.CheckBox chk_Water;
        private System.Windows.Forms.CheckBox chk_Lift;
        private System.Windows.Forms.CheckBox chk_Cleaning;
        private System.Windows.Forms.Label lblPricee;
        private System.Windows.Forms.Label lblDatee;
        private System.Windows.Forms.DateTimePicker dTP_Date;
        private System.Windows.Forms.NumericUpDown nUD_Price;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}