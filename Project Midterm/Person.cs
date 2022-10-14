public class Person {
    protected string name_title;
    protected string firstname;
    protected string lastname;
    protected int age;
    protected string allergic;
    protected string religion;

    public Person(string name_title,string firstname,string lastname ,int age,string allergic,string religion){
        this.name_title = name_title;
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.allergic = allergic;
        this.religion = religion;
    }
    public string GetNameTitle(){
        return this.name_title;
    }
    public string GetFirstName(){
        return this.firstname;
    }
    public string GetLastName(){
        return this.lastname;
    }
}