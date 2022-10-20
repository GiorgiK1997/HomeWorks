namespace HomeWork__7___Tas;


internal class Program
{
    static void Main(string[] args)
    {


        int[] weekDays = new int[6];
        weekDays[0] = 7;
        weekDays[1] = 7;
        weekDays[2] = 5;
        weekDays[3] = 6;
        weekDays[4] = 7;
        weekDays[5] = 7;
        int result = 0;
        for (int i = 1; i < weekDays.Length; i++)
        {
            if (weekDays[i] > weekDays[i-1])
            {
                result  = result + 1;
                
            }
            
        }
        Console.WriteLine(result);
        
            
       
      
    }
} 


