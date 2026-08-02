using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_Inventory
{
    internal class inventory
    {

        private string _id;
        private string _model;
        public string ID
        {
            get { return ID; }
            set
            {
                bool isValid = false;
                if (value.Length == 11)
                {
                    if (char.IsDigit(value[0]) && char.IsDigit(value[1]) &&
                        char.IsDigit(value[2]) && char.IsDigit(value[3]))
                    {
                        if (value[4] == '-')
                        {
                            if (value.Substring(5).Length == 6)
                            {
                                bool allDigits = true;
                                foreach (char c in value.Substring(5))
                                {
                                    if (!char.IsDigit(c))
                                    {
                                        allDigits = false;
                                    }
                                }
                                if (allDigits)
                                {
                                    isValid = true;
                                }
                            }
                        }
                    }

                    if (!isValid)
                    {
                        _id = "0000-000000";
                    }
                    else { _id = value; }
                }
            }
        }
        public string Model
        {
            get
            {
                return Model;
            }
            set
            {
                StreamReader inFile = new StreamReader("ManufactureCodes.txt");
                List<string> modelcodes = new List<string>();
                while (!inFile.EndOfStream)
                {
                    modelcodes.Add(inFile.ReadLine().Split(',')[1]);
                }

                bool isValid = false;
                if (value.Length == 11)
                {
                    if (char.IsLetter(value[0]) && char.IsLetter(value[1]) &&
                        value[2] == '-')
                    {
                        bool isMatch = false;
                        foreach (string s in modelcodes)
                        {
                            if(value.Substring(0,2) == s) 
                            {
                                isMatch = true;
                            }
                        }

                        if (isMatch)
                        {

                            if (value.Substring(3).Length == 8)
                            {
                                bool allDigits = true;
                                foreach (char c in value.Substring(5))
                                {
                                    if (!char.IsDigit(c))
                                    {
                                        allDigits = false;
                                    }
                                }
                                if (allDigits)
                                {
                                    isValid = true;
                                }
                            }
                        }

                    }
                    if (!isValid)
                    {
                        _model = "0000-000000";
                    }
                    else { _model= value; }

                }
            }
        }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public inventory(string id, string model, string manufacturer)
        {
            ID = id;
            Model = model;
            Manufacturer = manufacturer;
        }

        public inventory(string id, string model, string manufacturer, string description, double price)
        {
            ID = id;
            Model = model;
            Manufacturer = manufacturer;
            Description = description;
            Price = price;

        }
    }
}
