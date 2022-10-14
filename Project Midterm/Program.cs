public class Program{
    static PersonList personList;
    static void Main(string[] args){
        PreparePersonList();
        FirstMenu();
        SecondMenu();
    }
    static void PreparePersonList(){
        Program.personList = new PersonList();
    }
    static void FirstMenu(){
        Console.WriteLine("Hello! Welcome to Idia Camp 2022!.");
        Console.WriteLine("Input number to choose menu");
        Console.WriteLine("1 : Register Menu");
        Console.WriteLine("2 : Show Guest Statistic ");
        Console.WriteLine("3 : Login Menu");
        Console.Write("Choose Menu : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            RegisterMenu();
            break;
            case 2:
            ShowGuestStatistic();
            break;
            case 3:
            LoginMenu();
            break;
            default:
            break;
        }  
    }
    static void SecondMenu(){
        Console.WriteLine("Welcome to Administrator Menu");
        Console.WriteLine("Input Number to choose menu");
        Console.WriteLine("1 : Register Menu");
        Console.WriteLine("2 : Show University Student info ");
        Console.WriteLine("3 : Show School Student info");
        Console.WriteLine("4 : Show Teacher Info");
        Console.WriteLine("5 : Logout");
        Console.Write("Choose Menu : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            RegisterMenu();
            break;
            case 2:
            ShowUniversityStudentInfo();
            break;
            case 3:
            ShowSchoolStudentInfo();
            break;
            case 4:
            ShowTeacherInfo();
            break;
            case 5:
            Logout();
            break;
            default:
            break;
        }

    }
    static void LoginMenu(){
        Console.Write("Please input email : ");
        string email = Console.ReadLine();
        Console.Write("Please input password");
        string password = Console.ReadLine();
        SecondMenu();
    }
    static void RegisterMenu(){
        Console.WriteLine("Please select your Guest type");
        Console.WriteLine("1 : School Student");
        Console.WriteLine("2 : University Student");
        Console.WriteLine("3 : Teacher");
        Console.Write("Choose Type : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            SchoolStudentRegisterMenu();
            break;
            case 2:
            UniversityStudentRegisterMenu();
            break;
            case 3:
            TeacherRegisterMenu();
            break;
            default:
            break;
        }
    }
    static void SchoolStudentRegisterMenu(){
        SchoolStudent schoolStudent = new SchoolStudent(SelectNameTitle(),InputFirstName(),InputLastName(),InputAge(),InputAllergic(),SelectReligion(),SelectSchoolGrade(),InputSchoolName());
        Program.personList.AddNewPerson(schoolStudent);
        Console.Clear();
        FirstMenu();
    }
    static void UniversityStudentRegisterMenu(){
        UniversityStudent universityStudent = new UniversityStudent(SelectNameTitle(),InputFirstName(),InputLastName(),InputAge(),InputAllergic(),SelectReligion(),InputStudentID(),SelectAdminStatus(),"none","none");      
        if(universityStudent.GetAdminstatus() == true){
            universityStudent.SetEmail();
            universityStudent.SetPassword();
        }
        Program.personList.AddNewPerson(universityStudent);
        Console.Clear();
        FirstMenu();
    }
    static void TeacherRegisterMenu(){
        Teacher teacher = new Teacher(SelectNameTitle(),InputFirstName(),InputLastName(),InputAge(),InputAllergic(),SelectReligion(),SelectPosition(),SelectCarUse(),0,SelectAdminStatus(),"none","none");
        if(teacher.GetCarUse() == true){
            teacher.SetPlateNumber();
        }
        if(teacher.GetAdminstatus() == true){
            teacher.SetEmail();
            teacher.SetPassword();
        }
        Program.personList.AddNewPerson(teacher);
        Console.Clear();
        FirstMenu();
    }
    static string SelectNameTitle(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Mr.");
        Console.WriteLine("2 : Mrs.");
        Console.WriteLine("3 : Miss");
        Console.Write("Please Select Number of your Name title : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Mr.";
            break;
            case 2:
            return "Mrs.";
            break;
            case 3:
            return "Miss.";
            break;
            default:
            return BackTotheSelectNameTitle();    
        }
        }
        static string BackTotheSelectNameTitle(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2,3");
            return SelectNameTitle();
        }
        static string InputFirstName(){
            Console.Write("First Name : ");
            return Console.ReadLine();
        }
        static string InputLastName(){
            Console.Write("Last Name : ");
            return Console.ReadLine();
        }
        static int InputAge(){
            Console.Write("Age : ");
            return int.Parse(Console.ReadLine());
        }
        static string InputAllergic(){
            Console.Write("Allergic : ");
            return Console.ReadLine();
        }
        static string InputSchoolName(){
            Console.Write("School Name : ");
            return Console.ReadLine();
        }
        static string SelectReligion(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Buddhism");
        Console.WriteLine("2 : Muslim");
        Console.WriteLine("3 : Cristian");
        Console.WriteLine("4 : Other");
        Console.Write("Please Select Number of your Religion : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Buddhism";
            break;
            case 2:
            return "Muslim";
            break;
            case 3:
            return "Cristian";
            break;
            case 4:
            return "Other";
            default:
            return BackTotheSelectReligion();
        }
        }
        static string BackTotheSelectReligion(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2,3,4");
            return SelectReligion();
        }
        static string SelectPosition(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Dean");
        Console.WriteLine("2 : Head of Department");
        Console.WriteLine("3 : Professor");
        Console.Write("Please Select Number of your Position : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return "Dean";
            break;
            case 2:
            return "Head of Department";
            break;
            case 3:
            return "Professor";
            break;
            default:
            return BackTotheSelectPosition();
        }
        }
        static string BackTotheSelectPosition(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2,3");
            return SelectPosition();
        }
        static int SelectSchoolGrade(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Grade 4");
        Console.WriteLine("2 : Grade 5");
        Console.WriteLine("3 : Grade 6");      
        Console.Write("Please Select Number of your School Grade : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return 4;
            break;
            case 2:
            return 5;
            break;
            case 3:
            return 6;
            break;
            default:
            return BackTotheSelectSchoolGrade();
        }
        }
        static int BackTotheSelectSchoolGrade(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2,3");
            return SelectSchoolGrade();
        }
        static int InputStudentID(){
            Console.Write("Student ID : ");
            return int.Parse(Console.ReadLine());
        }
        static int InputPlateNumber(){
            if(SelectCarUse() == true){
                Console.Write("Plate Number : ");
                return int.Parse(Console.ReadLine());
            }
            else{
                return 0;
            }
        }
                
            
        static bool SelectAdminStatus(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Yes");
        Console.WriteLine("Other Number : No");    
        Console.Write("Are you Administrator? : ");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return true;
            break;
            default:
            return false;
            break;
            
        }
        }       
        static bool SelectCarUse(){
        Console.WriteLine("Please Select");
        Console.WriteLine("1 : Yes");
        Console.WriteLine("2 : No");
        Console.Write("Do you use your car?");
        int input = int.Parse(Console.ReadLine());
        switch(input){
            case 1:
            return true;
            break;
            case 2:
            return false;
            default:
            return BackTotheSelectCarUse();
            break;
            
        }
        }
        static bool BackTotheSelectCarUse(){
            Console.Clear();
            Console.WriteLine("Wrong number just use only 1,2");
            return SelectCarUse();
        }
        static void ShowGuestStatistic(){
            Program.personList.FetchPersonNum();
            FirstMenu();
        }
        static void ShowUniversityStudentInfo(){
            Program.personList.FetchUniversityStudentInfo();
            Console.Clear();
            SecondMenu();
        }
        static void ShowSchoolStudentInfo(){
            Program.personList.FetchSchoolStudentInfo();
            Console.Clear();
            SecondMenu();
        }
        static void ShowTeacherInfo(){
            Program.personList.FetchTeacherInfo();
            Console.Clear();
            SecondMenu();
        }
        static void Logout(){
            FirstMenu();
        }
        }




    



