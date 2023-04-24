using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel_24_task;

internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;



    public Student(string name, string surname, string group, double point)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
    }

    public string FullName()
    {
        return $"{Name} {Surname}";

    }

    public string Info()
    {
        return $"{FullName()} {Point} {Group}";
    }


    public bool IsGraduated()
    {
       if(Point >= 80)
        {
            return true;
        }
        else
        {
            return false ;
        }
    }









}

