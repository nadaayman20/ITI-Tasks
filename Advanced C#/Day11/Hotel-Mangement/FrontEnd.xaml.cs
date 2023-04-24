
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using Hotel_Mangement_System.Contexts;
using Hotel_Mangement_System.Entitiess;
using Microsoft.VisualBasic;
using Hotel.UI.Report;
using Hotel_Mangement_System.Entities;

namespace Hotel_Mangement_System
{
    /// <summary>
    /// Interaction logic for FrontEnd.xaml
    /// </summary>


    public partial class FrontEnd : Window
    {

        FoodMenu menu;
        FinalizePayment FPayment;
        FrontEndContext FrontDB = new FrontEndContext();
        List<reservation> Lists_of_reservation;
        reservation ReservationData;

        #region start all fields 


        public string towelS, cleaningS, surpriseS;

        private Int32 primartyID = 0;
        private Boolean taskFinder = false;
        private Boolean editClicked = false;

        private int foodBill;
        private int totalAmount = 0;

        // payment
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;



        private int lunch = 0;
        private int breakfast = 0;
        private int dinner = 0;

        private bool cleaning;
        private bool towel;
        private bool surprise;

        private string roomNumber, roomFloor;
        internal object reservations;

        #endregion



        public FrontEnd()
        {
            InitializeComponent();
            ReservationData = new();
            Lists_of_reservation=FrontDB.reservations.ToList();

            Closed += delegate (object? sender, EventArgs e)
            {
                FPayment?.Close();
                menu?.Close();
                FrontDB.Dispose();
            };
         
            loadControls();

        }

        #region First Tab

