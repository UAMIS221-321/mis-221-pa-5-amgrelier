namespace mis_221_pa_5_amgrelier
{
    public class Booking
    {
       private int sessionID;
       private int customerID;
       private string customerName;
       private string customerEmail;
       private int customerSessions;
       private string trainingDate;
       private int trainerID;
       private string trainerName;
       private bool bookingStatus;
       private static int count;


       public Booking()
       {
       }


       public Booking(int sessionID, int customerID, string customerName, string customerEmail,int customerSessions, string trainingDate, int trainerID, string trainerName)
       {
           this.sessionID = sessionID;
           this.customerID = customerID;
           this.customerName = customerName;
           this.customerEmail = customerEmail;
           this.trainingDate = trainingDate;
           this.trainerID = trainerID;
           this.trainerName = trainerName;
           bookingStatus = true;
       }


       public void SetSessionID(int sessionID)
       {
           this.sessionID = sessionID;
       }


       public int GetSessionID()
       {
           return sessionID;
       }
       public void SetCustomerID(int customerID){
           this.customerID = customerID;
       }
       public int GetCustomerID(){
           return customerID;
       }


       public void SetCustomerName(string customerName){
           this.customerName = customerName;
       }
       public string GetCustomerName(){
           return customerName;
       }


       public void SetCustomerEmail(string customerEmail)
       {
           this.customerEmail = customerEmail;
       }


       public string GetCustomerEmail()
       {
           return customerEmail;
       }
        public void SetCustomerSessions(int customerSessionsl)
       {
           this.customerSessions = customerSessions;
       }


       public int GetCustomerSessions()
       {
           return customerSessions;
       }


       public void SetTrainingDate(string trainingDate)
       {
           this.trainingDate = trainingDate;
       }


       public string GetTrainingDate()
       {
           return trainingDate;
       }


       public void SetTrainerID(int trainerID)
       {
           this.trainerID = trainerID;
       }


       public int GetTrainerID()
       {
           return trainerID;
       }


       public void SetTrainerName(string trainerName)
       {
           this.trainerName = trainerName;
       }


       public string GetTrainerName()
       {
           return trainerName;
       }


       public void SetBookingStatus(bool bookingStatus)
       {
           this.bookingStatus = bookingStatus;
       }


       public bool GetBookingStatus()
       {
           return bookingStatus;
       }


       public static void SetCount(int count)
       {
           Booking.count = count;
       }


       public static void IncCount()
       {
           Booking.count++;
       }


       public static int GetCount()
       {
           return Booking.count;
       }

    }
}