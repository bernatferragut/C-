// Exercice 1

using System;
using System.IO;
using System.Linq;
namespace  Exercise_1
{    
    class Program
    {     
        static void Main()
        { 
            var path = @"C:\Users\Sarxan\Documents\test.txt"; 
            Console.WriteLine("number of words:"+NumberofWords(path)); 
        }
        public static int NumberofWords(string textfilepath)
        {  
            char[] chars = {' ', ',', '.', '?', '!',';', ':', '\'','-','/','=' };
            var text = File.ReadAllText(textfilepath).Replace("\r\n"," "); 
            var count = 0;  
            for (var i = 0; i < text.Length-1; i++) 
            {
                if (!chars.Contains(text[i])&&chars.Contains(text[i+1]))  // check for double,tripple whitespaces,comma etc  
            {   
            count++;   
        }  
        return count;
    }
}
// Version 2 Hacked

staticvoidMain(string[] args)
{
    var path =@"C:\Users\Sarxan\Documents\test.txt";
    Console.WriteLine("number of words:"+SplitWords(path).Length);
}
publicstaticstring[]SplitWords(string filename)
{    
    filename=File.ReadAllText(filename).Replace("\r\n"," ");
    returnRegex.Split(filename,@"\W+");
}