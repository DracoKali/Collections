using System;
using System.Collections.Generic;

namespace Collections {
    class Program {

        static void Main (string[] args) {
            // Basic Strings
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] name = { "Teak", "Gwen", "Freja", "Janak", "Jodi" };
            bool[] tf = { true, false, true, false, true, false, true, false, true, false };
            bool[] boolArray = new bool[10];
            for (int i = 0; i < 10; i += 2) {
                boolArray[i] = true;
            }
            // Multiplication Table
            int[, ] mult = new int[10, 10];
            for (int x = 0; x < 10; x++) {
                for (int y = 0; y < 10; y++) {
                    mult[x, y] = (x + 1) * (y + 1);
                }
            }
            //Displays the multiplication table
            for (int x = 0; x < 10; x++) {
                string display = "[ ";
                for (int y = 0; y < 10; y++) {
                    display += mult[x, y] + ", ";
                    //Add an extra space for single digit values
                    if (mult[x, y] < 10) {
                        display += " ";
                    }
                }
                display += "]";
                Console.WriteLine (display);

            }
            // List of Flavors
            List<string> flavors = new List<string> ();
            flavors.Add ("Pistachio");
            flavors.Add ("Mint");
            flavors.Add ("Cookie Dough");
            flavors.Add ("Vanilla");
            flavors.Add ("Choclate");
            flavors.Add ("Coffee");
            flavors.Add ("Toffee");
            Console.WriteLine ("There are " + flavors.Count + " Ice Cream Flavors");
            flavors.Remove (flavors[3]);
            Console.WriteLine ("There are now " + flavors.Count + " Ice Cream Flavors");

            // User Info Dictionary
            Dictionary<string, string> userInfo = new Dictionary<string, string> ();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach (string names in name) {
                userInfo.Add (names, null);
            }
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random ();
            foreach (string names in name) {
                userInfo[names] = flavors[rand.Next (flavors.Count)];
            }
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            Console.WriteLine ("Users and their favor ice cream flavors:");
            foreach (KeyValuePair<string, string> info in userInfo) {
                Console.WriteLine (info.Key + " - " + info.Value);
            }

        }
    }
}