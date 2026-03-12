
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAILWAY_GUI
{
    public partial class Form1 : Form
    {
        // Global train list and totals (shared with Form2)
        public static List<Train> trains = new List<Train>();
        public static int grandTotalTickets = 0;
        public static int grandTotalAmount = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTrains();
        }

        private void InitializeTrains()
        {
            // Create 10 trains with destinations (matches your original list)
            string[] destinations = { "Karachi", "Lahore", "Islamabad", "Quetta", "Peshawar", "Multan", "Faisalabad", "Sukkur", "Rawalpindi", "Sialkot" };
            for (int i = 0; i < 10; i++)
            {
                trains.Add(new Train("Train-" + (i + 1), destinations[i]));
            }
        }

        // Display Trains button (assuming designer's Display Trains button is named "button1")
        private void button1_Click(object sender, EventArgs e)
        {
            if (trains.Count == 0)
            {
                MessageBox.Show("No trains available.", "Trains");
                return;
            }

            string message = "Train No\tTrain Name\tDestination\n";
            message += "------------------------------------------\n";
            for (int i = 0; i < trains.Count; i++)
            {
                message += $"{i + 1}\t{trains[i].Name}\t{trains[i].Destination}\n";
            }
            MessageBox.Show(message, "Available Trains");
        }

        // Book Ticket button - opens Form2
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 bookingForm = new Form2();
                bookingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open booking form: " + ex.Message);
            }
        }

        // View Total Bill button
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            string bill = $"Total Tickets Booked: {grandTotalTickets}\n" +
                          $"Total Amount to Pay: Rs {grandTotalAmount}";
            MessageBox.Show(bill, "Total Bill");
        }

        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // --- Train system classes (shared) ---
    public class Seat
    {
        public bool IsBooked { get; set; } = false;
        public string PassengerName { get; set; } = "";
    }

    public class Compartment
    {
        public List<Seat> Seats { get; set; }
        public Compartment()
        {
            Seats = new List<Seat>();
            for (int i = 0; i < 6; i++) Seats.Add(new Seat());
        }
    }

    public class TrainClass
    {
        public string ClassType { get; set; }
        public int Price { get; set; }
        public List<Compartment> Compartments { get; set; }
        public TrainClass(string type, int price)
        {
            ClassType = type;
            Price = price;
            Compartments = new List<Compartment>();
            for (int i = 0; i < 10; i++) Compartments.Add(new Compartment());
        }
    }

    public class Train
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public TrainClass BusinessClass { get; set; }
        public TrainClass EconomyClass { get; set; }
        public Train(string name, string destination)
        {
            Name = name;
            Destination = destination;
            BusinessClass = new TrainClass("Business", 10000);
            EconomyClass = new TrainClass("Economy", 5000);
        }
    }
}
