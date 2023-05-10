using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit2 : MonoBehaviour
{
    public string unit2Name;
    public int damage2;
    public int defance2;

    public int maxHP2;
    public int currentHP2;

    public bool TakeDamage(int dmg) 
    {
        currentHP2 -= dmg;

        if (currentHP2 <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount) 
    {
        currentHP2 += amount;
        if(currentHP2 > maxHP2)
            currentHP2 = maxHP2;
    }

    private void Awake()
    {
        InfoTest.infoName = unit2Name;
        InfoTest.infoHp = currentHP2;
        InfoTest.infoMaxHp = maxHP2;
        InfoTest.infoDamage = damage2;

    } // 대입을 스타트에서 했는데도 안됨 / 왜냐하면 어떤 스타트가 먼저인지 모르기때문 / 그래서 Awake() 에서 대입함
}
