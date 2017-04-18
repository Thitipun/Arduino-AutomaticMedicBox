using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArdunoApp2
{

    class User
    {
        //fields ...
        //modifiers + type + field_name
        string _name;
        public int _userNo;

        public User()
        {
            //constructor 
            //special method
        }
        public User(string name, int no)
        {
            this.Name = name;
            this._userNo = no;
        }

        //
        public string GetName()
        {
            return _name;
        }
        public void SetNAme(string name)
        {
            this._name = name;
        }

        //properties ...
        //modifiers + type + field_name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }

    class Program
    {
        //members...
        //fields... 
        //methods...
        static void Main(string[] args)
        {
            Console.WriteLine("input your name ...");
            string line = Console.ReadLine();
            Console.WriteLine("hello " + line);
            //---------------------- 


            User u1 = new User();

            //u1._name = "01234";
            u1.SetNAme("01234");
            u1.Name = "okok";
            u1._userNo = 0;
            //---------------------- 
            string u_name = u1.GetName();
            Test2(1.ToString());
            Test2(2);
            //1. create filestream     

            //using()...
            //1. 
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            //2. 
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(line);
            writer.Close();
            fs.Close();
            //-------------
            
        }

        //methods...
        static void Test1()
        {
            //modifers + return_type + signature (name + param list)

        }
        static void Test2(string username)
        {
            //overloading method
        }
        static int Test2(int userArg)
        {
            //overloading method
            return 0;
        }
    }
}
