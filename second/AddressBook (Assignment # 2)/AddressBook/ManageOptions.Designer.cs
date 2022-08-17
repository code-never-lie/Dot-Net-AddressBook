namespace AddressBook
{
    partial class ManageOptions
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
            this.btnManage = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F);
            this.btnManage.Location = new System.Drawing.Point(281, 122);
            this.btnManage.Margin = new System.Windows.Forms.Padding(2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(127, 43);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage Addresses";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F);
            this.btnPrint.Location = new System.Drawing.Point(281, 353);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 43);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print list";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F);
            this.btnSearch.Location = new System.Drawing.Point(281, 239);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 43);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Addresses";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManageOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(759, 501);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnManage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
    }
}