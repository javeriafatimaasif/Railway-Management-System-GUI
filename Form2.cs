using System;
using System.Linq;
using System.Windows.Forms;

namespace RAILWAY_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Wire up button events (designer didn't assign click handlers)
            this.btnBook.Click += btnBook_Click;
            this.btnCancel.Click += btnCancel_Click;

            // Populate controls
            LoadFormData();
        }

        private void LoadFormData()
        {
            // Fill train combo box with names
            cmbTrain.Items.Clear();
            for (int i = 0; i < Form1.trains.Count; i++)
            {
                cmbTrain.Items.Add($"{Form1.trains[i].Name} → {Form1.trains[i].Destination}");
            }
            if (cmbTrain.Items.Count > 0) cmbTrain.SelectedIndex = 0;

            // Fill class combo (Business / Economy)
            cmbClass.Items.Clear();
            cmbClass.Items.Add("Business");
            cmbClass.Items.Add("Economy");
            cmbClass.SelectedIndex = 0;
        }

        // optional empty handlers (designer referenced them)
        private void cmbTrain_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void labelClass_Click(object sender, EventArgs e) { }

        // Book button click - main booking logic
        private void btnBook_Click(object sender, EventArgs e)
        {
            // Validate selected train
            int trainIndex = cmbTrain.SelectedIndex;
            if (trainIndex < 0 || trainIndex >= Form1.trains.Count)
            {
                MessageBox.Show("Please select a train.", "Validation");
                return;
            }
            var selectedTrain = Form1.trains[trainIndex];

            // Determine class object
            string classText = cmbClass.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(classText))
            {
                MessageBox.Show("Please select a class (Business/Economy).", "Validation");
                return;
            }
            var chosenClass = classText == "Business" ? selectedTrain.BusinessClass : selectedTrain.EconomyClass;

            // Compartment validation
            if (!int.TryParse(txtCompartment.Text.Trim(), out int compartmentNum) || compartmentNum < 1 || compartmentNum > chosenClass.Compartments.Count)
            {
                MessageBox.Show($"Please enter a valid compartment number (1 - {chosenClass.Compartments.Count}).", "Validation");
                return;
            }

            var compartment = chosenClass.Compartments[compartmentNum - 1];

            // Seats info
            string seatsText = txtNumSeats.Text.Trim();
            if (!int.TryParse(seatsText, out int seatsToBook) || seatsToBook < 1 || seatsToBook > compartment.Seats.Count)
            {
                MessageBox.Show($"Please enter a valid number of seats (1 - {compartment.Seats.Count}).", "Validation");
                return;
            }

            // Seat numbers and passenger names (comma-separated)
            var seatNumsRaw = txtSeatNumbers.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim()).Where(s => s.Length > 0).ToArray();
            var passengerNames = txtPassengerNames.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim()).Where(s => s.Length > 0).ToArray();

            // If user entered seat numbers, ensure count matches seatsToBook & passenger names match
            if (seatNumsRaw.Length > 0)
            {
                if (seatNumsRaw.Length != seatsToBook)
                {
                    MessageBox.Show("Number of seat numbers provided does not match 'Number of Seats'.", "Validation");
                    return;
                }
            }

            if (passengerNames.Length != seatsToBook)
            {
                MessageBox.Show("Number of passenger names must match number of seats.", "Validation");
                return;
            }

            // Determine seat numbers to book: either user-specified or assign first available seats
            int[] seatNumbersToBook;
            if (seatNumsRaw.Length > 0)
            {
                seatNumbersToBook = new int[seatNumsRaw.Length];
                for (int i = 0; i < seatNumsRaw.Length; i++)
                {
                    if (!int.TryParse(seatNumsRaw[i], out int s) || s < 1 || s > compartment.Seats.Count)
                    {
                        MessageBox.Show($"Invalid seat number: {seatNumsRaw[i]}. Valid seats: 1 - {compartment.Seats.Count}", "Validation");
                        return;
                    }
                    seatNumbersToBook[i] = s;
                }
            }
            else
            {
                // Auto-pick first available seats
                seatNumbersToBook = compartment.Seats
                    .Select((seat, idx) => new { seat, idx })
                    .Where(x => !x.seat.IsBooked)
                    .Take(seatsToBook)
                    .Select(x => x.idx + 1)
                    .ToArray();

                if (seatNumbersToBook.Length != seatsToBook)
                {
                    MessageBox.Show("Not enough available seats in this compartment.", "Validation");
                    return;
                }
            }

            // Check availability for each requested seat
            for (int i = 0; i < seatNumbersToBook.Length; i++)
            {
                int seatNo = seatNumbersToBook[i];
                if (compartment.Seats[seatNo - 1].IsBooked)
                {
                    MessageBox.Show($"Seat {seatNo} is already booked. Try different seats or compartment.", "Validation");
                    return;
                }
            }

            // All checks passed — book seats
            for (int i = 0; i < seatNumbersToBook.Length; i++)
            {
                int seatNo = seatNumbersToBook[i];
                var seat = compartment.Seats[seatNo - 1];
                seat.IsBooked = true;
                seat.PassengerName = passengerNames[i];
                Form1.grandTotalTickets++;
                Form1.grandTotalAmount += chosenClass.Price;
            }

            // Show summary of booking
            string bookedList = "";
            for (int i = 0; i < seatNumbersToBook.Length; i++)
            {
                bookedList += $"Seat {seatNumbersToBook[i]} for {passengerNames[i]}\n";
            }

            MessageBox.Show($"Booking successful!\nTrain: {selectedTrain.Name} → {selectedTrain.Destination}\nClass: {chosenClass.ClassType}\nCompartment: {compartmentNum}\n\n{bookedList}\nTotal amount added: Rs {chosenClass.Price * seatNumbersToBook.Length}", "Booked");

            // Optionally clear inputs or close form — here we close the form returning to Form1
            this.Close();
        }

        // Cancel/back button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
