﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEANet
{
    public class Purchase
    {
        //Use variable InternetConnection and CellPhone
        public bool InternetConnection { get; set; }
        public int Price { get; set; }
        public string[] CellPhone { get; set; }
        public int PhoneLines { get; set; }

        public Purchase()
        {
        }

        //Including/excluding the Internet connection
        public void IncludeExcludeInternetConnection(bool input)
        {
            if (input) Price += 200;
            else Price -= 200;
        }

        //Incrementing the number of phone lines
        public void IncrementPhoneLineNumber()
        {
            if (PhoneLines < 8)
            { 
            PhoneLines++;
            Price += 150;
            }
        }

        //Decrementing the number of phone lines
        public void DecrementPhoneLineNumber()
        {
            if (PhoneLines > 0)
            {
                PhoneLines--;
                Price -= 150;
            }
        }

        // This should have used the CellPhone string array. Would have utilised it if we had more time
        //Selecting a cell phone
        public void SelectCellPhone(string modelName)
        {
            if (modelName == "Huawei 99") Price += 900;
            if (modelName == "Sony Xperia 99") Price += 900;
            if (modelName == "Samsung Galaxy 99") Price += 1000;
            if (modelName == "iPhone 99") Price += 6000;
            if (modelName == "Motorola G99") Price += 800;

        }

        //Unselecting a cell phone
        public void UnselectCellPhone(string modelName)
        {
            if (modelName == "Huawei 99") Price -= 900;
            if (modelName == "Sony Xperia 99") Price -= 900;
            if (modelName == "Samsung Galaxy 99") Price -= 1000;
            if (modelName == "iPhone 99") Price -= 6000;
            if (modelName == "Motorola G99") Price -= 800;
        }

        //Buying
        public string Buy()
        {
            if (Price < 0) Price = 0;
            return "You have bought items for a total of " + Price + " DKK";
        }

        public void Reset()
        {
            PhoneLines = 0;
            Price = 0;
        }
    }
}