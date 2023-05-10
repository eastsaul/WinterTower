using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AbillCrontroll : MonoBehaviour // 플레이어 정보 팝업
{
    // 플레이어의 정보를 받아옴
    //public static int attackCall = default;
    //public static int defanceCall = default;
    //public static int criticalCall = default;
    //public static int avoidCall = default;

    private TMP_Text atkTxt = default;
    private TMP_Text dfTxt = default;
    private TMP_Text crTxt = default;
    private TMP_Text avTxt = default;

    private void Awake()
    {
        atkTxt = GameObject.Find("ATKtxt").GetComponent<TMP_Text>();
        dfTxt = GameObject.Find("DFtxt").GetComponent<TMP_Text>();
        crTxt = GameObject.Find("CRtxt").GetComponent<TMP_Text>();
        avTxt = GameObject.Find("AVtxt").GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start() // 맨 처음 한 번
    {
        //attackCall = PlayerInfo.attack;
        //defanceCall = PlayerInfo.defance;
        //criticalCall = PlayerInfo.critical;
        //avoidCall = PlayerInfo.avoid;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() // 켜질 때 마다 [유니티 함수]
    {
        //if (atkTxt != null && dfTxt != null && crTxt != null && avTxt != null)
        {
            atkTxt.text = $"{PlayerInfo.playerAttack}";
            dfTxt.text = $"{PlayerInfo.playerDefance}";
            crTxt.text = $"{PlayerInfo.playerCritical}%";
            avTxt.text = $"{PlayerInfo.playerAvoid}%";
        }

    }
}
