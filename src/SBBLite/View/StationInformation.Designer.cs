namespace SBBLite.View
{
    partial class StationInformation
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
            this.lblStationName = new System.Windows.Forms.Label();
            this.gbxCurrentConnections = new System.Windows.Forms.GroupBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.DepartureArivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureArivalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureArivalPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCurrentConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(26, 19);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(50, 20);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Text = "label1";
            // 
            // gbxCurrentConnections
            // 
            this.gbxCurrentConnections.Controls.Add(this.dgvConnections);
            this.gbxCurrentConnections.Location = new System.Drawing.Point(26, 162);
            this.gbxCurrentConnections.Name = "gbxCurrentConnections";
            this.gbxCurrentConnections.Size = new System.Drawing.Size(746, 276);
            this.gbxCurrentConnections.TabIndex = 6;
            this.gbxCurrentConnections.TabStop = false;
            this.gbxCurrentConnections.Text = "Aktuelle Verbindungen";
            // 
            // dgvConnections
            // 
            this.dgvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConnections.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvConnections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.ColumnHeadersVisible = false;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureArivalTime,
            this.DepartureArivalName,
            this.DepartureArivalPlatform});
            this.dgvConnections.Location = new System.Drawing.Point(27, 39);
            this.dgvConnections.MultiSelect = false;
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersVisible = false;
            this.dgvConnections.RowHeadersWidth = 51;
            this.dgvConnections.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnections.RowTemplate.Height = 29;
            this.dgvConnections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnections.Size = new System.Drawing.Size(695, 231);
            this.dgvConnections.TabIndex = 0;
            // 
            // DepartureArivalTime
            // 
            this.DepartureArivalTime.HeaderText = "";
            this.DepartureArivalTime.MinimumWidth = 6;
            this.DepartureArivalTime.Name = "DepartureArivalTime";
            // 
            // DepartureArivalName
            // 
            this.DepartureArivalName.HeaderText = "";
            this.DepartureArivalName.MinimumWidth = 6;
            this.DepartureArivalName.Name = "DepartureArivalName";
            // 
            // DepartureArivalPlatform
            // 
            this.DepartureArivalPlatform.HeaderText = "";
            this.DepartureArivalPlatform.MinimumWidth = 6;
            this.DepartureArivalPlatform.Name = "DepartureArivalPlatform";
            // 
            // StationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCurrentConnections);
            this.Controls.Add(this.lblStationName);
            this.Name = "StationInformation";
            this.Text = "StationInformation";
            this.gbxCurrentConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStationName;
        private GroupBox gbxCurrentConnections;
        private DataGridView dgvConnections;
        private DataGridViewTextBoxColumn DepartureArivalTime;
        private DataGridViewTextBoxColumn DepartureArivalName;
        private DataGridViewTextBoxColumn DepartureArivalPlatform;
    }
}