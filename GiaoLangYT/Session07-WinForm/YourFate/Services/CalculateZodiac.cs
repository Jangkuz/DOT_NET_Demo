namespace Services
{
    public class CalculateZodiac
    {
        /// <summary>
        /// Calculate the zodiac based on day and month
        /// </summary>
        /// <param name="day">The day in month</param>
        /// <param name="month">The month in year</param>
        /// <returns>Return the name of the zodiac in english</returns>
        public static String calculateZodiacEnglish(int day, int month)
        {
            String result = "HotGirl";
            switch (month)
            {
                case 1:
                    if(day < 20)
                    {
                        result = "Capricorn";
                    }
                    else
                    {
                        result = "Aquarius";
                    }
                    break;
                case 2:
                    if (day < 18)
                    {
                        result = "Aquarius";
                    }
                    else
                    {
                        result = "Pisces";
                    }
                    break;
                case 3:
                    if (day < 20)
                    {
                        result = "Pisces";
                    }
                    else
                    {
                        result = "Aries";
                    }
                    break;
                case 4:
                    if (day < 19)
                    {
                        result = "Aries";
                    }
                    else
                    {
                        result = "Taurus";
                    }
                    break;
                case 5:
                    if (day < 20)
                    {
                        result = "Taurus";
                    }
                    else
                    {
                        result = "Gemini";
                    }
                    break;
                case 6:
                    if (day < 20)
                    {
                        result = "Gemini";
                    }
                    else
                    {
                        result = "Cancer";
                    }
                    break;
                case 7:
                    if (day < 22)
                    {
                        result = "Cancer";
                    }
                    else
                    {
                        result = "Leo";
                    }
                    break;
                case 8:
                    if (day < 22)
                    {
                        result = "Leo";
                    }
                    else
                    {
                        result = "Virgo";
                    }
                    break;
                case 9:
                    if (day < 22)
                    {
                        result = "Virgo";
                    }
                    else
                    {
                        result = "Libra";
                    }
                    break;
                case 10:
                    if (day < 22)
                    {
                        result = "Libra";
                    }
                    else
                    {
                        result = "Scorpio";
                    }
                    break;
                case 11:
                    if (day < 21)
                    {
                        result = "Scorpio";
                    }
                    else
                    {
                        result = "Sagittarius";
                    }
                    break;
                case 12:
                    if (day < 21)
                    {
                        result = "Sagittarius";
                    }
                    else
                    {
                        result = "Sagittarius";
                    }
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// Translate the english zodiac name into Vietnamese
        /// </summary>
        /// <param name="zodiacEnglish">The name of zodiac in english</param>
        /// <returns>The name of zodiac in Vietnamese</returns>
        public static String getZodiacVietnamese(string zodiacEnglish)
        {
            string result = "";
            switch (zodiacEnglish)
            {
                case "Aries":
                    result = "Bạch Dương";
                    break;
                case "Taurus":
                    result = "Kim Ngưu";
                    break;
                case "Gemini":
                    result = "Song Tử";
                    break;
                case "Cancer":
                    result = "Cự Giải";
                    break;
                case "Leo":
                    result = "Sư Tử";
                    break;
                case "Virgo":
                    result = "Xử Nữ";
                    break;
                case "Libra":
                    result = "Thiên Bình";
                    break;
                case "Scorpio":
                    result = "Thiên Yết";
                    break;
                case "Sagittarius":
                    result = "Nhân Mã";
                    break;
                case "Capricorn":
                    result = "Ma Kết";
                    break;
                case "Aquarius":
                    result = "Bảo Bình";
                    break;
                case "Pisces":
                    result = "Song Ngư";
                    break;
                default:
                    result = "Ngọc Trinh";
                    break;
            }
            return result;
        }
    }
}
