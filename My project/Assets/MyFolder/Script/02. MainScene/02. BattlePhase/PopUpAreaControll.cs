using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAreaControll : MonoBehaviour // �˾� ����
{
    GameObject characterInfoPopUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        characterInfoPopUp = GameObject.Find("CharacterInfoPopUp"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        characterInfoPopUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        characterInfoPopUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
