using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{

    private TMP_Text textBox; // �ؽ�Ʈ�� ��Ÿ�� ���� TMP_Text != Text

    public int playerHpNow = default; // ���� ü��
    public int playerMaxHp = default; // �ִ� ü��
    public float pHpGuage = default; // ü�� ����

    // Start is called before the first frame update
    void Start()
    {
        //textBox = GameObject.Find("EnemyHpTxt").GetComponent<TMP_Text>();
        textBox = transform.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHpNow = PlayerInfo.playerHp;
        playerMaxHp = PlayerInfo.playerMaxHp;

        pHpGuage = playerHpNow / (float)playerMaxHp;
        textBox.text = $"{playerHpNow}/{playerMaxHp}"; // ü�� ���� = ���� ü�� / �ִ� ü��
    }
}
