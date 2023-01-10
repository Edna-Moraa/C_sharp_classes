namespace leetcode
{
    public class Mark
    {
        public char grade{get; set;}
        public char result(){
          if (grade == 'A')
          {
            Console.WriteLine("Excellent");

          }
          else if (grade == 'B')
          {
            Console.WriteLine("Better");
          }
          else if (grade == 'C')
          {
            Console.WriteLine("Good");
          }
          else if (grade == 'D')
          {
            Console.WriteLine("Pass");
          }
          else 
          {
            Console.WriteLine("Fail");
          }
          return grade;
          
        } 
        
    }

}