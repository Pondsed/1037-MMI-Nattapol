public class UniversityStudent:Person{
    private int student_ID;
    private bool admin_status;
    private string email_address;
    private string password;
    public UniversityStudent(string name_title,string firstname,string lastname ,int age,string allergic,string religion,int student_ID,bool admin_status,string email_address,string password)
    :base (name_title,firstname,lastname ,age,allergic,religion){
        this.student_ID =student_ID;
        this.admin_status =admin_status;
        this.email_address = email_address;
        this.password = password;
    } 
    public bool GetAdminstatus(){
        return this.admin_status;
    }
    public string GetEmail(){
        return this.email_address;
    }
    public string GetPassword(){
        return this.password;
    }
    public void SetEmail(){
        Console.WriteLine("Email : ");
        this.email_address = Console.ReadLine();
    }
    public void SetPassword(){
        Console.WriteLine("Password : ");
        this.password = Console.ReadLine();
    }
}