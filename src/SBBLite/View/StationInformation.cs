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
        public StationInformation(string stationName, string stationId)
        {
            InitializeComponent();

            ITransport transport = new Transport();
            StationBoardRoot stationBoardRoot = transport.GetStationBoard(stationName, stationId);
            Connection connection;

            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                connection = transport.GetConnections(stationName, stationBoard.To).ConnectionList.First();
                
                    dgvConnections.Rows.Add
                        (
                        $"{connection.From.Departure.Value.ToString("HH:mm")}\n{connection.To.Arrival.Value.ToString("HH:mm")}",
                        $"{connection.From.Station.Name}\n{connection.To.Station.Name}",
                        $"Gleis:  {connection.From.Platform}\nGleis:  {connection.To.Platform}"
                        );
                
            }
            dgvConnections.Sort(dgvConnections.Columns[0], ListSortDirection.Ascending);
        }
    }
}
