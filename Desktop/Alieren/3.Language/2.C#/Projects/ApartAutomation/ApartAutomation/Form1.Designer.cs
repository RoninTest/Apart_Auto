
namespace ApartAutomation
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
            this.btnRevenues = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRevenues
            // 
            this.btnRevenues.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenues.Location = new System.Drawing.Point(176, 33);
            this.btnRevenues.Name = "btnRevenues";
            this.btnRevenues.Size = new System.Drawing.Size(157, 347);
            this.btnRevenues.TabIndex = 0;
            this.btnRevenues.Text = "Revenues";
            this.btnRevenues.UseVisualStyleBackColor = true;
            this.btnRevenues.Click += new System.EventHandler(this.btnRevenues_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Location = new System.Drawing.Point(459, 33);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(157, 347);
            this.btnExpenses.TabIndex = 1;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnRevenues);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevenues;
        private System.Windows.Forms.Button btnExpenses;
    }
}

