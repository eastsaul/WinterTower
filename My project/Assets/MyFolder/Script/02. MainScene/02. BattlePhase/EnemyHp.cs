using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHp : MonoBehaviour
{

    private TMP_Text textBox; // �ؽ�Ʈ�� ��Ÿ�� ���� TMP_Text != Text

    public int enemyHpNow = default; // ���� ü��
    public int enemyMaxHp = default; // �ִ� ü��
    public float HpGuage = default; // ü�� ����

    // Start is called before the first frame update
    void Start()
    {
        //textBox = GameObject.Find("EnemyHpTxt").GetComponent<TMP_Text>();
        textBox = transform.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyHpNow = EnemyInfo.monsterHp;
        enemyMaxHp = EnemyInfo.monsterMaxHp;

        HpGuage = enemyHpNow / (float)enemyMaxHp;
        textBox.text = $"{enemyHpNow}/{enemyMaxHp}"; // ü�� ���� = ���� ü�� / �ִ� ü��

    }
}
