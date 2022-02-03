﻿using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite.View
{
    public partial class SearchStation : Form
    {
        public SearchStation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedStation = tbxStation.Text;
            ITransport transport = new Transport();

            Stations stations = transport.GetStations(searchedStation);

            dgvStations.Rows.Clear();
            foreach (Station station in stations.StationList.Where(x => x.Id != null))
            {
                dgvStations.Rows.Add
                    (
                        station.Name,
                        station.Id
                    );
            }

        }

        private void btnTapSearchConnection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form searchConnection = new SearchConnection();
            searchConnection.Closed += (s, args) => this.Close();
            searchConnection.Show();
        }

        private void btnTabMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        private void dgvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dgvStations.SelectedCells;
            Form stationInfomration = new StationInformation(selectedCells[0].FormattedValue.ToString(), selectedCells[1].FormattedValue.ToString());
            stationInfomration.Closed += (s, args) => this.Close();
            stationInfomration.Show();
        }
    }
}
