using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArdunoApp2
{

    struct Point //copy by value
    {
        public int X;
        public int Y;
    }

    //static vs instance => copy by reference
    class User //class 
    {
        //u1,u2,u3 => instance of class

        //--------------
        //shared , class's field
        public static int totalUser = 0;
        //--------------

        //fields ...
        //modifiers + type + field_name
        string _name; //instance field
        public int _userNo;

        public User()
        {
            //constructor 
            //special method
            totalUser++;
        }
        public User(string name, int no)
        {
            this.Name = name;
            this._userNo = no;
            //------
            totalUser++;
        }

        //
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        //reduce form...
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

        //class's method 
        public static int GetTotalUserCount()
        {

            return totalUser;
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
            int totalCount = User.GetTotalUserCount();
            User.totalUser = 1;
            //---------------------- 

            //
            User u1 = new User();
            u1.SetName("01234");
            u1._userNo = 0;
            u1.Name = "okok";
            //---------------------- 
            User u2 = new User();
            u2.SetName("yyyyy");
            u2._userNo = 0;
            u2.Name = "11111";
            //----------------------  
            TestUser(u2);
            Console.WriteLine(u2.Name);
            //----------------------  

            Point pp = new Point();
            pp.X = 3;
            pp.Y = 4;
            TestPoint(pp);
            TestPoint3(ref pp); 
            //-------------------

            Console.WriteLine(User.totalUser.ToString());
            Console.WriteLine(u1.Name);

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
        static void TestUser(User u)
        {
            u.Name = "iiiii";
        }
        static void TestPoint(Point p)
        {
            p.X = 20;
            p.Y = 30;
        }
        static void TestPoint3(ref Point p)
        {
            p.X = 20;
            p.Y = 30;
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
