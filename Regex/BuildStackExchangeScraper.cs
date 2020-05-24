using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        string pattern = @"id=""question-summary-(\d+)""|class=""question-hyperlink"">(.+)<\/a>|class=""relativetime"">(.+)<\/span>";
        using(var sr = new StreamReader(Console.OpenStandardInput()))
        {
            var lines = sr.ReadToEnd().Split('\n');
            List<string> list = new List<string>();
            foreach(var content in lines){
                MatchCollection matches = Regex.Matches(content, pattern);
                foreach (Match match in matches) {
                    GroupCollection data = match.Groups;
                    for (var i = 1; i <= 3; i++){
                        if (data[i].Success){
                            list.Add(data[i].Value);
                        }
                    }
                    if (list.Count() == 3){
                        Console.WriteLine(string.Join(";", list));
                        list.Clear();
                    }
                }
            }
        }
    }
}