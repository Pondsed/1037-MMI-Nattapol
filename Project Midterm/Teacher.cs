public class Teacher : Person{
private string position;
private bool IsUse_car;
private int plate_number;
private bool admin_status;
private string email_address;
private string password;
public Teacher (string name_title,string firstname,string lastname ,int age,string allergic,string religion,string position,bool IsUse_car,int plate_number,bool admin_status,string email_address,string password)
: base (name_title,firstname,lastname ,age,allergic,religion){
    this.position = position;
    this.IsUse_car = IsUse_car;
    this.plate_number = plate_number;
    this.admin_status = admin_status;
    this.email_address = email_address;
    this.password = password;
}
 public bool GetCarUse(){
        return this.IsUse_car;
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
    public void SetPlateNumber(){
        Console.WriteLine("Plate Number : ");
        this.plate_number = int.Parse(Console.ReadLine());
    }
}