using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Override
{
    //플레이어(...), 몬스터(슬라임, 좀비, 고블린,...)
    //모든캐릭터의 추상 부모 클래스(캐릭터가 가지고 있는 특성, 공통기능)
    public abstract class Charactor
    {
        public abstract int GetTotalAttack();

        public int health;
        public int baseAtk;

        //생성자
        public Charactor(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }
        //매개변수로 나를 공격하는 캐릭터 객체를 전달해준다
        public void TakeDamage(Charactor other)
        {
            health -= other.GetTotalAttack();
        }
    }
    //플레이어
    public class Player : Charactor
    {
        public Player() : this(10, 20) { }
        public Player(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
    }
    //몬스터: 슬라임, 좀비, 고블린,...... 등의 부모 클래스
    public class Monster : Charactor
    {
        //
        public int posX, posY;
        //생성자
        public Monster(int hp, int atk) : base(hp, atk){ }

        //
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
        //몬스터: 슬라임, 좀비, 고블린,...... 등의 공통 기능구현
        //.......
    }
    //고블린
    public class Goblin : Monster
    {
        public Goblin(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
        /*public SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }*/

    }
    //스켈레톤
    public class Skeleton : Monster
    {
        //생성자
        public Skeleton(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
        /*public SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }*/

    }
    //좀비
    public class Zombi : Monster
    {
        //생성자
        public Zombi(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
        /*public SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }*/

    }
}