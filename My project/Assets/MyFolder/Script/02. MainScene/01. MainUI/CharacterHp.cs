using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterHp : MonoBehaviour // 캐릭터 Hp 텍스트
{
    private TMP_Text textBox; // 텍스트를 나타낼 변수 TMP_Text != Text

    public static int HpNow = default; // 현재 체력
    public static int MaxHp = default; // 최대 체력
    public float HpGuage = default; // 체력 조절


    // Start is called before the first frame update
    void Start()
    {
        textBox = GameObject.Find("Hp").GetComponent<TMP_Text>();
        HpGuage = HpNow / (float)MaxHp; 
        textBox.text = $"{HpNow}/{MaxHp}"; // 체력 조절 = 현재 체력 / 최대 체력
    }


}
