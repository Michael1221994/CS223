namespace Assignment4_InventoryProject
{
    partial class displayall
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
            this.dataGrid_displayall = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_displayall)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_displayall
            // 
            this.dataGrid_displayall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_displayall.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_displayall.Name = "dataGrid_displayall";
            this.dataGrid_displayall.RowHeadersWidth = 51;
            this.dataGrid_displayall.RowTemplate.Height = 24;
            this.dataGrid_displayall.Size = new System.Drawing.Size(776, 426);
            this.dataGrid_displayall.TabIndex = 0;
            this.dataGrid_displayall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_displayall_CellContentClick);
            // 
            // displayall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_displayall);
            this.Name = "displayall";
            this.Text = "displayall";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_displayall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_displayall;
    }
}