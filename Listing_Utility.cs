namespace mis_221_pa_5_amgrelier
{
    public class Listing_Utility
    {
        private Listing[] listings;


       public Listing_Utility()
       {
           listings = new Listing[100];
       }


       public Listing[] GetAllListingsFromFile()
       {
          StreamReader inFile = new StreamReader("listings.txt");


           Listing.SetCount(0);
           string line = inFile.ReadLine();
           while (line != null)
           {
               string[] temp = line.Split("#");
               listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], double.Parse(temp[3]),double.Parse(temp[4]));
               Listing.IncCount();
               line = inFile.ReadLine();
           }
           inFile.Close();
           return listings;
       }
       public void AddListings()
       {
          System.Console.WriteLine("Enter the Session ID you want");
          Listing myListing = new Listing();
          myListing.SetSessionID(int.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the name of the Trainer");
           myListing.SetTrainerName(Console.ReadLine());


           System.Console.WriteLine("Enter the date of training Session");
           myListing.SetDate(Console.ReadLine());


           System.Console.WriteLine("Enter the time of the session. Enter a time in decimal form (i.e. 8.45 for 8:45)");
           myListing.SetTime(double.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the cost of the session");
           myListing.SetCost(double.Parse(Console.ReadLine()));


           System.Console.WriteLine("Your session has been added to listings.txt with availabilty and deleted at the end.");


           bool available = true;
           myListing.SetAvailability(true);


           bool deleted = false;
           myListing.SetDeleted(deleted);


           listings[Listing.GetCount()] = myListing;
           Listing.IncCount();


           Save();
       }


       private void Save()
       {
           StreamWriter outFile = new StreamWriter("listings.txt");


           for (int i = 0; i < Listing.GetCount(); i++)
           {
               outFile.WriteLine(listings[i].GetSessionID() + "#" + listings[i].GetTrainerName() + "#" + listings[i].GetDate() + "#" + listings[i].GetTime() + "#" + listings[i].GetCost() + "#" + listings[i].GetAvailability() + "#" + listings[i].GetDeleted());
           }
           outFile.Close();
       }


       private int Find(int searchVal)
       {
           StreamReader inFile = new StreamReader("listings.txt");


           for (int i = 0; i < Listing.GetCount(); i++)
           {
               if (listings[i].GetSessionID() == searchVal)
               {
                   return i;
               }
           }
           inFile.Close();
           return -1;
       }
       public void UpdateListing()
       {
       Console.WriteLine("What is the Session ID of the listing that needs to be updated?");
       int searchVal = int.Parse(Console.ReadLine());
       int foundIndex = Find(searchVal);


       if (foundIndex != -1)
       {
           Console.WriteLine("Enter the Session ID of the Listing");
           listings[foundIndex].SetSessionID(int.Parse(Console.ReadLine()));


           Console.WriteLine("Enter the name of the Trainer");
           listings[foundIndex].SetTrainerName(Console.ReadLine());


           Console.WriteLine("Enter the date of the Session");
           listings[foundIndex].SetDate(Console.ReadLine());


           Console.WriteLine("Enter the time of the session. Enter a time in decimal form (i.e. 8.45 for 8:45)");
           listings[foundIndex].SetTime(double.Parse(Console.ReadLine()));


           System.Console.WriteLine("Enter the cost of the session");
           listings[foundIndex].SetCost(double.Parse(Console.ReadLine()));


           System.Console.WriteLine("Your listing has been updated");


  
           Save();
       }
       else
       {
           Console.WriteLine("Listing is not found");
       }
       }  
       public void DeleteListing()
       {
           Console.WriteLine("What is the Id of the Listing you want to delete");
           int searchVal = int.Parse(Console.ReadLine());
           int foundIndex = Find(searchVal);
  
           if (foundIndex != -1)
           {
               listings[foundIndex].SetDeleted(true);
           Save();
           }
           else
           {
               Console.WriteLine("Listing is not found");
           }
       }
    }
}