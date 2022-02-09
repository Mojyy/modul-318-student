using SwissTransport.Core;
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
            try
            {
                string searchedStation = cbxSearchedStation.Text;
                ITransport transport = new Transport();

                Stations stations = transport.GetStations(searchedStation);

                dgvStations.Rows.Clear();

                if (stations.StationList.Where(x => x.Id != null).ToList().Count == 0)
                    dgvStations.Rows.Add("Keine Resultate Gefunden");

                foreach (Station station in stations.StationList.Where(x => x.Id != null))
                {
                    dgvStations.Rows.Add
                        (
                            station.Name,
                            station.Id
                        );
                }
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Die eingabe darf nicht lehr sein\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein unbekannter Fehler ist aufgetreten\n" + ex.Message);
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
            try
            {
                DataGridViewSelectedCellCollection selectedCells = dgvStations.SelectedCells;
                Form stationInfomration = new StationInformation(selectedCells[0].FormattedValue.ToString(), selectedCells[1].FormattedValue.ToString());
                stationInfomration.Closed += (s, args) => this.Close();
                stationInfomration.Show();
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Ungültige auswahl\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein unbekannter Fehler ist aufgetreten\n" + ex.Message);
            }
        }

        private void cbxSearchedStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSearch_Click(sender, e);
        }
    }
}
