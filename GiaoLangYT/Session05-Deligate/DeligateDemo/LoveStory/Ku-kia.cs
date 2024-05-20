using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    internal class Ku_kia
    {
        //3 THẰNG NGANG CƠ NHAU, ĐỨNG NGANH HÀN NHAU: 
        //* INTERFACE
        //* CLASS (TAO CHỨC INFO CỦA OBJECT NGOÀI ĐỜI, HÀNH ĐỘNG)
        //* DELEGATE (CLASS ĐẶC BIỆTJ - TAO CHỈ CHỨA TÊN HÀM NGOÀI KIA)
        public delegate void SendLoveMessageDelegate();     //delegate void X()

        public static void MeetSweatHeart()
        {
            Console.WriteLine("Hey baby, oh my sweet heart");
            SendLoveMessageDelegate message = new SendLoveMessageDelegate(Ban.NhanEm);
            message += Tui.TellHer;
            Console.WriteLine("By the way, you have message from...");
            //gọi hàm nhắn tin nhưng ko gọi trực tiếp mà gọi qua delegate
            //do 2 tin này đã duco957 capture dưới dạng biến delegate, bỏ vào vùng new Delegate
            message.Invoke();
        }

    }
}
