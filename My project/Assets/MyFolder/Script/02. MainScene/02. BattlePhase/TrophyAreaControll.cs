using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyAreaControll : MonoBehaviour
{
    GameObject trophyInfoPopUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        trophyInfoPopUp = GameObject.Find("Trophy"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        trophyInfoPopUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        trophyInfoPopUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
