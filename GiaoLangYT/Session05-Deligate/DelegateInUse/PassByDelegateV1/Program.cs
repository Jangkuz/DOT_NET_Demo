namespace PassByDelegateV1
{

    //Challenge #1: In ra 2 lời bài hát nào đó theo kiểu truyền thống.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicit directly like normal - Call hàm có sẵn");
            //PrintSongV1();
            //PrintSongV2();
            //style Action - void F(0

            Console.WriteLine("C#2: Call explicit methods using delegate");
            Action f1 = PrintSongV1;
            f1();   //~  PrintSongV1();
            f1 += PrintSongV2;  //multicast delegate
            f1.Invoke();

            Console.WriteLine("C#3: In ra mà ko làm hảm lẻ. Dùng hàm ẩn danh và biểu thức lambda");
            Action f2 = delegate () {
                Console.WriteLine("Song: Numb Little Bug");
                Console.WriteLine("By Em Beihold");
                Console.WriteLine(@"I don't feel a single thing
Have the pills done too much
Haven't caught up with my friends in weeks
And now we're outta touch
I've been driving in L.A.
And the world it feels too big
Like a floating ball that's bound to break
Snap my psyche like a twig
And I just wanna see if you feel the same as me
Do you ever get a little bit tired of life
Like you're not really happy but you don't wanna die
Like you're hanging by a thread but you gotta survive
'Cause you gotta survive
Like your body's in the room but you're not really there
Like you have empathy inside but you don't really care
Like you're fresh outta love but it's been in the air
Am I past repair");
            };
            Action f3 = () => 
            {
                Console.WriteLine("Song: 2 Days Into College");
                Console.WriteLine("By Aimee Carty");
                Console.WriteLine(@"I'm two days into college
And I'm three lectures behind
There's this guy, let's name him Colin
He says he wants to be mine
But it doesn't really sit with me quite right
'Cause he doesn't really like the things I like
And I keep accidentally locking myself out of my dorm in the middle of the night
I wake up kinda wired
And I wake up kinda cold
And I wake up kinda tired
But I'll just sleep in when I'm old
See I don't like breaking rules
But don't like doing as I'm told
So I just float around and keep my head down
And hope my life unfolds");
            };
        }

        public static void PrintSongV1()
        {
            Console.WriteLine("The song is: Hatsukoi (初恋)");
            Console.WriteLine("By: Inui Toko (戌亥とこ)");
            Console.WriteLine(@"重なる思ひ 恋の樹の下で
傍らに立つ 君が問う
林檎畑に出来た細道は
誰が踏みそめしかたみぞと
あげ初めし前髪
林檎のもとに見え
前にさした花櫛
君を花のように思ふ
...
");
        }

        public static void PrintSongV2()
        {
            Console.WriteLine("The song is: End of a Life");
            Console.WriteLine("By: Mori Calliope");
            Console.WriteLine(@"We’d run
Right through
Those nights
I’ll never find my way back to you, inside this labyrinth of lights
There was madness
In the meaning
Never laughless
We were screaming at the top of our lungs to the numbness
This city never died
I’ll fly
No proof
Those heights
I’ll never find another chance to say “hey thanks for saving my life”
I was hopeless
It was stinging
Running roadless
We were singing at the top of our lungs to the numbness
This city never died
...
");
        }
    }
}
