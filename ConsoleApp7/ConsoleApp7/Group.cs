using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Group
    {
        private int _studentLimit;
        private string _checkNo;

        public int StudentLimit
        {
            get => this._studentLimit;
            set
            {
                if (value >= 0)
                {
                    this._studentLimit = value;
                }
            }
        }

        public bool CheckNo(string No)
        {
            bool check = false;

            if (!string.IsNullOrWhiteSpace(No))
            {
                if (char.IsUpper(No[0]) && char.IsUpper(No[1]) && char.IsDigit(No[2]) && char.IsDigit(No[3]) && char.IsDigit(No[4]))
                {
                    check = true;
                }

            }
            return check;
        }
    }
}
