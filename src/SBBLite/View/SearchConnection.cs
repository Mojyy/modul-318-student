using SBBLite.View;
using SwissTransport.Core;
using SwissTransport.Models;
//using Microsoft.Office.Interop.Outlook;
//using Application = Microsoft.Office.Interop.Outlook.Application;
//using Microsoft.Win32;

namespace SBBLite
{
    public partial class SearchConnection : Form
    {
        // List of AutoCompleteSuggestions.
        public AutoCompleteStringCollection autoCompleteSourceFrom = new AutoCompleteStringCollection();
        public AutoCompleteStringCollection autoCompleteSourceTo = new AutoCompleteStringCollection();

        public SearchConnection()
        {

            InitializeComponent();
            cbxStationFrom.AutoCompleteCustomSource = autoCompleteSourceFrom;
            cbxStationTo.AutoCompleteCustomSource = autoCompleteSourceTo;

        }

        // Gets four connections, with the given userinput from the two comboboxes,
        // And puts them in the dategridview.
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string fromStation = cbxStationFrom.Text;
            string toStation = cbxStationTo.Text;
            string date = dtpSearchDate.Text;
            string time = dtpSearchTime.Text;

            try
            {
                ITransport transport = new Transport();
                Connections connections = transport.GetConnections(fromStation, toStation, date, time);

                dgvConnections.Rows.Clear();

                // Checks if the list of connections is empty, if so it adds a row to the
                // Datagridview to inform the user.
                if (connections.ConnectionList.Count == 0)
                    dgvConnections.Rows.Add("Keine Resultate Gefunden");

                // Adds all connections to the datagrid view.
                foreach (Connection connection in connections.ConnectionList)
                {

                    dgvConnections.Rows.Add
                        (
                        $"{connection.From.Departure.Value.ToString("HH:mm")}\n" +
                        $"{connection.To.Arrival.Value.ToString("HH:mm")}",

                        $"{connection.From.Station.Name}\n" +
                        $"{connection.To.Station.Name}",

                        $"Gleis:  {connection.From.Platform}\n" +
                        $"Gleis:  {connection.To.Platform}"
                        );

                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Die Eingaben dürfen nicht Lehr sein \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Unbekannter Fehler ist aufgetreten\n" + ex.Message);
            }
        }

        // Switches to the view SearchStation.
        private void btnTabSearchStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form searchStation = new SearchStation();
            searchStation.Closed += (s, args) => this.Close();
            searchStation.Show();
        }

        // Switches to the view Map.
        private void btnTabMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form map = new Map();
            map.Closed += (s, args) => this.Close();
            map.Show();
        }

        // Shows Autocomplete suggestions.
        private void cbxStationFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Due to bad performance the Autocomplete only updates if the text is longer than three
                // And the amount of chars in the text is a even number.
                if (cbxStationFrom.Text.Length > 3 && cbxStationFrom.Text.Length % 2 == 0)
                {

                    string[] suggestedStations = new Transport().
                        GetStations(cbxStationFrom.Text).StationList.
                        Select(x => x.Name).Take(5).
                        ToArray();

                    autoCompleteSourceFrom.AddRange(suggestedStations);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten" + ex.Message);
            }
        }

        // Shows autocomplete suggestions
        private void cbxStationTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Due to bad performance the Autocomplete only updates if the text is longer than three
                // And the amount of chars in the text is a even number.
                if (cbxStationTo.Text.Length > 3 && cbxStationTo.Text.Length % 2 == 0)
                {

                    string[] suggestedStations = new Transport()
                        .GetStations(cbxStationTo.Text)
                        .StationList.Select(x => x.Name)
                        .Take(5)
                        .ToArray();

                    autoCompleteSourceTo.AddRange(suggestedStations);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten" + ex.Message);
            }
        }

        // Startet inplemementing a function to send emails with the outlook api
        // Due to problems and time struggle this isnt finished yet.
        private void SearchConnection_Load(object sender, EventArgs e)
        {

        }

        //        private void dgvConnections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            Registry.GetValue("Computer\\HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Office" );
        //            CreateMailItem();

        //        }
        //        private void CreateMailItem()
        //        {
        //            var application = new Application();
        //            MailItem mailItem = (MailItem)application.CreateItem(OlItemType.olMailItem);
        //            mailItem.Subject = "This is the subject";
        //            mailItem.To = "someone@example.com";
        //            mailItem.Body = "This is the message.";
        //            mailItem.Importance = OlImportance.olImportanceLow;
        //            mailItem.Display(false);
        //        }

    }
}