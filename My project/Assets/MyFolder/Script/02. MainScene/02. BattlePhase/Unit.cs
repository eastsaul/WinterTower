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

    } // ������ ��ŸƮ���� �ߴµ��� �ȵ� / �ֳ��ϸ� � ��ŸƮ�� �������� �𸣱⶧�� / �׷��� Awake() ���� ������
}
