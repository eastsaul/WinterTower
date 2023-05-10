using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHpGuage : MonoBehaviour
{
    private Image frontGuage;

    public int pGuage = default;
    public int pGuageMax = default;
    public float pGuageControll = default;

    // Start is called before the first frame update
    void Start()
    {
        frontGuage = transform.GetComponent<Image>();
        //GameObject.Find("GuageFront").GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        pGuage = PlayerInfo.playerHp;
        pGuageMax = PlayerInfo.playerMaxHp;

        pGuageControll = pGuage / (float)pGuageMax;
        frontGuage.fillAmount = pGuageControll;
    }
}
