using SBBLite.View;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class SearchConnection : Form
    {
        public SearchConnection()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromStation = tbxStationFrom.Text;
            string toStation = tbxStationTo.Text;

            ITransport transport = new Transport();
            Connections connections = transport.GetConnections(fromStation, toStation);


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
    }
}