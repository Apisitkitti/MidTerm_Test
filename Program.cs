using System;
enum RegisterMenu
{
    RegisterNewScholar = 1,
    RegisterNewStudent ,
    RegisterNewTeacher, 
}
enum ChooseMenu
{
    RegisterMenu = 1,
    Exhibitor_statistics ,
    LoginMenu,
    
}
enum LoginMenu
{
    RegisterMenu = 1,
    AllScholarInfo ,
    AllStudentInfo ,
    AllTeacherInfo,
    Logout, 
}

class Program
{
    static PersonList personList;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        InputMenuFromKeyboard();
        
    }
    static void ListMenuLogin()
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine("          1.Register Menu");
        Console.WriteLine("          2.AllScholarInfo ");
        Console.WriteLine("          3.AllStudentInfo");
        Console.WriteLine("          4.AllTeacherInfo");
        Console.WriteLine("          5.Logout");
        Console.WriteLine("*********************************************");

    }
    static void Login()
    {
        
        Console.WriteLine("** Pls login **");
        Console.WriteLine("*********************************************");
        Console.WriteLine("You can input (exit) for return to main menu");
        Console.WriteLine("*********************************************");
        string email = EmailLogin();
        string password = PasswordLogin();
        if(personList.CheckALLFORLOGIN(email,password))
        {
            Console.Clear();
            ListMenuLogin();
            LoginMenu login = (LoginMenu)(int.Parse(Console.ReadLine()));
            LoginSwitchMenu(login);
            
        }
        else if(email.Equals ("exit"))
        {
         Console.Clear();
         InputMenuFromKeyboard();
        }
       else 
       {
        Console.WriteLine("Incorrect email or password. Please try again.");
        Console.ReadLine();
        Console.Clear();
        Login();
       }
        
        
    }
    
    static string EmailLogin()
    {
        Console.Write("Pls input your email:  ");
        return Console.ReadLine();
    }
    static string PasswordLogin()
    {
        Console.Write("Pls input your password:  ");
        return Console.ReadLine();
    }
    public static void InputMenuFromKeyboard()
    {
        Console.WriteLine("Welcome Everyone to our Idia camp Registration ");
        RegisterPannel();
        ChooseMenu menu = (ChooseMenu)(int.Parse(Console.ReadLine()));
        ChooseMenuSwtich(menu);
        
    }
    
    public static void InputRoleFromKeyboard()
    {
        Console.WriteLine("Pls Choose your role ");
        RolePannel();
        RegisterMenu register = (RegisterMenu)(int.Parse(Console.ReadLine()));
        RoleChooseMenu(register);
    }
    static void ChooseMenuSwtich(ChooseMenu choose)
    {
        if(choose == ChooseMenu.RegisterMenu)
        {
            InputRoleFromKeyboard();
        }
        else if(choose == ChooseMenu.Exhibitor_statistics)
        {
            PrintNumber();
        }
        else if(choose == ChooseMenu.LoginMenu)
        {
            Login();
        }      

    }
    static void ChooseMenuSwtich2(ChooseMenu choose)
    {
        if(choose == ChooseMenu.RegisterMenu)
        {
            InputRoleFromKeyboard();
        }
        else if(choose == ChooseMenu.Exhibitor_statistics)
        {
            PrintNumber();
        }
        else if(choose == ChooseMenu.LoginMenu)
        {
            Console.Clear();
            ListMenuLogin();
            LoginMenu login = (LoginMenu)(int.Parse(Console.ReadLine()));
            LoginSwitchMenu(login);
        }      

    }
    static void PrintNumber()
    {
        Console.WriteLine("Teacher Amount : {0}",personList.teacherCount());
        Console.WriteLine("Student Amount : {0}",personList.studentCount());
        Console.WriteLine("Schorlar Amount : {0}",personList.scholarCount());
        Console.WriteLine("Grade10 Amount : {0}",personList.GradeTenCount());
        Console.WriteLine("Grade11 Amount : {0}",personList.GradeElevenCount());
        Console.WriteLine("Grade12 Amount : {0}",personList.GradeTwelveCount());
        Console.ReadLine();
        BackToStart();
         
    }
    
    static void RoleChooseMenu(RegisterMenu register)
    {
        switch(register)
        {
            case RegisterMenu.RegisterNewScholar:
            ScholarRegister();
            break;
            case RegisterMenu.RegisterNewStudent:
            StudentRegister();
            break;
            case RegisterMenu.RegisterNewTeacher:
            TeacherRegister();
            break;
        }


    }
    

     static void LoginSwitchMenu(LoginMenu login)
        {
            switch(login)
            {
                case LoginMenu.RegisterMenu:
                InputMenuFromKeyboard2();
                break;
                case LoginMenu.AllScholarInfo:
                PrintAllScolarInfo();
                break;
                case LoginMenu.AllStudentInfo:
                PrintAllStudentInfo();
                break;
                case LoginMenu.AllTeacherInfo:
                PrintAllTeacherInfo();
                break;
                case LoginMenu.Logout:
                BackToStart();
                break; 
            }
        }
        static void PrintAllScolarInfo()
        {
            personList.FetchScholar();
            Console.ReadLine();
            Console.Clear();
        }
        static void PrintAllStudentInfo()
        {
            personList.FetchStudent();
            Console.ReadLine();
            Console.Clear();
        }
        static void PrintAllTeacherInfo()
        {
            personList.FetchTeacher();
            Console.ReadLine();
            Console.Clear();
        }
    static void ScholarRegister()
    {
        bool Adminchecker;
        PrintHeaderRegisterScholar();
        Schorlar schorlar = new Schorlar(ChooseGender(),InputName(),InputSurname(),InputScholarId(),InputAge(),InputLose(),InputReligion(),Adminchecker=IsAdmin(),InputEmail(Adminchecker),InputPassword(Adminchecker));
        Schorlar CheckError = personList.CheckSchorlar(schorlar);
        if(CheckError != null)
        {
            Program.personList.AddNewPeople(schorlar); 
            BackToStart();
        }
        else if(CheckError == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            ScholarRegister();
        }
        
    }
    static void StudentRegister()
    {
       
        PrintHeaderRegisterStudent();
        Student student = new Student(ChooseGender(),InputName(),InputSurname(),InputAge(),ChooseGrade(),InputLose(),InputReligion(),InputSchool());
        Student CheckError =  personList.CheckStudent(student);
        if(CheckError != null)
        {
            Program.personList.AddNewPeople(student);
            BackToStart();
        }
        else if(CheckError == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            StudentRegister();
        }
        
    }
    
    static void TeacherRegister()
    {
         bool Adminchecker;
        PrintHeaderRegisterTeacher();
        Teacher teacher = new Teacher(ChooseGender(),InputName(),InputSurname(),InputAge(),ChooseRole(),InputLose(),InputReligion(),CarNum(),Adminchecker=IsAdmin(),InputEmail(Adminchecker),InputPassword(Adminchecker));
        Teacher CheckError = personList.CheckTeacher(teacher);
        if(CheckError != null)
        {
            Program.personList.AddNewPeople(teacher);
            BackToStart();
        }
        else if(CheckError == null)
        {
            Console.Clear();
            Console.WriteLine("User is already registered. Please try again.");
            TeacherRegister();
        }
        
    }

    static void RegisterPannel()
    {
        Console.Clear();
        Console.WriteLine("Choose your Menu");
        Console.WriteLine("********************************");
        Console.WriteLine("         1.Register Menu");
        Console.WriteLine("         2.Exhibitor_statistics");
        Console.WriteLine("         3.Login Menu  ");
        Console.WriteLine("********************************");

    }
    static void RolePannel()
    {
        Console.Clear();
        Console.WriteLine("Choose your role");
        Console.WriteLine("********************************");
        Console.WriteLine("         1.Scholar ");
        Console.WriteLine("         2.Student");
        Console.WriteLine("         3.Teacher  ");
        Console.WriteLine("********************************");
    }

    
    static void InputNewStudentFromKeyboard()
    {
        
        PrintHeaderRegisterScholar();

    }
    public static void PrintHeaderRegisterStudent()
    {
         
        Console.WriteLine("Register New Student");
        Console.WriteLine("********************");
    }
    public static void PrintHeaderRegisterScholar()
    {
        
        Console.WriteLine("Register New Scholar");
        Console.WriteLine("********************");
    }
     public static void PrintHeaderRegisterTeacher()
    {
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
    }
    public static string ChooseGender()
    {
        Console.WriteLine("Choose your prefix");
        Console.WriteLine("1. Mr.");
        Console.WriteLine("2. Ms. ");
        Console.WriteLine("3. Mrs. ");
        Console.WriteLine("********************");
        int Choose = int.Parse(Console.ReadLine());
        return GenderChose(Choose);

    }
    public static string GenderChose(int chooser)
    {
       if(chooser==1)
       {
        return "Mr.";
       }
       else if(chooser == 2)
       {
        return "Ms.";
       }
       else if(chooser == 3)
       {
        return "Mrs.";
       }
       else
       {
        Console.WriteLine("Pls Choose again");
        return ChooseGender();
       }
       
    }
    public static string InputName()
    {
        Console.Write("Pls input Name: ");
        return Console.ReadLine();
    }
    public static string InputSurname()
    {
        Console.Write("Pls input Surname: ");
        return Console.ReadLine();
    }
    public static string InputScholarId()
    {
        Console.Write("Pls input ScholarID: ");
        return Console.ReadLine();
    }
    public static string InputStudentId()
    {
        Console.Write("Pls input StudentID: ");
        return Console.ReadLine();
    }
    public static int InputAge()
    {
        Console.Write("Pls input Age : ");
        return int.Parse(Console.ReadLine());
    }
    public static string InputLose()
    {
        Console.Write("Pls input Lose : ");
        return Console.ReadLine();
    }
    public static string InputSchool()
    {
        Console.Write("Pls input School : ");
        return Console.ReadLine();
    }
     static string ChooseRole()
        {
             Console.Clear();
       Console.WriteLine("Pls Choose Role");
        Console.WriteLine("********************");
        Console.WriteLine("    1.      Dean   ");
        Console.WriteLine("    2. Head Department ");
        Console.WriteLine("    3. Full-time Teacher ");
        Console.WriteLine("********************"); 
        int chooser = int.Parse(Console.ReadLine());
        return GradeInput(chooser);
        
        }
        
        static string RoleInput (int chose)
        {
             if(chose == 1)
        {
            return "Dean";
        }
        else if(chose == 2)
        {
            return "Head Department";
        }
        else if(chose == 3)
        {
            return "Full-time Teacher";
        }
        else
        {
            Console.WriteLine("Pls choose role again");
            return ChooseRole();
        }
        }
    public static string InputReligion()
    {
        Console.Clear();
        Console.WriteLine("Pls Choose Religion ");
        Console.WriteLine("********************");
        Console.WriteLine("1. Buddhist");
        Console.WriteLine("2. Christian ");
        Console.WriteLine("3. Islam ");
        Console.WriteLine("4. Other ");
        Console.WriteLine("********************");
        int Chooser = int.Parse(Console.ReadLine());
        return ReligionChose(Chooser);

    }
    public static string ReligionChose(int choose)
    {
     if(choose == 1)
     {
        return "Buddhist" ;
     }
     else if(choose == 2)
     {
        return "Christian";
     }
     else if(choose == 3)
     {
        return "Islam";
     }
     else if(choose == 4)
     {
        Console.Write("Other: ");
        return Console.ReadLine();
     }
     else
     {
        Console.Write("Please Input again: ");
        return InputReligion();
     }
    }
    static string ChooseGrade()
    {
        Console.Clear();
       Console.WriteLine("Pls Choose Grade ");
        Console.WriteLine("********************");
        Console.WriteLine("    1. Grade 10 ");
        Console.WriteLine("    2. Grade 11 ");
        Console.WriteLine("    3. Grade 12 ");
        Console.WriteLine("********************"); 
        int chooser = int.Parse(Console.ReadLine());
        return GradeInput(chooser);
    }
    static string GradeInput(int chose)
    {
        if(chose == 1)
        {
            return "Grade 10";
        }
        else if(chose == 2)
        {
            return "Grade 11";
        }
        else if(chose == 3)
        {
            return "Grade 12";
        }
        else
        {
            Console.WriteLine("Pls choose grade again");
            return ChooseGrade();
        }
       

    }
    static bool ConditionCar()
    {
        Console.WriteLine("Do you have car (Y/N) : ");
        char chose = char.Parse(Console.ReadLine());
         if(chose == 'Y' || chose == 'y')
        {
            return true; 
            
        }
        else if(chose == 'N' || chose == 'n')
        {
            return false;
            
            
        }
        else 
        {   
            Console.WriteLine("Pardon?");
            return ConditionCar();
        }
    }
    static string CarNum()
    {
        if(ConditionCar())
        {
             Console.WriteLine("Your Car registration: ");
                return Console.ReadLine();     
        }
        return null;
       
        
    }
    static bool IsAdmin()
    {
       Console.Write("Are you admin? (Y/N): ");
       char chose = char.Parse(Console.ReadLine());
       if(chose == 'Y' || chose == 'y')
        {
            return true; 
            
        }
        else if(chose == 'N' || chose == 'n')
        {
            return false;
            
        }
        else 
        {   
            Console.WriteLine("Pardon?");
            return IsAdmin();
        }
    }
    static string InputEmail(bool check)
    {
        if(check)
        {
             Console.Write("Pls input Email: ");
            return Console.ReadLine();
            
            
        }
        return null;
       
    }
     static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personList = new PersonList();
    }
    
    static void BackToStart()
    {
     InputMenuFromKeyboard();   
    }
    static void BackToStart2()
    {
     InputMenuFromKeyboard2();
    }
    static void InputMenuFromKeyboard2()
    {
        Console.WriteLine("Welcome Everyone to our Idia camp Registration ");
        RegisterPannel();
        ChooseMenu menu = (ChooseMenu)(int.Parse(Console.ReadLine()));
        ChooseMenuSwtich2(menu);
    }
    static string InputPassword(bool check)
    {
        if(check)
        {
             Console.Write("Pls input Password: ");
            return Console.ReadLine();
            
        }
        return null;
       
    }
    
     
}



