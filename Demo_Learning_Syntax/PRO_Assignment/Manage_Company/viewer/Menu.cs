namespace Manage_Company.viewer
{
    public class Menu
    {
        public static int getChoice(string[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                System.Console.WriteLine((i + 1) + ". " + options[i]);
            }
            System.Console.WriteLine("Your options from 1 - " + options.Length + ": ");
            return System.Convert.ToInt32(System.Console.ReadLine());
        }
    }

}
