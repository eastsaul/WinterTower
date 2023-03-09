using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHp : MonoBehaviour
{

    private TMP_Text textBox; // 텍스트를 나타낼 변수 TMP_Text != Text

    public int enemyHpNow = default; // 현재 체력
    public int enemyMaxHp = default; // 최대 체력
    public float HpGuage = default; // 체력 조절

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
        textBox.text = $"{enemyHpNow}/{enemyMaxHp}"; // 체력 조절 = 현재 체력 / 최대 체력

    }
}
