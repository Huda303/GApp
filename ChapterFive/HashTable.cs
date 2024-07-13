// /*1.Eight objects with hash codes of 217, 209, 265, 226, 234, 201, 207, and 223
// are to be stored in an initially empty hash table using an array of size 8 with
// separate chaining to resolve collisions. Find the lengths of the chains involved after
// these eight objects are inserted into the hash table.*/
// using System.Diagnostics.Metrics;
// using System.Dynamic;


using System;
namespace ChapterFive {

    class Coords {
        public double lat, lang;
        public Coords(double lat, double lang) {
            this.lat = lat;
            this.lang = lang;
        }
    }

    class HashCountry {
        static int size = 26; 
        Coords[] arrCoords = new Coords[size];

        public void Set(string country, double lat, double lang) {
            Coords tempObj = new Coords(lat, lang);
            int index = HashFunc(country);
            arrCoords[index] = tempObj;
        }

        int HashFunc(string country) {
            int value = SumLetters(country.ToUpper());
            return value % size;
        }

        int SumLetters(string country) {
            int summation = 0;
            for (int i = 0; i < country.Length; i++) {
                summation += Convert.ToInt32(country[i]);
            }
            return summation;
        }

        public Coords Get(string country) {
            int index = HashFunc(country.ToUpper());
            return arrCoords[index];
        }

    }}

