using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int damage;
    public int defance;
    public int critical;
    public int avoid;

    public int maxHP;
    public int currentHP;

    public bool TakeDamage(int dmg) 
    {
        currentHP -= dmg;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount) 
    {
        currentHP += amount;
        if(currentHP > maxHP)
            currentHP = maxHP;
    }

    private void Awake()
    {
        InfoTest.infoName = unitName;
        InfoTest.infoHp = currentHP;
        InfoTest.infoMaxHp = maxHP;
        InfoTest.infoDamage = damage;

    } // 대입을 스타트에서 했는데도 안됨 / 왜냐하면 어떤 스타트가 먼저인지 모르기때문 / 그래서 Awake() 에서 대입함
}
