using System;
class Schorlar: Person
{
   
     private string scholar_id;
     private string email;
     private string password;
     private bool checkadmin;
    public Schorlar(string gender,string name,string surname,string scholar_id,int age,string lose, string religious,bool checkadmin,string email,string password)
    :base(gender,name,surname,age,lose,religious)
    {
        this.scholar_id = scholar_id;
        this.email = email;
        this.password = password;
        checkadmin = false;
    }
    public string GetScholarID()
    {
        return this.scholar_id;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }
    
    
}