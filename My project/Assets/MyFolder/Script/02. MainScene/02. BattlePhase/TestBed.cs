using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestBed : MonoBehaviour
{
    // �÷��̾��� ������ �޾ƿ� //!= ���ʿ� ������ ���� ���� ������ �ʿ� ������ static �̴ϱ� �׳� �ҷ���
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
        //!= ���� ���� ����
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
        // ���� ������ ����� ������ ���� �ƴ϶� static �̱� ������ �״�� �ҷ�����
        // Update �� �ƴ� �˾��� ų �� ���� ����� �Ŵϱ� OnEnable()
        atkTxt.text = $"{attackCall}"; // PlayerInfo.attack
        dfTxt.text = $"{defanceCall}"; // PlayerInfo.defance
        crTxt.text = $"{criticalCall}%"; // PlayerInfo.critical
        avTxt.text = $"{avoidCall}%"; // PlayerInfo.avoid
    }
}
