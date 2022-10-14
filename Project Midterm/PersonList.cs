using System;
using System.Collections.Generic;
public class PersonList{
    private List<Person> personList;
    public PersonList(){
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person){
        this.personList.Add(person);
    }
    public void FetchPersonNum(){
        Console.WriteLine("Guest Statistic");
        Console.WriteLine("-----------------");
            int TeachNum = 0;
            int SchoolStudentNum = 0;
            int UniversityStudentNum = 0;
        foreach(Person person in this.personList){      
            if (person is Teacher){
                TeachNum++;
            }else if (person is SchoolStudent){
                SchoolStudentNum++;
            }else if (person is UniversityStudent){
                UniversityStudentNum++;
            }else {
            }
        }
        Console.WriteLine("Teacher Registration amounnt : {0} ",TeachNum);
        Console.WriteLine("School Student Registration amount : {0}",SchoolStudentNum);
        Console.WriteLine("University Student amount : {0}",UniversityStudentNum);
        Console.ReadLine();
        Console.Clear();

    }
    public int ListNum(){
            int TeachNum = 0;
            int SchoolStudentNum = 0;
            int UniversityStudentNum = 0;
            foreach(Person person in this.personList){      
            if (person is Teacher){
                TeachNum++;
            }else if (person is SchoolStudent){
                SchoolStudentNum++;
            }else if (person is UniversityStudent){
                UniversityStudentNum++;
            }else {
            }
        }
        return TeachNum + SchoolStudentNum + UniversityStudentNum;
    }
    public void FetchUniversityStudentInfo(){
        Console.WriteLine("List University Student");
        Console.WriteLine("------------------------");
        foreach(Person person in this.personList){
            if (person is UniversityStudent){
                Console.WriteLine("{0}{1} {2}",person.GetNameTitle(),person.GetFirstName(),person.GetLastName());
            }
        }
        Console.ReadLine();
    }
    public void FetchSchoolStudentInfo(){
        Console.WriteLine("List School Student");
        Console.WriteLine("------------------------");
        foreach(Person person in this.personList){
            if (person is SchoolStudent){
                Console.WriteLine("{0}{1} {2}",person.GetNameTitle(),person.GetFirstName(),person.GetLastName());
            }
        }
        Console.ReadLine();
    }
    public void FetchTeacherInfo(){
        Console.WriteLine("List Teacher");
        Console.WriteLine("------------------------");
        foreach(Person person in this.personList){
            if (person is Teacher){
                Console.WriteLine("{0}{1} {2}",person.GetNameTitle(),person.GetFirstName(),person.GetLastName());
            }
        }
        Console.ReadLine();
    }
}
    
