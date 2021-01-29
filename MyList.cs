using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<C,B>
    {
        C[] _arrValue;
        B[] _arrNumber;

        public MyList()
        {
            _arrValue = new C[0];
            _arrNumber = new B[0];
        }
        public void Add(C item1,B item2)
        {
            C[] _tempValue = _arrValue;
            B[] _tempNumber = _arrNumber;
            _arrValue = new C[_arrValue.Length + 1];
            _arrNumber = new B[_arrNumber.Length + 1];

            for (int i = 0; i <_tempValue.Length; i++)
            {
                _arrValue[i] = _tempValue[i];
                _arrValue[_arrValue.Length - 1] = item1;
            }
            for (int i = 0; i < _tempNumber.Length; i++)
            {
                _arrNumber[i] = _tempNumber[i];
                _arrNumber[_arrNumber.Length - 1] = item2;

            }
            Console.WriteLine( item1 + " " + " Ülke Barkod Kodu" + " " + "=" + " "  + item2 );
        }
    }
}
