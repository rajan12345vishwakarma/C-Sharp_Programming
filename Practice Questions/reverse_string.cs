// first method
 public static void Main()
 {
     string s = "when you talk you are only";
     string str = string.Empty;
     Console.WriteLine(s);
     for (int i = 0; i < s.Length; i++)
     {
         str += s[i];
         if (s[i] == ' ' || i == s.Length -1)
         {
             if (i == s.Length - 1) Console.Write(" ");

             for (int j = str.Length - 1; j >= 0 && i < s.Length; j--)
             {
                  Console.Write(str[j]);
             }
             str = string.Empty;
         }
     }
     Console.ReadLine();
 }
/*
// second method
           public static void Main()
           {
               string s = "hello mr how are you";
               var str = s.Split(' ');
               foreach (var item in str)
               {
                   for (int i = item.Length - 1 ; i >= 0; i--)
                   {
                       Console.Write(item[i]);
                   }
                   Console.Write(" ");
               }
               Console.ReadLine();
           }

*/
