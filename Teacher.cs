using System;
class Teacher: Person
{
    
    private string car_num;
    private string role;
    private string email;
    private string password;
    private bool checkadmin;
    
    public Teacher(string gender,string name,string surname,int age,string role,string lose, string religious,string car_num,bool checkadmin,string email,string password)
    :base(gender,name,surname,age,lose,religious)
    {
        this.car_num = car_num;
        this.role = role;
        this.email =email;
        this.password = password;
        this.checkadmin = false;


    }
    public string GetCarNum()
    {
        return this.car_num;
    }
    public string Getrole()
    {
        return this.role;
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