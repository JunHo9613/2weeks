using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[접근 권한]
// 해당 class 외부에서 class 내부의 필드/메서드를 접근 할 수 있는 권한
// private : class 내의 메서드만 접근 가능 
// public : 누구나 접근 가능 

//필드(변수)를 직접 전근하기 보다 다른 방식으로 접근하는 3가지 방법
// 1) 생성자 메서드를 이용 
// 2)
// 3)

namespace _36__class
{
    class Student
    {
        private string name;
        private int age;

        //[생성자 메서드]
        // 리턴형이 없다
        // 클래스 이ㅡㄻ과 동일하다
        // 객체 생성시 자동 호출되는 메서드

        public Student(string name, int age)
        {
            Console.WriteLine("생성자 메서드 호출");
            // 필드변수 = 매개변수
            this.name = name;
            this.age = age;
        }

        public void intro()
        {
            //name으로 해도 매개변수에 name이 없으므로 자동으로 필드 name을 지칭하게 된다 this.name을 사용해도 됨

            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            
        }
    }
    class ClassEX
    {
        static void Main(string[] args)
        {
            // 클래스 -> 객체(인스턴스)
            // 설계도 -> 메모리 올라간 변수
            // 자료형 -> 변수

            // 객체 생성시 생성자 메서드 자동 호출
            Student kim = new Student("홍길동", 25);
            kim.intro();

         
        }
            
    }
}
