namespace mis_221_pa_5_amgrelier
{
    public class Listing
    {
         private int sessionID;
       private string trainerName;
       private string date;
       private double time;
       private double cost;
       private bool available;
       private bool deleted;
       private static int count;


       public Listing(){


       }
       public Listing(int sessionID, string trainerName, string date, double time, double cost){
           this.sessionID = sessionID;
           this.trainerName = trainerName;
           this.date = date;
           this.time = time;
           this.cost = cost;
           available = true;
           deleted = false;
       }
       public void SetSessionID(int sessionID){
           this.sessionID = sessionID;
       }
       public int GetSessionID(){
           return sessionID;
       }
       public void SetTrainerName(string trainerName){
           this.trainerName = trainerName;
       }
       public string GetTrainerName(){
           return trainerName;
       }
       public void SetDate(string date){
           this.date = date;
       }
       public string GetDate(){
           return date;
       }
       public void SetTime(double time){
           this.time = time;
       }
       public double GetTime(){
           return time;
       }
       public void SetCost(double cost){
           this.cost = cost;
       }
       public double GetCost(){
           return cost;
       }
       public void SetAvailability(bool available){
           this.available = available;
       }
       public bool GetAvailability(){
           return available;
       }
       public static void SetCount(int count){
           Listing.count = count;
       }
       public static int GetCount(){
           return Listing.count;
       }
       static public void IncCount(){
           Listing.count++;
       }
       public void SetDeleted(bool deleted){
           this.deleted = deleted;
       }
       public bool GetDeleted(){
           return deleted;
       }
    }
}