using System;
class PersonList
{
    
    private List<Person>personLists;
    static Program program;
    public PersonList()
    {
        this.personLists = new List<Person>();
    }
    public void AddNewPeople(Person person)
    {
        this.personLists.Add(person);
    }
    
    
    public Student CheckStudent(Student CheckInfo)
    {
        if(personLists is Student)
        {
            foreach(Student student in personLists)
        {
            string gender = CheckInfo.GetGender();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();
            if(student.GetGender().Equals(gender) && student.GetName().Equals(name)&& student.GetSurname().Equals(surname))
            {
                 return null; 
            }
        }
        }

        return CheckInfo;
       
    }
     public Schorlar CheckSchorlar(Schorlar CheckInfo)
    {
        if(personLists is Schorlar)
        {
            foreach(Schorlar schorlar in personLists)
        {
            string gender = CheckInfo.GetGender();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();
            string email = CheckInfo.GetEmail();
            if(schorlar.GetGender().Equals(gender) && schorlar.GetName().Equals(name)&& schorlar.GetSurname().Equals(surname)&&schorlar.GetEmail().Equals(email))
            {
                 return null; 
            }
        }
        }
        return CheckInfo;
       
    }
     public Teacher CheckTeacher(Teacher CheckInfo)
    {   
        if(personLists is Teacher)
    {
        foreach(Teacher teacher in personLists)
        {
            string gender = CheckInfo.GetGender();
            string name = CheckInfo.GetName();
            string surname = CheckInfo.GetSurname();
            string email = CheckInfo.GetEmail();
            if(teacher.GetGender().Equals(gender) && teacher.GetName().Equals(name)&& teacher.GetSurname().Equals(surname)&&teacher.GetEmail().Equals(email))
            {
                 return null; 
            }
        }
    } 
       
        return CheckInfo;
       
    }
    
    
    
   public bool CheckALLFORLOGIN(string email, string password)
    {  
        foreach(Person person in personLists)
        {
            if(person is Schorlar schorlar)
            {
                if(email.Equals(schorlar.GetEmail()) && password.Equals(schorlar.GetPassword()))
                {
                    return true;
                }  
            }
         
        }
        
       
        
            foreach(Person person in personLists)
        {
            if(person is Teacher teacher)
            {
            if(email.Equals(teacher.GetEmail()) && password.Equals(teacher.GetPassword()))
            {
                return true;
            }
            }
        }
        
        
    return false; 
    
    }
    public int teacherCount()
    {
         int countteacher =0; 
         
            foreach(Person person in personLists)
            {
                if(person is Teacher)
                {
                     countteacher ++;
                }
           
            }
            return countteacher;
          
         
    }
    public int studentCount()
    {
        int countstudent =0;
         
          foreach(Person person in personLists)
            {
                if(person is Student)
                {
                     countstudent ++; 
                }
                
            } 
            return countstudent;   
     
    } 
    public int scholarCount()
    {
        int countschorlar =0;
        
        {
            foreach(Person person in personLists)  
            { 
                if(person is Schorlar)
                {
                    countschorlar ++;
                }         
            } 
            return countschorlar;
        }
       
    }
    public int GradeTenCount()
    {   int countgradeten =0;
        
        {
            foreach(Person person in personLists)
            {
                if(person is Student student)
                {
                    if(student.Getlevel() == "Grade 10")
                {
                    countgradeten ++;
                    
                }
                }     
            }
            return countgradeten;
        }
        
    }
    public int GradeElevenCount()
    {
         int countgradeeleven =0;
         
         
            foreach(Person person in personLists)
        {
            if(person is Student student)
            {
                if(student.Getlevel() == "Grade 11")
            {
                countgradeeleven ++;
                
            }
            }
             
        
         }
         return countgradeeleven;
        
    }
    public int GradeTwelveCount()
    {
        
        
        int countgradetwelve =0;
        foreach(Person person in personLists)
        {
            if(person is Student student)
            {
                if(student.Getlevel() == "Grade 12")
            {
                countgradetwelve ++;
                
            }
            }
             
        }
        
        return countgradetwelve;
    }
    public void FetchScholar()
    {
        Console.WriteLine("       Teacher         ");
        Console.WriteLine("***********************");
        foreach(Person person in personLists)
        {
            if(person is Schorlar)
            {
                Console.WriteLine("{0} {1} {2}",person.GetGender(),person.GetName(),person.GetSurname());        
            }
           
        }

    }
    public void FetchStudent()
    {
         Console.WriteLine("       Student        ");
        Console.WriteLine("***********************");
        foreach(Person person in personLists)
        {
            
            if(person is Student)
            {
                Console.WriteLine("{0} {1} {2}",person.GetGender(),person.GetName(),person.GetSurname());
            }
            
        }
    }
    public void FetchTeacher()
    {
         Console.WriteLine("       Teacher        ");
        Console.WriteLine("***********************");
        foreach(Person person in personLists)
        {
            
            if(person is Teacher)
            {
                Console.WriteLine("{0} {1} {2}",person.GetGender(),person.GetName(),person.GetSurname());
                Console.WriteLine("*************************");
            }
            
        }
    }
    
    

    
}
