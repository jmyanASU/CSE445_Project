using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;
using static System.Net.WebRequestMethods;

namespace WcfService2
{

    public class Service1 : IService1
    {

        
        private const string RapidApiKey = "0d4baa525bmsha39b94b38475040p129ffcjsn39f2be914049";
        private const string SpoonacularApiUrl = "https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/random?tags=vegetarian%2Cdessert&number=1";

        //Find random (popular) recipes.
        public string GetRandomRecipe()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SpoonacularApiUrl);
            request.Method = "GET";

            request.Headers.Add("X-RapidAPI-Key", RapidApiKey);
            request.Headers.Add("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return reader.ReadToEnd();
                    }
                    else
                    {
                        // Handle API request errors here
                        throw new Exception($"HTTP request failed with status code: {response.StatusCode}");
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle exceptions here
                throw ex;
            }
        }

    


        public string GetWineDescription(string wine)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/food/wine/description?wine={wine}"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "0d4baa525bmsha39b94b38475040p129ffcjsn39f2be914049" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
                };

                using (var response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public string AnalyzeRecipe(string recipe)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/queries/analyze?q=salmon%20with%20fusilli%20and%20no%20nuts"),
                    Headers =
    {
        { "X-RapidAPI-Key", "0d4baa525bmsha39b94b38475040p129ffcjsn39f2be914049" },
        { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
    },
                };

                using (var response = client.SendAsync(request).Result)
                {
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        /* Analyze a string of words and filter out the function words (stop words)
            such as “a”, “an”, “in”, “on”, “the”, “is”, “are”, “am”, and any words that are not
                meaningful to be counted at the top words in search. You must also filter out the
            XML element tag names and attribute names

             added ValidateRequest="false" in Default.aspx
         */
        public string WordFilter(string input)
        {

            // Define an array of stop words
            string[] stopWords = { "a", "an", "in", "on", "the", "is", "are", "am" };

            // Use a regular expression to match XML tags and attributes
            string xmlPattern = @"<[^>]+>|[a-zA-Z0-9]+=['""][^'""]*['""]";

            input = Regex.Replace(input, xmlPattern, " ");


            // Split the input string into words, Filter out stop words
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(word => !stopWords.Contains(word.ToLower()))
                             .ToArray();


            // Join the filtered words back into a string
            string filteredStr = string.Join(" ", words);

            return filteredStr;


        }



        /*
         * Convert a number, e.g., a phone number, into an easy-to-remember
        character/digit string. All valid words, e.g., helloClass are easy to remember. Other
        commonly used character/digit strings, such as CSE100, CSE445, and SCIDSE,
        are easy to remember strings too.

        */
        private string[] easyToRememberWords = new string[]
        {

        };


        public string Number2Words(string number)
        {



            // Define a dictionary to map digits to corresponding letters
            Dictionary<char, string> digitToLetters = new Dictionary<char, string>
            {
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"}
            };



            // Initialize the result list with an empty string
            List<string> results = new List<string> { "" };

            foreach (char digit in number)
            {
                if (digit == '0' || digit == '1')
                {
                    // Keep 0 and 1 as is
                    foreach (var index in results.ToArray())
                    {
                        results[results.IndexOf(index)] += digit;
                    }
                }
                else if (digitToLetters.ContainsKey(digit))
                {
                    // Map the digit to its corresponding letters
                    string letters = digitToLetters[digit];

                    // Create new combinations by appending each letter to existing results
                    List<string> newResults = new List<string>();
                    foreach (var letter in letters)
                    {
                        foreach (var result in results)
                        {
                            newResults.Add(result + letter);
                        }
                    }

                    results = newResults;
                }
                else
                {
                    // If the digit doesn't match any rules, you can handle it as needed
                    // In this example, we keep it as is
                    foreach (var index in results.ToArray())
                    {
                        results[results.IndexOf(index)] += digit;
                    }
                }
            }

            // Combine all results into a single string, separated by tabs
            return string.Join("\t", results);
        }
    }
}