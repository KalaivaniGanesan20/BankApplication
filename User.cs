using System.ComponentModel.DataAnnotations;

namespace UserModel
{
   public class User
   {

      [Key]
      public Guid userid { get; set; }
      public string username { get; set; }
      public DateTime dateofbirth { get; set; }
      public long phonenumber { get; set; }
      public string emailid{get;set;}
      public string password { get; set; }
      public List<Address> address{get;set;}
      public List<Account> account{get;set;}
      public List<Proof> proof{get;set;}
    
   }
   public class Address
   {
    public Guid userid { get; set; }
    public string doornumber { get; set; }
    public string street { get; set; }
    public string  city { get; set; }
    public string state { get; set; }
    public int pincode { get; set; }
   }

   public class Proof
   {
    public Guid userid { get; set; }
    public long aadharnumber { get; set; }
    public IFormFile aadharproof { get; set; }
    public string pancardnumber{get;set;}
    public IFormFile pancardproof { get; set; }
    public IFormFile photocopy { get; set; }

   }
   public class Account
   {
      public Guid userid { get; set; }
      public long customerid { get; set; }
      public long accountnumber { get; set; }
      public string accounttype { get; set; }
      public DateTime dateofcreated { get; set; }
      public string IFSCcode{get;set;}
      public string bankname{get;set;}
      public string branchname{get;set;}
      public string status { get; set; }

   }
}