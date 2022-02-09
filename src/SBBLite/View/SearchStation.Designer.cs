namespace SBBLite.View
{
    partial class SearchStation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTapSearchConnection = new System.Windows.Forms.Button();
            this.btnTabMap = new System.Windows.Forms.Button();
            this.btnTabSearchStation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSearchedStation = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.64261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.35739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel1.Controls.Add(this.btnTapSearchConnection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTabMap, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTabSearchStation, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 39);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnTapSearchConnection
            // 
            this.btnTapSearchConnection.BackColor = System.Drawing.SystemColors.Control;
            this.btnTapSearchConnection.Location = new System.Drawing.Point(133, 6);
            this.btnTapSearchConnection.Name = "btnTapSearchConnection";
            this.btnTapSearchConnection.Size = new System.Drawing.Size(153, 29);
            this.btnTapSearchConnection.TabIndex = 0;
            this.btnTapSearchConnection.Text = "Verindungen suchen";
            this.btnTapSearchConnection.UseVisualStyleBackColor = false;
            this.btnTapSearchConnection.Click += new System.EventHandler(this.btnTapSearchConnection_Click);
            // 
            // btnTabMap
            // 
            this.btnTabMap.Location = new System.Drawing.Point(297, 6);
            this.btnTabMap.Name = "btnTabMap";
            this.btnTabMap.Size = new System.Drawing.Size(84, 29);
            this.btnTabMap.TabIndex = 2;
            this.btnTabMap.Text = "Map";
            this.btnTabMap.UseVisualStyleBackColor = true;
            this.btnTabMap.Click += new System.EventHandler(this.btnTabMap_Click);
            // 
            // btnTabSearchStation
            // 
            this.btnTabSearchStation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTabSearchStation.Location = new System.Drawing.Point(6, 6);
            this.btnTabSearchStation.Name = "btnTabSearchStation";
            this.btnTabSearchStation.Size = new System.Drawing.Size(118, 29);
            this.btnTabSearchStation.TabIndex = 1;
            this.btnTabSearchStation.Text = "Station suchen";
            this.btnTabSearchStation.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStations);
            this.groupBox2.Location = new System.Drawing.Point(35, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 252);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gefundene Ergebnisse";
            // 
            // dgvStations
            // 
            this.dgvStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStations.ColumnHeadersVisible = false;
            this.dgvStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.StationID});
            this.dgvStations.Location = new System.Drawing.Point(32, 35);
            this.dgvStations.MultiSelect = false;
            this.dgvStations.Name = "dgvStations";
            this.dgvStations.ReadOnly = true;
            this.dgvStations.RowHeadersVisible = false;
            this.dgvStations.RowHeadersWidth = 51;
            this.dgvStations.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStations.RowTemplate.Height = 29;
            this.dgvStations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(672, 211);
            this.dgvStations.TabIndex = 0;
            this.dgvStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStations_CellContentClick);
            // 
            // StationName
            // 
            this.StationName.HeaderText = "";
            this.StationName.MinimumWidth = 6;
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // StationID
            // 
            this.StationID.HeaderText = "";
            this.StationID.MinimumWidth = 6;
            this.StationID.Name = "StationID";
            this.StationID.ReadOnly = true;
            this.StationID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSearchedStation);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(35, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station suchen";
            // 
            // cbxSearchedStation
            // 
            this.cbxSearchedStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxSearchedStation.Location = new System.Drawing.Point(32, 52);
            this.cbxSearchedStation.Name = "cbxSearchedStation";
            this.cbxSearchedStation.Size = new System.Drawing.Size(483, 28);
            this.cbxSearchedStation.TabIndex = 6;
            this.cbxSearchedStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSearchedStation_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(551, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchStation
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchStation";
            this.Text = "SearchStation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTapSearchConnection;
        private Button btnTabMap;
        private Button btnTabSearchStation;
        private GroupBox groupBox2;
        private DataGridView dgvStations;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn StationName;
        private DataGridViewTextBoxColumn StationID;
        private ComboBox cbxSearchedStation;
    }
}