//Initialize  an array of 10 students and sort them by mark in ascending 
//order. Use the interface System.IComparable<T>


using leetcode;

public class Program
{
  
  
    
    static void Main()
    {
       List<Student>students = new List<Student>();
       {
        students.Add(new Student{
          Name = "Edna",
          mark = new Mark{grade = 'A'}
        
        });
        students.Add(new Student{
          Name = "Moraa",
          mark = new Mark{grade ='A'}
        
        });
        students.Add(new Student{
          Name = "Marko",
          mark = new Mark{grade = 'B'}
        
        });
        students.Add(new Student{
          Name = "Hussein",
          mark = new Mark{grade = 'C'}
        
        });
        students.Add(new Student{
          Name = "Sam",
          mark = new Mark{grade = 'F'}
        
        });
        students.Add(new Student{
          Name = "Cyn",
          mark = new Mark{grade = 'F'}
        
        });
        students.Add(new Student{
          Name = "Kevo",
          mark = new Mark{grade = 'D'}
        
        });
        students.Add(new Student{
          Name = "Aggy",
          mark = new Mark{grade = 'B'}
        
        });
        students.Add(new Student{
          Name = "Cyril",
          mark = new Mark{grade = 'A'}
        
        });
        students.Add(new Student{
          Name = "Emily",
          mark = new Mark{grade = 'C'}
        
        });
        var grading= students.OrderBy(x => x.mark.grade);
       
        foreach (var item in grading)
        {
          //char Grd = 
          
          Console.WriteLine($"Student name: {item.Name}  performance: {item.mark.grade} ");
          item.mark.result();
          
          

        };
         

    }
       
      
       
       

  }
  
  
 
  
}