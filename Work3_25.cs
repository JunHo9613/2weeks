using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_05_25_HomeWork_Done
{
    //1. 밑변과 높이 정보를 저장할 수 있는 Triangle클래스를 정의합니다
    //   생성과 동시에 초기화가 가능한 생성자도 정의합니다
    //   밑변과 높이 정보를 변경시킬 수 있는 메소드를 정의합니다
    //   삼각형의 넓이를 계산해서 반환하는 메소드도 정의합니다
    //   객체를 만들어서 사용해보세요
    class Triangle
    {
        private int under = 0;
        private int hight = 0;
        
        public void updateBaseHight(int a, int b)
        {
            this.under = a;
            this.hight = b;
            Console.WriteLine("밑면 : " + under);
            Console.WriteLine("높이 : " + hight);

        }
        public int TriArea(int a, int b)
        {
            return a * b / 2;
        }
    }
    //2. 노래를 나타내는 Song이라는 클래스를 설계하세요.
    //   <필드>
    //    노래제목 title
    //    가수 artist
    //    앨범제목 album
    //    작곡가 composer
    //    노래가 발표된 연도 year
    //    노래가 속한 앨범에서의 트랙 번호를 나타내는 track
    class song
    {
        private string title;
        private string artist;
        private string album;
        private int year;
        private int track;
        //   <메서드>
        //    노래의 정보를 저장하는 setSongInfo(...) : 관련된 매개변수를 인자로 넘겨줌
        //    노래의 정보를 나타내는 show()
        public void setSongIngo(string title, string artist, string album, int year, int track)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.year = year;
            this.track = track;

        }
        public void Show()
        {
            Console.WriteLine("노래제목 :" + title);
            Console.WriteLine("아티스트 :" + artist);
            Console.WriteLine("노래엘범 :" + album);
            Console.WriteLine("발매년도 :" + year + "년");
            Console.WriteLine("앨범트랙 :" + track + "번 트랙");
        }
        //   <main 실행>
        //    ABBA의 "Dancing Queen"노래를 Song객체로 생성하고
        //    Show()로 출력하세요
    }

    class Rectangle
    {

        //3. Rectangle클래스를 작성하세요
        //   int타입의 x1, y1, x2, y2 : 사각형을 구성하는 두 점의 좌표
        //   void set(int x1, int y1, int x2, int y2) : 좌표 설정
        //   int square() : 사각형 넓이 리턴
        //   void show() : 좌표와 넓이 등 직사각형 정보의 화면 출력
        //   bool equals(Rectangle r) : 인자로 전달된 객체 r과 현 객체가 동일한 좌표의 직사각형이면 true 리턴

        private int x1, y1, x2, y2;
        
        public void set(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public int square()
        {
            int a, b;
            int max = 0, min = 0;
            if(x1 < x2)
            {
                max = x2;
                min = x1;
            }
            else
            {
                max = x1;
                min = x2;
            }
            a = max - min;

            if(y1 < y2)
            {
                max = y2;
                min = y1;
            }
            else
            {
                max = y1;
                min = y2;
            }
            b = max - min;
            return a*b;
        }
        public bool equals(Rectangle r)
        {
            if(this.x1 == r.x1 && this.y1 == r.y1 && this.x2 == r.x2 && this.y2 == r.y2)
            {
                return true;
            }
            return false;
        }
        public void show()
        {
            Console.WriteLine("(x1,y1) = ({0},{1}) / (x2,y2) = ({2},{3}) ",x1,y1,x2,y2);
            Console.WriteLine("사각형의 넓이: " + square());
        }
    }
}
