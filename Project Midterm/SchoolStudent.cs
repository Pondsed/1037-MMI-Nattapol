public class SchoolStudent : Person{
    private int school_grade;
    private string school_name;
    public SchoolStudent(string name_title,string firstname,string lastname ,int age,string allergic,string religion,int school_grade,string school_name)
    :base (name_title,firstname,lastname ,age,allergic,religion){
        this.school_grade = school_grade;
        this.school_name = school_name;
    }
    public int GetSchoolGrade(){
        return this.school_grade;
    }
}