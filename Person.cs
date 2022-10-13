class Person
{
    private string gender;
    private string name;
    private string  surname;
    private int age;
    private string lose;
    private string religious;
    public Person(string gender,string name,string surname,int age,string lose, string religious )
    {
        this.gender = gender;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.lose = lose;
        this.religious = religious;
        
    }
    public string GetGender()
    {
        return this.gender;
    }
     public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public int GetAge()
    {
        return this.age;
    } 
    public string GetLose()
    {
        return this.lose;
    }
    public string GetReligious()
    {
        return this.religious;
    }
    

    

}