using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpGuage : MonoBehaviour
{
    private Image frontGuage;

    public int eGuage = default;
    public int eGuageMax = default;
    public float eGuageControll = default;

    // Start is called before the first frame update
    void Start()
    {
        frontGuage = transform.GetComponent<Image>();
                     //GameObject.Find("GuageFront").GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        eGuage = EnemyInfo.monsterHp;
        eGuageMax = EnemyInfo.monsterMaxHp;

        eGuageControll = eGuage / (float)eGuageMax;
        frontGuage.fillAmount= eGuageControll;
    }
}
