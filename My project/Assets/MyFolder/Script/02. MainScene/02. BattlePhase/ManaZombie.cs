using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaZombie : MonoBehaviour
{
    public string zombie = "마나 좀비";
    public int hp = 60;
    public int maxHp = 60;

    private void Awake()
    {
        EnemyInfo.monsterName = zombie;
        EnemyInfo.monsterHp = hp;
        EnemyInfo.monsterMaxHp = maxHp;
    } // 대입을 스타트에서 했는데도 안됨 / 왜냐하면 어떤 스타트가 먼저인지 모르기때문 / 그래서 Awake() 에서 대입함

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
