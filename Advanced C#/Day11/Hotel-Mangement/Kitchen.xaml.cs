using Hotel.UI.Report;
using Hotel_Mangement_System.Contexts;
using Hotel_Mangement_System.Entities;
using Hotel_Mangement_System.Entitiess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_Mangement_System
{
    /// <summary>
    /// Interaction logic for Kitchen.xaml
    /// </summary>
    public partial class Kitchen : Window
    {
        FrontEndContext KitchenDB;

        reservation SelectedReservation { get; set; }
        int breakfast, lunch, dinner, foodBill;
        bool cleaning, towel, surprise;
        bool supplyStatus = false;
  

        public Kitchen()
        {
            InitializeComponent();
            KitchenDB = new();
            ReloadList();


        }


        private void SelectDataToTextBox(object sender, SelectionChangedEventArgs e)
        {
            var SelectedReservation = OnTheLine_List.SelectedItem as reservation;
            if (SelectedReservation != null) { 
                    first_Name.Text = SelectedReservation.first_name;
                    lirst_Name.Text = SelectedReservation.last_name;
                    Phone_Number.Text = SelectedReservation?.phone_number.Trim().ToString();
                    room_Type.Text = SelectedReservation.room_type.Trim().ToString();

                    floor_Combo.Text = SelectedReservation.room_floor.Trim().ToString();
                    room_Number.Text = SelectedReservation.room_number.Trim().ToString();

                    breakfastTxt.Text = SelectedReservation.break_fast.ToString();
                    lanchTxt.Text = SelectedReservation.lunch.ToString();
                    dinnerTxt.Text = SelectedReservation.dinner.ToString();

                    cleaningCheckbox.IsChecked = SelectedReservation.cleaning;
                    towelsCheckbox.IsChecked = SelectedReservation.towel;

                   sweetSurpriseCheckbox.IsChecked = SelectedReservation.s_surprise;
                  SupplyStatus.IsChecked = SelectedReservation.supply_status;
        }
            
           

        }

        private void ReloadList()
        {
            supplyStatus = false;
            KitchenDB = new();
            try
            {
                string queryString = "Select * from reservation where check_in = '" + "True" + "' AND supply_status='" + "False" + "'";

                List<reservation> list = KitchenDB.reservations.FromSqlRaw(queryString).ToList();

                OnTheLine_List.ItemsSource = list;
                OverviewDataGrid.ItemsSource = list;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void udpateChangesHadler(object sender, RoutedEventArgs e)
        {

            try
            {
                reservation selectedList = (reservation)OnTheLine_List.SelectedItem;

                if (supplyStatus == false)
                {
                    cleaning = selectedList.cleaning;
                    towel = selectedList.towel;
                    surprise = selectedList.s_surprise;

                }
                FormattableString queryString = $"update reservation set total_bill={(float)(selectedList.total_bill + foodBill)}, break_fast={breakfast}, lunch= {lunch} , dinner={dinner},supply_status= {supplyStatus} , towel = {towel} , s_surprise = {surprise} , cleaning = {cleaning} , food_bill={foodBill} WHERE Id = {selectedList.Id}";

                KitchenDB.Database.ExecuteSql(queryString);
                KitchenDB.SaveChanges();
                ReloadList();

                Report report = new Report("\"Entry successfully updated into database. For the UNIQUE USER ID of: ", selectedList.Id, true);
                report.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());


            }


        }

        private void changeSelectionHandler(object sender, RoutedEventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.HideSpecialNeedsGrid();
            foodMenu.ShowDialog();

            breakfast = foodMenu.BreakfastQ;
            lunch = foodMenu.LunchQ;

            dinner = foodMenu.DinnerQ;

            int bfast = 0, Lnch = 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            }
            if (lunch > 0)
            {
                Lnch = 15 * lunch;
            }
            if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);

        }

        private void FoodSupply_checked(object sender, RoutedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked == true)
            {
                ((CheckBox)sender).IsChecked = true;
                this.supplyStatus = true;
                cleaning = false; towel = false; surprise = false;

                sweetSurpriseCheckbox.IsChecked = false;
                cleaningCheckbox.IsChecked = false;
                towelsCheckbox.IsChecked = false;


                cleaningCheckboxContent.Content = "Cleaned";
                towelCheckBox.Content = "Toweled";
                surpriseCheckBox.Content = "Surprised";
            }

        }

        private void TabOne_GotFocus(object sender, RoutedEventArgs e)
        {
        }
        private void TabTwo_GotFocus(object sender, RoutedEventArgs e)
        {


            ReloadList();

        }


    }
}
