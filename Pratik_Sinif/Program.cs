using Pratik_Sinif.Models;

Teacher teacher = new Teacher()
{
    Name = "Sinan",
    SurName = "Ferza",
    BirthDay = 1981

};

Student student = new Student()
{
    Name = "Selim",
    SurName = "Bezgin",
    BirthDay = 1998
};

Console.WriteLine("Öğretmenimiz " + teacher.Name + " " + "derslerinde başarılı örnekler kullanmaktadır.");
Console.WriteLine("Öğrencilerimizden de " + student.Name + " "+ student.BirthDay + " "+ "yılında doğduğunu anlattı.");