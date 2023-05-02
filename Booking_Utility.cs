namespace mis_221_pa_5_amgrelier
{
    public class Booking_Utility
    {
       private Booking[] bookings;


       public Booking_Utility()
       {
           bookings = new Booking[100];
       }
       public void GetAllBookingsFromFile(){
           System.Console.WriteLine("Enter customer name for the session you're trying to access");
           string customerName = Console.ReadLine();


           StreamReader inFile = new StreamReader("transactions.txt");
           string line = inFile.ReadLine();


         
          
           while (line != null)
           {
              
               string[] temp = line.Split('#');
               if(temp[2] == customerName){
                   System.Console.WriteLine($"Session Available: {temp[8]} ");
               }
               else{
                    System.Console.WriteLine("Booking is not found try again");
               }
               line = inFile.ReadLine();
           }


           inFile.Close();
         
      
       }
       public void AddBooking(){
           System.Console.WriteLine("Enter the Session ID");
           Booking myBooking = new Booking();
           myBooking.SetSessionID(int.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the customer ID");
           myBooking.SetCustomerID(int.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the customer name");
           myBooking.SetCustomerName(Console.ReadLine());


           System.Console.WriteLine("Enter the customer email");
           myBooking.SetCustomerEmail(Console.ReadLine());


           System.Console.WriteLine("Enter the number of sessions the customer has attended");
           myBooking.SetCustomerSessions(int.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter a valid training Date that occurs in 2023");
           myBooking.SetTrainingDate(Console.ReadLine());


           System.Console.WriteLine("Enter the Trainer ID");
           myBooking.SetTrainerID(int.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the trainer name");
           myBooking.SetTrainerName(Console.ReadLine());


           //System.Console.WriteLine("Enter the status of the booking");


           bool bookingStatus = true;
           myBooking.SetBookingStatus(bookingStatus);


           bookings[Booking.GetCount()] = myBooking;
           Booking.IncCount();


           Save();


              
       }
       private void Save()
       {
           StreamWriter outFile = new StreamWriter("transactions.txt");


           for (int i = 0; i < Booking.GetCount(); i++)
           {
               outFile.WriteLine(bookings[i].GetSessionID() + "#" + bookings[i].GetCustomerID() + "#" + bookings[i].GetTrainerName() + "#" + bookings[i].GetCustomerEmail() + "#" + bookings[i].GetCustomerSessions() + "#" + bookings[i].GetTrainingDate() + "#" + bookings[i].GetTrainerID() + "#" + bookings[i].GetTrainerName() + "#" + bookings[i].GetBookingStatus());
           }
           outFile.Close();
       }
     


       public void UpdateBooking(){
           StreamReader inFile = new StreamReader("transactions.txt");
           System.Console.WriteLine("What is the session ID of the booking that needs to be updated?");
           int searchVal = int.Parse(Console.ReadLine());
           int foundIndex = Find(searchVal);


           if(foundIndex != -1){
               System.Console.WriteLine("Enter the Session ID");
               Booking myBooking = new Booking();
               bookings[foundIndex].SetSessionID(int.Parse(Console.ReadLine()));


               System.Console.WriteLine("Enter the customer ID");
               bookings[foundIndex].SetCustomerID(int.Parse(Console.ReadLine()));


               System.Console.WriteLine("Enter the customer name");
               bookings[foundIndex].SetCustomerName(Console.ReadLine());


               System.Console.WriteLine("Enter the customer e-mail");
               bookings[foundIndex].SetCustomerEmail(Console.ReadLine());


               System.Console.WriteLine("Enter a valid training Date that occurs in 2023");
               bookings[foundIndex].SetTrainingDate(Console.ReadLine());


               System.Console.WriteLine("Enter the Trainer ID");
               bookings[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));


               System.Console.WriteLine("Enter the trainer name");
               bookings[foundIndex].SetTrainerName(Console.ReadLine());


               System.Console.WriteLine("Has the booking been completed?");


               DeleteBooking();




              
           }
           else{
               System.Console.WriteLine("Booking is not found");
           }
           inFile.Close();
       }
       private int Find(int searchVal){
           StreamReader inFile = new StreamReader("transactions.txt");
           string num = inFile.ReadLine();


           string[] temp = num.Split("#");


           for(int i = 0; i < Booking.GetCount(); i++){
               if(temp[0] == searchVal.ToString()){
                   return i;
               }
           }
           inFile.Close();
           return -1;
       }
       public void DeleteBooking()
       {
           StreamReader inFile = new StreamReader("transactions.txt");
           Console.WriteLine("What is the session ID of the booking you want to delete");
           int searchVal = int.Parse(Console.ReadLine());
           int foundIndex = Find(searchVal);
  
           if (foundIndex != -1)
           {
               bookings[foundIndex].SetBookingStatus(false);
           Save();
           }
           else
           {
               Console.WriteLine("Booking is not found");
           }
           inFile.Close();
       }

    }
}