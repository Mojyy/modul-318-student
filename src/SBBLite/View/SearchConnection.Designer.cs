using SwissTransport.Core;

namespace SBBLite
{
    partial class SearchConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxStationTo = new System.Windows.Forms.ComboBox();
            this.cbxStationFrom = new System.Windows.Forms.ComboBox();
            this.dtpSearchTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.DepartureArivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureArivalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureArivalPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendViaMail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTapSearchConnection = new System.Windows.Forms.Button();
            this.btnTabMap = new System.Windows.Forms.Button();
            this.btnTabSearchStation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxStationTo);
            this.groupBox1.Controls.Add(this.cbxStationFrom);
            this.groupBox1.Controls.Add(this.dtpSearchTime);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSearchDate);
            this.groupBox1.Location = new System.Drawing.Point(34, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindung suchen";
            // 
            // cbxStationTo
            // 
            this.cbxStationTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStationTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxStationTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxStationTo.Location = new System.Drawing.Point(32, 108);
            this.cbxStationTo.Name = "cbxStationTo";
            this.cbxStationTo.Size = new System.Drawing.Size(279, 28);
            this.cbxStationTo.TabIndex = 5;
            this.cbxStationTo.TextChanged += new System.EventHandler(this.cbxStationTo_TextChanged);
            // 
            // cbxStationFrom
            // 
            this.cbxStationFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStationFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxStationFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxStationFrom.Location = new System.Drawing.Point(32, 51);
            this.cbxStationFrom.Name = "cbxStationFrom";
            this.cbxStationFrom.Size = new System.Drawing.Size(279, 28);
            this.cbxStationFrom.TabIndex = 4;
            this.cbxStationFrom.TextChanged += new System.EventHandler(this.cbxStationFrom_TextChanged);
            // 
            // dtpSearchTime
            // 
            this.dtpSearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSearchTime.Location = new System.Drawing.Point(521, 52);
            this.dtpSearchTime.Name = "dtpSearchTime";
            this.dtpSearchTime.Size = new System.Drawing.Size(175, 27);
            this.dtpSearchTime.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Datum und Uhrzeit";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDate.Location = new System.Drawing.Point(347, 52);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(168, 27);
            this.dtpSearchDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvConnections);
            this.groupBox2.Location = new System.Drawing.Point(34, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gefundene Ergebnisse";
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
            this.DepartureArivalPlatform,
            this.btnSendViaMail});
            this.dgvConnections.Location = new System.Drawing.Point(32, 42);
            this.dgvConnections.MultiSelect = false;
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersVisible = false;
            this.dgvConnections.RowHeadersWidth = 51;
            this.dgvConnections.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnections.RowTemplate.Height = 29;
            this.dgvConnections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnections.Size = new System.Drawing.Size(664, 174);
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
            // btnSendViaMail
            // 
            this.btnSendViaMail.HeaderText = "Send Mail";
            this.btnSendViaMail.MinimumWidth = 6;
            this.btnSendViaMail.Name = "btnSendViaMail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.63918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.36082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel1.Controls.Add(this.btnTapSearchConnection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTabMap, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTabSearchStation, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnTapSearchConnection
            // 
            this.btnTapSearchConnection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTapSearchConnection.Location = new System.Drawing.Point(6, 6);
            this.btnTapSearchConnection.Name = "btnTapSearchConnection";
            this.btnTapSearchConnection.Size = new System.Drawing.Size(150, 29);
            this.btnTapSearchConnection.TabIndex = 0;
            this.btnTapSearchConnection.Text = "Verindungen suchen";
            this.btnTapSearchConnection.UseVisualStyleBackColor = false;
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
            this.btnTabSearchStation.Location = new System.Drawing.Point(165, 6);
            this.btnTabSearchStation.Name = "btnTabSearchStation";
            this.btnTabSearchStation.Size = new System.Drawing.Size(123, 29);
            this.btnTabSearchStation.TabIndex = 1;
            this.btnTabSearchStation.Text = "Station suchen";
            this.btnTabSearchStation.UseVisualStyleBackColor = true;
            this.btnTabSearchStation.Click += new System.EventHandler(this.btnTabSearchStation_Click);
            // 
            // SearchConnection
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchConnection";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label3;
        private DateTimePicker dtpSearchDate;
        private GroupBox groupBox2;
        private DataGridView dgvConnections;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTapSearchConnection;
        private Button btnTabSearchStation;
        private Button btnTabMap;
        private DateTimePicker dtpSearchTime;
        private ComboBox cbxStationFrom;
        private ComboBox cbxStationTo;
        private DataGridViewTextBoxColumn DepartureArivalTime;
        private DataGridViewTextBoxColumn DepartureArivalName;
        private DataGridViewTextBoxColumn DepartureArivalPlatform;
        private DataGridViewButtonColumn btnSendViaMail;
    }
}