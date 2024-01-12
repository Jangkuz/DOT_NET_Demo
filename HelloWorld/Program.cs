// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Reflection.Emit;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Konichiwa Van Anh");
            Abc.Nihao("Hellu");
            Abc testAbe = new Abc();
            Console.WriteLine(testAbe.getString());
            testAbe.setString("Anh Duong");
            Console.WriteLine(testAbe.getString());
        }
    }

    public class Abc{
       String name;
       /// <summary>
              /// Phuong thuc nay in ra str
              /// </summary>
              /// <param name="str"></param>
                      
        public static void Nihao(String str){
            System.Console.WriteLine(str);
        }
        public Abc(){
            name = "Anh Truong";
        }
        public Abc(String temp){
            name = temp;
        }
        public void setString(String temp){
            this.name = temp;
        }
        public String getString(){
            return this.name;
        }
    }

}
