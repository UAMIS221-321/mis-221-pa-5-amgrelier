namespace mis_221_pa_5_amgrelier
{
    public class Trainer
    {
         private string name;
   private string email;
   private string address;
   private int ID;
   private bool deleted;
   private static int count;


   public Trainer()
   {


   }


   public Trainer(string name, string email, string address, int ID)
   {
       this.name = name;
       this.email = email;
       this.address = address;
       this.ID = ID;
   }


   public void SetName(string name)
   {
       this.name = name;
   }


   public string GetName()
   {
       return name;
   }


   public void SetEmail(string email)
   {
       this.email = email;
   }


   public string GetEmail()
   {
       return email;
   }


   public void SetAddress(string address)
   {
       this.address = address;
   }


   public string GetAddress()
   {
       return address;
   }


   public void SetID(int ID)
   {
       this.ID = ID;
   }


   public int GetID()
   {
       return ID;
   }


   public void SetDeleted(bool deleted)
   {
       this.deleted = deleted;
   }


   public bool GetDeleted()
   {
       return deleted;
   }


   public static void SetCount(int count)
   {
       Trainer.count = count;
   }


   public static int GetCount()
   {
       return count;
   }


   public static void IncCount()
   {
       count++;
   }


    }
    
}