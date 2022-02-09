using SwissTransport.Core;
using SwissTransport.Models;
using System.Runtime;

namespace SBBLite.View
{
    public partial class SearchStation : Form
    {
        public SearchStation()
        {
            InitializeComponent();
        }

        // Search Stations whitch are similare to the text of the Combobox.
        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string searchedStation = cbxSearchedStation.Text;
                ITransport transport = new Transport();

                Stations stations = transport.GetStations(searchedStation);

                dgvStations.Rows.Clear();

                // Checks if the list of Stations is empty, if so it adds a row to the datagridview
                // To inform the user.
                if (stations.StationList.Where(x => x.Id != null).ToList().Count == 0)
                    dgvStations.Rows.Add("Keine Resultate Gefunden");

                // Adds all found stations to the datagridview.
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

        // Switches to the SearchConnection view.
        private void btnTapSearchConnection_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form searchConnection = new SearchConnection();
            searchConnection.Closed += (s, args) => this.Close();
            searchConnection.Show();
        }

        // Switches to the Map view.
        private void btnTabMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        // Switches to the StationInformation view with the name and id of the selected station.
        private void dgvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                DataGridViewSelectedCellCollection selectedCells = dgvStations.SelectedCells;

                if (string.IsNullOrEmpty(selectedCells[0].FormattedValue.ToString()) || string.IsNullOrEmpty(selectedCells[1].FormattedValue.ToString()))
                    throw new ArgumentNullException("arg");

                Form stationInfomration = new StationInformation(selectedCells[0].FormattedValue.ToString(), selectedCells[1].FormattedValue.ToString());
                stationInfomration.Closed += (s, args) => this.Close();
                stationInfomration.Show();

            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Ungültige auswahl\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ein unbekannter Fehler ist aufgetreten\n" + ex.Message);
            }


        }

        // Start the Search method as soon as the ENTER key in the combobox is pressed.
        private void cbxSearchedStation_KeyPress(object sender, KeyPressEventArgs e)
        {

            // KeyChar 13 = ENTER 
            if (e.KeyChar == 13)
                btnSearch_Click(sender, e);

        }
    }
}
