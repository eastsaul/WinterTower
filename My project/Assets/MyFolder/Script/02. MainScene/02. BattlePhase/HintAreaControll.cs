using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintAreaControll : MonoBehaviour
{
    GameObject bossHintPopUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        bossHintPopUp = GameObject.Find("BossHintPopUp"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        bossHintPopUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        bossHintPopUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {

    }
}
