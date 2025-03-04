using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsWithBitArray
{
    internal class Program
    {
        enum ePermissions { eAddNew=1, eRemoveNew=2,eUpdate = 4}

        static string BitArrayToString(BitArray data)
        {
            char[] Elements = new char[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                Elements[i] = (data[i]) ? '1' : '0';

            }

            return new string(Elements);
        }
        class User
        {
            public string Name { get; set; }

            public string UserID { get; set; }

            public BitArray Permissions { get { return _Permissions; } }

            private BitArray _Permissions = new BitArray(8);


            public void SetPermission()
            {
                char answer = 'n';
                _Permissions.SetAll(false);

                Console.WriteLine("Do you want to let user Add New Permission? (y/n)");
                answer = char.Parse(Console.ReadLine());
                if(answer=='y') { _Permissions.Set(7, true); }
                Console.WriteLine("Do you want to let user Remove Permission? (y/n)");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'y') { _Permissions.Or(new BitArray(new bool[] { false, false, false, false, false, false, true, false })); }
                
            }

        }
        static void Main(string[] args)
        {
                User user = new User(); 
                user.SetPermission();
            Console.WriteLine(BitArrayToString(user.Permissions) .ToString());

            Console.ReadLine();
            


        }
    }
}
