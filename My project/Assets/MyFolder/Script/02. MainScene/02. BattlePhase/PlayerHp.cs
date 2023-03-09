using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{

    private TMP_Text textBox; // 텍스트를 나타낼 변수 TMP_Text != Text

    public int playerHpNow = default; // 현재 체력
    public int playerMaxHp = default; // 최대 체력
    public float pHpGuage = default; // 체력 조절

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
        textBox.text = $"{playerHpNow}/{playerMaxHp}"; // 체력 조절 = 현재 체력 / 최대 체력
    }
}
