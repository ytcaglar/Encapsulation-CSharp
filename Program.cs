using System;

namespace Encapsulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Hakan";
            student1.surname = "Koç";
            student1.classNum = 12 ;
            student1.studentID = 001 ;
            student1.StudentInfo();
            System.Console.WriteLine("---------------------------------");
            Student student2 = new Student{name = "Mehmet",surname = "Yılmaz",classNum = 11, studentID = 002};
            student2.StudentInfo();
            System.Console.WriteLine("---------------------------------");

            Student student3 = new Student("Mert","Arı",10,003);
            student3.StudentInfo();
            System.Console.WriteLine("---------------------------------");
            student3.upgradeClass();
            student3.StudentInfo();
            System.Console.WriteLine("---------------------------------");
            student3.upgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.upgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.upgradeClass();
            student3.StudentInfo();

            
            System.Console.WriteLine("---------------------------------");
            student3.upgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.downgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.downgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.downgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.downgradeClass();
            student3.StudentInfo();

            System.Console.WriteLine("---------------------------------");
            student3.downgradeClass();
            student3.StudentInfo();



        }
    }

    class Student
    {
        private string _Name;
        private string _Surname;
        private int _ClassNum;
        private int _StudentID;

        public int studentID { 
            get
            {
                return this._StudentID;
            } 
            set
            { 
                this._StudentID = value; 
            } 
        }

        public int classNum { 
            get
            {
                return this._ClassNum;
            } 
            set
            {   
                if(value<9){
                    System.Console.WriteLine("Sınıf Numarası min 9 olabilir.");
                    value = 9;
                }else if(value>12){
                    System.Console.WriteLine("Sınıf Numarası maks 12 olabilir.");
                    value = 12;
                }else{

                }
                this._ClassNum = value; 
                
                
            } 
        }

        public string name { 
            get
            {
                return this._Name;
            } 
            set
            { 
                this._Name = value; 
            } 
        }
        public string surname { 
            get
            {
                return this._Surname;
            } 
            set
            { 
                this._Surname = value; 
            } 
        }
        
        public Student()
        {
            
        }
        public Student(string name, string surname, int classNum, int studentID)
        {
            this._StudentID = studentID;
            this._Name = name;
            this._Surname = surname;
            this._ClassNum = classNum;
        }
        public void StudentInfo(){
            System.Console.WriteLine("Öğrenci Bilgisi");
            System.Console.WriteLine("Öğrenci Adı: {0}",this._Name);
            System.Console.WriteLine("Öğrenci Soyadı: {0}",this._Surname);
            System.Console.WriteLine("Öğrenci No: {0}",this._StudentID);
            System.Console.WriteLine("Öğrenci Sınıfı: {0}",this._ClassNum);
        }

        public void upgradeClass(){
            this.classNum++;
        }
        public void downgradeClass(){
            this.classNum--;
        }
    }
}