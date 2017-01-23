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

// Hi Bernat,

// Are you familiar with dictionaries? 
//A better approach to keep track of the count of each word is to use a dictionary. 
//With a dictionary, you get fast lookups. So you don't need these nested loops to find them and count them.
//You need to iterate over the words, and for each word, look it up in the dictionary 
//and increase its count by 1.
// Then, you loop over all dictionary and find the words with the the highest repetitions.
// I probably need to remove this exercise here as it's a bit too complicated for the basics 
// course. Give me some time to design another similar but simpler exercise.

var MyDict = new Dictionary< int Key, string Value> ();