        private void loadControls()
        {
         
            // load all comboboxes
            // ComboBox of  Month
            string[] Months_Names = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (var item in Months_Names)
            {
                Month_combo.Items.Add(item);
            }
            // ComboBox of Days
            foreach (var item in Enumerable.Range(1, 31))
            {
                Day_combo.Items.Add(item);
            }
            foreach (var item in new string[] { "Male", "Female" })
            {
                Gender_combo.Items.Add(item);
            }
            // compoBox of state

            foreach (var item in new string[] { "state", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York" })
            {
                stateComb.Items.Add(item);
            }
            foreach (var item in Enumerable.Range(1, 6))
            {
                guestsCombo.Items.Add(item);
            }
            // conmboBox of Room Type
            foreach (var item in new string[] { "Single", "Douple", "Twin", "Duplex", "Suite" })
            {
                roomTypeComb.Items.Add(item);
            }
            // combBox floorCombo
            foreach (var item in Enumerable.Range(1, 5))
            {
                floorCombo.Items.Add(item);
            }
            // conmboBox of Room Number
            Random randomRooms = new Random();
            for (int i = 0; i < 35; i++)
            {
                roomNumberComb.Items.Add(randomRooms.Next(100, 500));
            }



        }

        private bool formValidation()
        {

            // form not valid
            if (
                firstName.Text.Equals(string.Empty) ||
                lastName.Text.Equals(string.Empty) ||
                PhoneTxt.Text.Equals(string.Empty) ||
                EmailTxt.Text.Equals(string.Empty) ||
                StreetAddress.Text.Equals(string.Empty) ||
                Appt.Text.Equals(string.Empty) ||
                City.Text.Equals(string.Empty) ||
                stateComb.SelectedValue.Equals(string.Empty) ||
                Gender_combo.SelectedValue.Equals(string.Empty) ||
                Month_combo.SelectedValue.Equals(string.Empty) ||
                Day_combo.SelectedValue.Equals(string.Empty) ||
                ZipCode.Text.Equals(string.Empty) ||
                roomNumberComb.SelectedValue.Equals(string.Empty) ||
                roomTypeComb.SelectedValue.Equals(string.Empty) ||
                floorCombo.SelectedValue.Equals(string.Empty) ||
                guestsCombo.SelectedValue.Equals(string.Empty)


                )
            {
                ReservationGrid.Visibility = Visibility.Visible;
                ErrorValidation.Visibility = Visibility.Visible;
                return false;
            }
            else
            {
                // submit text boxes
                ReservationData.first_name = firstName.Text.ToString();
                ReservationData.last_name = lastName.Text.ToString();

                // select value combBox of 
                ReservationData.birth_day = (Month_combo.SelectedValue) + "-" + Day_combo.SelectedValue + "-" + DBYear.Text.ToString();

                // select gender
                ReservationData.gender = Gender_combo?.SelectedValue?.ToString() ?? "";

                // select phone number
                ReservationData.phone_number = PhoneTxt.Text;

                // select email value
                ReservationData.email_address = EmailTxt.Text;

                // street
                ReservationData.street_address = StreetAddress.Text;

                // aptSuiteTxt
                ReservationData.apt_suite = Appt.Text;

                // city
                ReservationData.city = City.Text;

                // stateComb
                ReservationData.state = stateComb.SelectedValue.ToString() ?? "NA";

                //zipTxt
                ReservationData.zip_code = ZipCode.Text;

                // guests
                if (int.TryParse(guestsCombo.SelectedItem.ToString(), out int number_guest))
                    ReservationData.number_guest = number_guest;

                // floor
                if (taskFinder)
                {
                    ReservationData.room_floor = roomFloor;

                    // room Number
                    ReservationData.room_number = roomNumber;

                }
                else
                {
                    ReservationData.room_floor = floorCombo.SelectedItem.ToString() ?? "NA";

                    // room Number
                    ReservationData.room_number = roomNumberComb.SelectedItem.ToString() ?? "NA";
                }
                // room type 
                ReservationData.room_type = roomTypeComb.SelectedValue?.ToString() ?? ReservationData.room_type;


                ReservationData.apt_suite = Appt.Text;


                // Entry DAta
                ReservationData.arrival_time = Entry_Date?.SelectedDate ?? DateTime.Now;
                ReservationData.leaving_time = Departure_Date?.SelectedDate ?? DateTime.Now;


                ReservationData.food_bill = foodBill;
                ReservationData.payment_type = paymentType;
                ReservationData.card_number = paymentCardNumber;
                ReservationData.card_exp = MM_YY_Of_Card;
                ReservationData.card_cvc = CVC_Of_Card;
                ReservationData.card_type = CardType;

                return true;
            }


        }

        private void InsertData()
        {
            try
            {

                ErrorValidation.Visibility = Visibility.Collapsed;

                FrontDB.reservations.Add(ReservationData);
                primartyID = ReservationData.Id;
                FrontDB.SaveChanges();

                //ReservationGrid.Visibility = Visibility.Visible;
                SuccessfulMessage.Visibility = Visibility.Visible;

                Report message = new Report("\"Inserted item from database successfully.  ", primartyID, true);
                message.ShowDialog();
            }
            catch
            {
                ReservationGrid.Visibility = Visibility.Visible;
                ErrorMessage.Visibility = Visibility.Visible;
                Report message = new Report("\"Failed when Insert New Rservation  ", primartyID, true);
                message.ShowDialog();
            }
        }

        private void UpdatetData()
        {
            try
            {

                ErrorValidation.Visibility = Visibility.Collapsed;

                FrontDB.reservations.Update(ReservationData);
                FrontDB.SaveChanges();

                //SuccessfulMessage.Visibility = Visibility.Visible;
                Report message = new Report("\"Updates item from database successfully. For the UNIQUE USER ID of: ", primartyID, true);
                message.ShowDialog();
                editReservationGrid.Visibility = Visibility.Hidden;
                loadControls();

            }

            catch
            {
                // ErrorMessage.Visibility = Visibility.Visible;
                Report message = new Report("\"Failed when Update Rservation With UNIQUE USER ID of: ", primartyID, true);
                message.ShowDialog();

            }


        }


        private void SubmitNewReservationHandler(object sender, RoutedEventArgs e)
        {
            if (formValidation())
            {
                InsertData();
            }
        }

        private void roomTypeComb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (roomTypeComb.SelectedItem != null)
            {

                if (roomTypeComb.SelectedItem.Equals("Single"))
                {
                    totalAmount = 100;
                    floorCombo.SelectedItem = 1;
                }
                else if (roomTypeComb.SelectedItem.Equals("Douple"))
                {
                    totalAmount = 200;
                    floorCombo.SelectedItem = 2;
                }
                else if (roomTypeComb.SelectedItem.Equals("Twin"))
                {
                    totalAmount = 300;
                    floorCombo.SelectedItem = 3;
                }
                else if (roomTypeComb.SelectedItem.Equals("Duplex"))
                {
                    totalAmount = 400;
                    floorCombo.SelectedItem = 4;
                }
                else if (roomTypeComb.SelectedItem.Equals("Suite"))
                {
                    totalAmount = 500;
                    floorCombo.SelectedItem = 5;
                }

                // select number of guests

                bool temp = int.TryParse(guestsCombo.SelectedValue.ToString(), out int selectedGuest);
                string selected;

                if (temp)
                {

                    selected = guestsCombo.SelectedValue?.ToString() ?? "";
                    selectedGuest = Convert.ToInt32(selected);
                    if (selectedGuest >= 3)
                    {
                        totalAmount += (selectedGuest * 5);
                    }

                }

            }

        }

        private void foodSupplyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (FoodSupplyCheckBox.IsChecked == true)
            {
                ReservationData.supply_status = true;
            }
            else
            {
                ReservationData.supply_status = false;
            }
        }

