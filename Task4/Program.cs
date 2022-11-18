Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count <= number)
    { 
          if (number %2 == 0)  
        {
          Console.Write(count + " "); 
          count++;
        }

          else
          {
          count++;
          } 
    }  

Console.WriteLine();
