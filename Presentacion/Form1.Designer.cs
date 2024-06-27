namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarRegion = new System.Windows.Forms.Button();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.RegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarRegion
            // 
            this.btnListarRegion.Location = new System.Drawing.Point(46, 45);
            this.btnListarRegion.Name = "btnListarRegion";
            this.btnListarRegion.Size = new System.Drawing.Size(94, 29);
            this.btnListarRegion.TabIndex = 0;
            this.btnListarRegion.Text = "Listar";
            this.btnListarRegion.UseVisualStyleBackColor = true;
            this.btnListarRegion.Click += new System.EventHandler(this.btnListarRegion_Click);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegionId,
            this.RegionName,
            this.Enabled});
            this.dgvRegion.Location = new System.Drawing.Point(162, 152);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.RowHeadersWidth = 51;
            this.dgvRegion.RowTemplate.Height = 29;
            this.dgvRegion.Size = new System.Drawing.Size(481, 188);
            this.dgvRegion.TabIndex = 1;
            // 
            // RegionId
            // 
            this.RegionId.DataPropertyName = "RegionId";
            this.RegionId.HeaderText = "RegionId";
            this.RegionId.MinimumWidth = 6;
            this.RegionId.Name = "RegionId";
            this.RegionId.Width = 125;
            // 
            // RegionName
            // 
            this.RegionName.DataPropertyName = "RegionName";
            this.RegionName.HeaderText = "RegionName";
            this.RegionName.MinimumWidth = 6;
            this.RegionName.Name = "RegionName";
            this.RegionName.Width = 125;
            // 
            // Enabled
            // 
            this.Enabled.DataPropertyName = "Enabled";
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.MinimumWidth = 6;
            this.Enabled.Name = "Enabled";
            this.Enabled.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnListarRegion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListarRegion;
        private DataGridView dgvRegion;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn RegionName;
        private DataGridViewTextBoxColumn Enabled;
    }
}