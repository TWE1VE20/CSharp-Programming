﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Interface
{
    internal class Architecture
    {
        /**********************************************************************************
         * 추상클래스와 인터페이스
         * 
         * 인터페이스는 추상클래스의 일종으로 특징이 동일함
         * 함수에 대한 선언만 정의하고 이를 포함하는 클래스에서 구체화하여 사용
         * 하지만, 추상클래스와 인터페이스를 통해 얻는 효과는 다르며 다른 역할을 수행함
         * 개발자는 인터페이스와 추상클래스 중 더욱 상황에 적합한 것으로 구현해야 함
         *********************************************************************************/

        // <추상클래스와 인터페이스>
        // 공통점 : 함수에 대한 선언만 정의하고 이를 포함하는 클래스에서 구체화하여 사용
        // 차이점 : 추상클래스 - 변수, 함수의 구현 포함 가능 / 다중상속 불가
        //          인터페이스 - 변수, 함수의 구현 포함 불가 / 다중포함 가능

        // 설계도
        // 추상클래스 (A Is B 관계)
        // 상속 관계인 경우, 자식클래스가 부모클래스의 하위분류인 경우
        // 상속을 통해 얻을 수 있는 효과를 얻을 수 있음
        // 부모클래스의 기능을 통해 자식클래스의 기능을 확장하는 경우 사용

        // 계약서
        // 인터페이스 (A Can B 관계)
        // 행동 포함인 경우, 클래스가 해당 행동을 할 수 있는 경우
        // 인터페이스를 사용하는 모든 클래스와 상호작용이 가능한 효과를 얻을 수 있음
        // 인터페이스에 정의된 함수들을 클래스의 목적에 맞게 기능을 구현하는 경우 사용

        //용도가 다르기에 둘다 중요한 계념이다.

        public interface IEnterable
        {
            void Enter();       // 인터페이스에서는 함수의 구현을 포함하는 행위가 불가능하다.
                                // 다중 상속의 문제점 즉 죽음의 다이아몬드의 원인은 주로 변수의 선언에서 문제가 발생하기에 불가하게 만들어 두었다고 보면 된다.
        }

        public abstract class Building : IEnterable
        {
            public void Enter() // 추상클래스에서는 함수의 구현을 표함하는 행위가 가능하다.
            {
                Console.WriteLine("건물에 들어갑니다.");
            }
        }

        // 은행은 건물이다 : Ok, 상속관계가 적합
        // 업캐스팅 다운캐스팅 등의 상속으로 가지는 장점을 가질 수 있다.
        public class Bank : Building
        {

        }

        // 차는 들어갈 수 있다 : Ok, 인터페이스가 적합
        // 차가 건물이 아닌것처럼, 상속으로 생기는 문제를 해결할 수 있다.
        public class Car : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("차 문을 열고 들어갑니다.");
            }
        }
    }
}

