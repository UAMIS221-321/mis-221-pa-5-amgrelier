namespace mis_221_pa_5_amgrelier
{
    public class Reports
    {
             private string customerName;
       private string customerEmail;
       private int trainingDate;
       private int numSessions;
       private int customerID;
       private static int count;


       public Reports(){


       }
       public Reports(string customerName, string customerEmail, int trainingDate, int numSessions, int customerID){
           this.customerName = customerName;
           this.customerEmail = customerEmail;
           this.trainingDate = trainingDate;
           this.numSessions = numSessions;
           this.customerID = customerID;
       }
       public void SetCustomerName(string customerName){
           this.customerName = customerName;
       }
       public string GetCustomerName(){
           return customerName;
       }
       public void SetCustomerEmail(string customerEmail){
           this.customerEmail = customerEmail;
       }
       public string GetCustomerEmail(){
           return customerEmail;
       }
       public void SetTrainingDate(int trainingDate){
           this.trainingDate = trainingDate;
       }
       public int GetTrainingDate(){
           return trainingDate;


       }
       public void SetNumberOSessions(int numSessions){
           this.numSessions = numSessions;
       }
       public int GetNumSessions(){
           return numSessions;
       }
       public void SetCustomerID(int customerID){
           this.customerID = customerID;
       }
       public int GetCustomerID(){
           return customerID;
       }
       public static void SetCount(int count){
           Reports.count = count;
       }
       public static int GetCount(){
           return Reports.count;
       }
       static public void IncCount(){
           Reports.count++;
       }
    }
}