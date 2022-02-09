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
        AutoCompleteStringCollection autoCompleteSourceFrom = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoCompleteSourceTo = new AutoCompleteStringCollection();
        public SearchConnection()
        {
            InitializeComponent();
            cbxStationFrom.AutoCompleteCustomSource = autoCompleteSourceFrom;
            cbxStationTo.AutoCompleteCustomSource = autoCompleteSourceTo;
        }

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

                if (connections.ConnectionList.Count == 0)
                    dgvConnections.Rows.Add("Keine Resultate Gefunden");

                foreach (Connection connection in connections.ConnectionList)
                {
                    dgvConnections.Rows.Add
                        (
                        $"{connection.From.Departure.Value.ToString("HH:mm")}\n{connection.To.Arrival.Value.ToString("HH:mm")}",
                        $"{connection.From.Station.Name}\n{connection.To.Station.Name}",
                        $"Gleis:  {connection.From.Platform}\nGleis:  {connection.To.Platform}"
                        );
                }
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Die Eingaben dürfen nicht Lehr sein \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Unbekannter Fehler ist aufgetreten\n" + ex.Message);
            }
        }

            private void btnTabSearchStation_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form searchStation = new SearchStation();
                searchStation.Closed += (s, args) => this.Close();
                searchStation.Show();
            }

            private void btnTabMap_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form map = new Map();
                map.Closed += (s, args) => this.Close();
                map.Show();
            }

            private void cbxStationFrom_TextChanged(object sender, EventArgs e)
            {
                if (cbxStationFrom.Text.Length > 3 && cbxStationFrom.Text.Length % 2 == 0)
                {
                    string[] suggestedStations = new Transport().GetStations(cbxStationFrom.Text).StationList.Select(x => x.Name).Take(5).ToArray();
                    autoCompleteSourceFrom.AddRange(suggestedStations);
                }
            }

            private void cbxStationTo_TextChanged(object sender, EventArgs e)
            {
                if (cbxStationTo.Text.Length > 3 && cbxStationTo.Text.Length % 2 == 0)
                {
                    string[] suggestedStations = new Transport().GetStations(cbxStationTo.Text).StationList.Select(x => x.Name).Take(5).ToArray();
                    autoCompleteSourceTo.AddRange(suggestedStations);

                }
            }

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