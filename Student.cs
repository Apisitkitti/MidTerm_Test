using System;
class Student: Person
{
    private string school;
    private string level;
    public Student(string gender,string name,string surname,int age,string level,string lose, string religious,string school)
    :base(gender,name,surname,age,lose,religious)
    {
        this.school = school;
        this.level = level;
    }
    public string GetSchool()
    {
        return this.school;
    }
    public string Getlevel()
    {
        return this.level;
    }
    
}