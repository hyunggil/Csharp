using UnityEngine;

namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Player 클래스의 인스턴스 생성
            Player player = new Player(100, 30);

            Goblin go = new Goblin(50, 10);
            Skeleton sk = new Skeleton(100, 20);
            Zombi zb = new Zombi(200, 30);

            //전투
            player.TakeDamage(go);
            DrawHealth(player);
            player.TakeDamage(sk);
            DrawHealth(player);
            player.TakeDamage(zb);
            DrawHealth(player);

            Debug.Log("============");

            go.TakeDamage(player);
            DrawHealth(go);
            sk.TakeDamage(player);
            DrawHealth(sk);
            zb.TakeDamage(player);
            DrawHealth(zb);

        }

        //캐릭터의 health 그리기
        public void DrawHealth(Charactor ch)
        {
            Debug.Log($"{ch} : {ch.health}");
        }
        /*public void DrawPlayerHealth(Player player)
        {
            Debug.Log($"{player.health}");
        }
        public void DrawGoblinHealth(Player goblin)
        {
            Debug.Log($"{goblin.health}");
        }
        public void DrawSkeletonHealth(Player skeleton)
        {
            Debug.Log($"{skeleton.health}");
        }
        public void DrawZombiHealth(Player zombi)
        {
            Debug.Log($"{zombi.health}");
        }*/
    }
}