using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBLite.View
{
    public partial class StationInformation : Form
    {
        // Gets all entries from stationboard, transforms them into a connection
        // And displays them.
        public StationInformation(string stationName, string stationId)
        {

            InitializeComponent();

            lblStationName.Text = stationName;

            try
            {
                ITransport transport = new Transport();
                StationBoardRoot stationBoardRoot = transport.GetStationBoard(stationName, stationId);
                Connections connections;
                Connection connection;

                // Gets for each Stationboard without dublicates the amount of dublications
                // And gets this amount of connections.
                foreach (StationBoard stationBoard in stationBoardRoot.Entries.Distinct())
                {

                    connections = transport.GetConnections(stationName, stationBoard.To);
                    for (int i = 0; i < stationBoardRoot.Entries.Where(x => x.Name == stationBoard.Name).ToList().Count(); i++)
                    {

                        connection = connections.ConnectionList[i];

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein unerwarteter Fehler ist aufgetreten" + ex.Message);
            }

            // Sorts the list by the time ascending.
            dgvConnections.Sort(dgvConnections.Columns[0], ListSortDirection.Ascending);

        }
    }
}
