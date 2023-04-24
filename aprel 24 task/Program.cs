

using aprel_24_task;

Student stu1 = new("aqsin","hummatov","p237",85);

Student stu2 = new("Kenan", "Gehremanov", "P137", 75);

Student stu3 = new("Ebdul", "Sakirov", "p123", 79);

Console.WriteLine(stu1.Info());



if (stu3.IsGraduated() == true)
{
    Console.WriteLine(" 2-ci Imtahana  kecid ede bilersiz");
}
else
{
    Console.WriteLine("Imtaana kecid ede bilmersiniz");
}

Console.WriteLine(stu3.IsGraduated());
