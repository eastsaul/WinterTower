using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaZombie : MonoBehaviour
{
    public string zombie = "���� ����";
    public int hp = 60;
    public int maxHp = 60;

    private void Awake()
    {
        EnemyInfo.monsterName = zombie;
        EnemyInfo.monsterHp = hp;
        EnemyInfo.monsterMaxHp = maxHp;
    } // ������ ��ŸƮ���� �ߴµ��� �ȵ� / �ֳ��ϸ� � ��ŸƮ�� �������� �𸣱⶧�� / �׷��� Awake() ���� ������

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
