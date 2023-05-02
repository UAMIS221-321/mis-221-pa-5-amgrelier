namespace mis_221_pa_5_amgrelier
{
    public class Menu
    {
        
       public Menu[] menus;


       public void MenuUtility(Menu[] menus){
           this.menus = menus;
       }






       public void ManagerMenu(){


           Trainer[] trainers = new Trainer[20];
           Listing[] listings = new Listing[20];
           Booking[] bookings = new Booking[20];
           Reports[] reports = new Reports[20];




           Trainer_Utility trainerUtility = new Trainer_Utility();
           Listing_Utility listingUtility = new Listing_Utility();
           Booking_Utility bookingUtility = new Booking_Utility();
           Report_Utility reportUtility = new Report_Utility();




           System.Console.WriteLine("Welcome to Train Like a Champion! (TLAC)");
           System.Console.WriteLine("Please Select One of the Following Options:");


           System.Console.WriteLine("Press 1 to Add a Trainer to file");
           System.Console.WriteLine("Press 2 to Update a Trainer on file");
           System.Console.WriteLine("Press 3 to Delete a Trainer on file");
           System.Console.WriteLine("Press 4 to Add a Listing to file");
           System.Console.WriteLine("Press 5 to Update a Listing on file");
           System.Console.WriteLine("Press 6 to Delete a Listing on file");
           System.Console.WriteLine("Press 7 to View a Booking Session");
           System.Console.WriteLine("Press 8 to Add a Booking Session");
           System.Console.WriteLine("Press 9 to Update Booking to file");
           System.Console.WriteLine("Press 10 to view Individual Customer Sessions");
           System.Console.WriteLine("Press 11 to view Historical Customer Sessions");
           System.Console.WriteLine("Press 12 to view historical Revenue Reports");
           System.Console.WriteLine("Press 13 to Exit the Program");
           string input = Console.ReadLine();


           while(input != "13"){
               if(input == "1"){
                   trainerUtility.AddTrainer();
               }
               else if(input == "2"){
                   trainerUtility.UpdateTrainer();
               }
               else if(input == "3"){
                   trainerUtility.DeleteTrainer();
               }
               else if(input == "4"){
                   listingUtility.AddListings();
               }
               else if(input == "5"){
                   listingUtility.UpdateListing();
               }
               else if(input == "6"){
                   listingUtility.DeleteListing();
               }
               else if(input == "7"){
                  bookingUtility.GetAllBookingsFromFile();
               }
               else if(input == "8"){
                   bookingUtility.AddBooking();
               }
               else if(input == "9"){
                   bookingUtility.UpdateBooking();
               }
               else if(input == "10"){
                   reportUtility.IndividualCustomerSessions();
               }
               else if(input == "11"){
                   reportUtility.HistoricalCustomerSessions();
               }
               else if(input == "12"){
                   reportUtility.HistoricalRevenueReport();
               }
               else{
                   System.Console.WriteLine("Invalid Option, Enter another number");
               }
           System.Console.WriteLine("Welcome to Train Like a Champion! (TLAC)");
           System.Console.WriteLine("Please Select One of The Following Options:");


           System.Console.WriteLine("Press 1 to Add a Trainer to file");
           System.Console.WriteLine("Press 2 to Update a Trainer on file");
           System.Console.WriteLine("Press 3 to Delete a Trainer on file");
           System.Console.WriteLine("Press 4 to Add a Listing to file");
           System.Console.WriteLine("Press 5 to Update a Listing on file");
           System.Console.WriteLine("Press 6 to Delete a Listing on file");
           System.Console.WriteLine("Press 7 to View a Booking Session");
           System.Console.WriteLine("Press 8 to Add a Booking Session");
           System.Console.WriteLine("Press 9 to Update Booking to file");
           System.Console.WriteLine("Press 10 to view Individual Customer Sessions");
           System.Console.WriteLine("Press 11 to view Historical Customer Sessions");
           System.Console.WriteLine("Press 12 to view historical Revenue Reports");
           System.Console.WriteLine("Press 13 to Exit the Program");
           input = Console.ReadLine();


           }
         
       }

    }
}