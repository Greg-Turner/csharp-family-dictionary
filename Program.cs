using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("Wife", new Dictionary<string, string>(){ 
                {"name", "Renee"},
                {"age", "42"}
            });
            myFamily.Add("Son", new Dictionary<string, string>(){
                {"name", "Christian"},
                {"age", "24"}
            });
            myFamily.Add("Son", new Dictionary<string, string>(){
                {"name", "Collin"},
                {"age", "21"}
            });    
            myFamily.Add("Son", new Dictionary<string, string>(){
                {"name", "Kyle"},
                {"age", "15"}
            });
            myFamily.Add("Son", new Dictionary<string, string>(){
                {"name", "Kent"},
                {"age", "14"}
            });

            foreach(KeyValuePair <string, Dictionary<string,string>> member in myFamily){
                Console.WriteLine($"{member.Value["name"]}, my {member.Key} is {member.Value["age"]} years old.");
            }
        }
    }
}