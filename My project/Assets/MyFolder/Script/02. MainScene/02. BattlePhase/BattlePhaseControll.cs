using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseControll : MonoBehaviour
{
    GameObject battlePhaseUp = default; // �˾�â �ҷ�����
    //GameObject battlePhase2Up = default;
    //GameObject battlePhase3Up = default;
    //GameObject battlePhase4Up = default;
    //GameObject battlePhase5Up = default;

    // Start is called before the first frame update
    void Start()
    {
        battlePhaseUp = GameObject.Find("Battle"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        battlePhaseUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        battlePhaseUp.SetActive(false); // ������ ��Ȱ��ȭ

        //battlePhase2Up = GameObject.Find("Battle2");
        //battlePhase2Up.transform.localScale = Vector3.one;
        //battlePhase2Up.SetActive(false);

        //battlePhase3Up = GameObject.Find("Battle3");
        //battlePhase3Up.transform.localScale = Vector3.one;
        //battlePhase3Up.SetActive(false);

        //battlePhase4Up = GameObject.Find("Battle4");
        //battlePhase4Up.transform.localScale = Vector3.one;
        //battlePhase4Up.SetActive(false);

        //battlePhase5Up = GameObject.Find("Battle5");
        //battlePhase5Up.transform.localScale = Vector3.one;
        //battlePhase5Up.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
