using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle
{
    /*class Triangle
    {
        //1. 밑변과 높이 정보를 저장할 수 있는 Triangle클래스를 정의합니다
        //생성과 동시에 초기화가 가능한 생성자도 정의합니다
        //밑변과 높이 정보를 변경시킬 수 있는 메소드를 정의합니다
        //삼각형의 넓이를 계산해서 반환하는 메소드도 정의합니다
        //객체를 만들어서 사용해보세요
        public int basetri;
        public int eighttri;

        public Triangle(int num, int num2) // 생성자
        {
            this.basetri = num;
            this.eighttri = num2;
        }

        public void updatetri() // 밑변과 높이 정보를 변경
        {
            Console.Write("밑변 수정 값: ");
            int num1 = int.Parse(Console.ReadLine());
            this.basetri = num1;
            Console.Write("높이 수정 값: ");
            int num2 = int.Parse(Console.ReadLine());
            this.eighttri = num2;
        }
        public int triarea()
        {
            int result = 0;
            result = this.basetri * this.eighttri / 2;  // 밑변(a) x 높이(h) / 2 
            return result;
        }
    }*/

    class Song
    {
        //2. 노래를 나타내는 Song이라는 클래스를 설계하세요.
        //<필드>
        //노래제목 title
        //가수 artist
        //앨범제목 album
        //작곡가 composer
        //노래가 발표된 연도 year
        //노래가 속한 앨범에서의 트랙 번호를 나타내는 track
        public string title;
        public string artist;
        public string album;
        public string composer;
        public int year;
        public int track;

        //<메서드>
        //노래의 정보를 저장하는 setSongInfo(...) : 관련된 매개변수를 인자로 넘겨줌
        public void setSongInfo(string title, string artist, string album, string composer, int year, int track)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.composer = composer;
            this.year = year;
            this.track = track;
        }
        //노래의 정보를 나타내는 show()
        public void show()
        {
            Console.WriteLine("노래제목 : " + title);
            Console.WriteLine("가수 : " + artist);
            Console.WriteLine("앨범제목 : " + album);
            Console.WriteLine("작곡가 : " + composer);
            Console.WriteLine("노래발표 연도 : " + year);
            Console.WriteLine("노래 속한 앨범의 트랙 번호 : " + track);
        }

    }

    /*class Rectangle
    {
        //3. Rectangle클래스를 작성하세요
        //int타입의 x1, y1, x2, y2 : 사각형을 구성하는 두 점의 좌표
        //void set(int x1, int y1, int x2, int y2) : 좌표 설정
        //int square() : 사각형 넓이 리턴
        //void show() : 좌표와 넓이 등 직사각형 정보의 화면 출력
        //bool equals(Rectangle r) : 인자로 전달된 객체 r과 현 객체가 동일
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public void set(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x1 = x1;
            this.y2 = y2;
        }

        public int square()
        {
            if (x1 > x2)
            {
                int temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if (y1 > y2)
            {
                int temp = y1;
                y1 = y2;
                y2 = temp;
            }

            int width = x1 - x2; // 가로길이는 x값의 차이
            int height = y1 - y2; // 세로길이는 y값의 차이
            return width * height; // 가로 * 세로
            
        }

        public void show()
        {
            Console.WriteLine("직사각형의 정보");
            Console.WriteLine("직사각형의 좌표: {0} {1} {2} {3} ", x1,y1,x2,y2);
            Console.WriteLine("직사각형의 넓이 : " + square());
        }

        public bool equals(Rectangle r)
        {
            if (this == r) return true;
            return false;
        }
    }*/
    class MiddleMain
    {
        static void Main(string[] args)
        {
            // Triangle class
            /*Triangle tri = new Triangle(40, 50);
            int result = tri.triarea();
            Console.WriteLine("삼각형의 넓이는 : " + result);
            Console.WriteLine();

            tri.updatetri();
            result = tri.triarea();
            Console.WriteLine("삼각형의 넓이는 : " + result);*/

            // Song class
            //<main 실행>
            //ABBA의 "Dancing Queen"노래를 Song객체로 생성하고
            //Show()로 출력하세요
            Song song = new Song();
            song.setSongInfo("Dancing Queen", "ABBA", "ABBA Gold",
                "Benny Andersson, Stig Anderson, Björn Ulvaeus", 2008, 1);
            song.show(); // 노래정보 메서드

            // Rectangle class
            /*Rectangle rect = new Rectangle();
            rect.set(25, 20, 54, 24);
            rect.square();
            rect.show();
            Console.WriteLine(rect.equals(rect));*/
        }
    }
}