        private void checkinCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (Checkin.IsChecked == true)
            {
                ReservationData.check_in = true;
            }
            else
            {
                ReservationData.check_in = false;
            }
        }

        private void FoodMenuClick(object sender, EventArgs e)
        {
            menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    menu.breakfast_checkbox.IsChecked = true;
                    menu.breakfast_quantity.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    menu.lunch_checkbox.IsChecked = true;
                    menu.lunch_quantity.Text = Convert.ToString(breakfast);
                }
                if (dinner > 0)
                {
                    menu.dinner_checkox.IsChecked = true;
                    menu.dinner_quantity.Text = Convert.ToString(breakfast);
                }
                if (cleaning)
                {
                    menu.cleaning_checkox.IsChecked = true;
                }
                if (towel)
                {
                    menu.towels_checkox.IsChecked = true;

                }
                if (surprise)
                {
                    menu.Sweetest_surprise_checkbox.IsChecked = true;
                }
            }

            menu.ShowDialog();

            ReservationData.break_fast = breakfast = menu.BreakfastQ;
            ReservationData.lunch = lunch = menu.LunchQ;
            ReservationData.dinner = dinner = menu.DinnerQ;

            // options
            ReservationData.cleaning = menu.Cleaning;
            ReservationData.towel = menu.Towel;
            ReservationData.s_surprise = menu.Surprise;

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }
        }

        private void FinalizeBillClick(object sender, RoutedEventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == false && towel == false && surprise == false)
            {
                FoodSupplyCheckBox.IsChecked = true;
            }
            UpdateReservationBtn.IsEnabled = true;
            FPayment = new FinalizePayment();
            FPayment.totalAmountFromFrontend = totalAmount;
            FPayment.foodBill = foodBill;

            if (taskFinder)
            {
                FPayment.PaymentType = ReservationData.payment_type.Trim().ToString();
                FPayment.cardTypeTxt.Text = ReservationData.card_number;
                FPayment.MonthCombo.SelectedItem = ReservationData.card_exp.Trim().Split('/')[0].ToString();
                FPayment.yearCombo.SelectedItem = ReservationData.card_exp.Trim().Split('/')[1].ToString();
                FPayment.CVCText.Text = ReservationData.card_cvc.Trim().ToString();
                FPayment.foodBill_Price.Content = ReservationData.food_bill;
            }
            FPayment.LoadDetailsFromFrontEnd();
            FPayment.ShowDialog();

            finalizedTotalAmount = FPayment.FinalTotalFinalized;
            paymentType = FPayment.PaymentType.ToString();

            paymentCardNumber = FPayment.PaymentCardNumber;
            MM_YY_Of_Card = FPayment.MM_YY_Of_Card1;
            CVC_Of_Card = FPayment.CVC_Of_Card1;
            CardType = FPayment.CardType1;

            if (!editClicked)
            {
                SubmitForm.Visibility = Visibility.Visible;
            }
        }

        private void comboBoxEditReservation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            taskFinder = true;

            string Fname = ((ComboBox)sender).SelectedItem.ToString().Split('|')[1].ToString().Split(" ")[1].ToString();
            string Lname = ((ComboBox)sender).SelectedItem.ToString().Split('|')[1].ToString().Split(" ")[2].ToString();

            ReservationData = FrontDB.reservations.FirstOrDefault(s => s.first_name == Fname && s.last_name == Lname);

            primartyID = ReservationData.Id;
            firstName.Text = Fname;
            lastName.Text = Lname;
            var birthdate = ReservationData?.birth_day.Split("-");
          
            Month_combo.SelectedItem = birthdate[0].Trim().ToString();
            Day_combo.SelectedItem = birthdate[1].Trim().ToString();
            DBYear.Text = birthdate[2].Trim().ToString();
            Gender_combo.SelectedItem=ReservationData?.gender.Trim().ToString();
            PhoneTxt.Text=ReservationData?.phone_number.Trim().ToString();
            EmailTxt.Text = ReservationData?.email_address.Trim().ToString();
            Appt.Text=ReservationData.apt_suite.Trim().ToString();
            StreetAddress.Text=ReservationData.street_address.Trim().ToString();
            City.Text = ReservationData.city.Trim().ToString();
            stateComb.SelectedItem = ReservationData.state.Trim().ToString();
            ZipCode.Text=ReservationData.zip_code.Trim().ToString();
            roomTypeComb.SelectedItem = ReservationData.room_type.Trim().ToString();
            guestsCombo.SelectedItem = ReservationData.number_guest;

            floorCombo.SelectedItem = ReservationData.room_floor.Trim().ToString();
            //roomNumberComb.SelectedItem=ReservationData.room_number.Trim().ToString();
            roomNumberComb.Text = ReservationData.room_number.Trim().ToString();
            Entry_Date.Text=ReservationData.arrival_time.ToString();
            Departure_Date.Text = ReservationData.leaving_time.ToString();

            breakfast = ReservationData.break_fast;
            lunch = ReservationData.lunch;
            dinner = ReservationData.dinner;

            towel = ReservationData.towel;
            cleaning = ReservationData.cleaning;
            surprise = ReservationData.s_surprise;

        }


        private void UpdateReservationBtn_Click(object sender, EventArgs e)
        {
            if (formValidation())
            {
                UpdatetData();
            }

        }

        private void editReservation_Click(object sender, EventArgs e)
        {
            editReservationGrid.Visibility = Visibility.Visible;

            foreach (reservation reservationDetails in Lists_of_reservation.ToList())
            {
                comboBoxEditReservation.Items.Add(reservationDetails.zip_code.ToString() + " | " + reservationDetails.first_name.ToString() + " " + reservationDetails.last_name.ToString() + " | " + reservationDetails.phone_number);
            }
        }

        private void deleteReservation_Click(object sender, EventArgs e)
        {
            try
            {
                FrontDB.reservations.Remove(ReservationData);
                FrontDB.SaveChanges();

                Report message = new Report("\"Deleted item from database successfully. For the UNIQUE USER ID of: ", primartyID, true);
                message.ShowDialog();
                editReservationGrid.Visibility = Visibility.Hidden;
                loadControls();

            }
            catch
            {
                Report message = new Report("\"Failed when Delete Rservation. With the UNIQUE USER ID of: ", primartyID, true);
                message.ShowDialog();

            }
        }
        private void addReservation_Click(object sender, EventArgs e)
        {

            editReservationGrid.Visibility = Visibility.Hidden;
            //loadControls();
            //resetData();


        }

        //private void resetData()
        //{
        //     firstName.Text = "";
        //     lastName.Text = "";
        //    PhoneTxt.Text ="";
        //    EmailTxt.Text ="";
        //    StreetAddress.Text = "";
        //    Appt.Text="";
        //    City.Text= "";
        //    stateComb.SelectedValue="";
        //    Gender_combo.SelectedValue = "";
        //    Month_combo.SelectedValue = "";
        //    Day_combo.SelectedValue = "";
        //    ZipCode.Text = "";
        //    roomNumberComb.SelectedValue="";
        //    roomTypeComb.SelectedValue="";
        //    floorCombo.SelectedValue="";
        //    guestsCombo.SelectedValue= "";
        //}
        #endregion

        #region Second Tab
        private void Search_Click(object sender, EventArgs e)
        {
            var searchResult=FrontDB.reservations.Where( r => r.Id.ToString().Contains(TBoxSearch.Text) ||
                                                         r.first_name.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.last_name.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.gender.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.phone_number.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.email_address.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.city.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.state.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.room_type.ToLower().Contains(TBoxSearch.Text.ToLower()) ||
                                                         r.apt_suite.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            searchData.ItemsSource= searchResult;
        }     

        #endregion

        #region Third Tab

        private void TableItem_GotFocus(object sender, RoutedEventArgs e)
        {
            FrontDB.reservations.Load();
            Result.ItemsSource= FrontDB.reservations.Local.ToBindingList();
            FrontDB.SaveChanges();
        }

        #endregion

        #region Fourth Tab

        private void TableControl_GotFocus(object sender,RoutedEventArgs e)
        {
            FrontDB.reservations.Load();
            OccupiedList.ItemsSource = FrontDB.reservations.Where(e => e.check_in == true).Select(r => new
            {
                reservation = r.room_number + "  " + r.room_type + "  " + r.zip_code + "  " + " [ " + r.first_name + "  " + r.last_name + " ] " + "  " + r.phone_number
            }).ToList();
            OccupiedList.DisplayMemberPath = "reservation";
            


            FrontDB.reservations.Load();
            ReservedList.ItemsSource = FrontDB.reservations.Where(e => e.check_in == false).Select(r => new
            {
                reservation = r.room_number + "  " + r.room_type + "  " + r.zip_code + "  " + " [ " + r.first_name + "  " + r.last_name + " ] " + "  " + r.phone_number
             
               + "  " + r.arrival_time + "  " + r.leaving_time
            }).ToList();
            ReservedList.DisplayMemberPath = "reservation";
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}



