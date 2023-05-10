using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestBed : MonoBehaviour
{
    // 플레이어의 정보를 받아옴 //!= 애초에 정보를 대입 받을 변수가 필요 없었음 static 이니까 그냥 불러옴
    public static int attackCall = default; //x
    public static int defanceCall = default; //x
    public static int criticalCall = default; //x
    public static int avoidCall = default; //x

    private TMP_Text atkTxt = default;
    private TMP_Text dfTxt = default;
    private TMP_Text crTxt = default;
    private TMP_Text avTxt = default;

    // Start is called before the first frame update
    void Start()
    {
        //!= 위와 같은 이유
        attackCall = PlayerInfo.playerAttack; //x
        defanceCall = PlayerInfo.playerDefance; //x
        criticalCall = PlayerInfo.playerCritical; //x
        avoidCall = PlayerInfo.playerAvoid; //x

        atkTxt = GameObject.Find("ATKtxt").GetComponent<TMP_Text>();
        dfTxt = GameObject.Find("DFtxt").GetComponent<TMP_Text>();
        crTxt = GameObject.Find("CRtxt").GetComponent<TMP_Text>();
        avTxt = GameObject.Find("AVtxt").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // 굳이 변수를 만들어 대입할 것이 아니라 static 이기 때문에 그대로 불러오기
        // Update 가 아닌 팝업을 킬 때 마다 사용할 거니까 OnEnable()
        atkTxt.text = $"{attackCall}"; // PlayerInfo.attack
        dfTxt.text = $"{defanceCall}"; // PlayerInfo.defance
        crTxt.text = $"{criticalCall}%"; // PlayerInfo.critical
        avTxt.text = $"{avoidCall}%"; // PlayerInfo.avoid
    }
}
