using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepControll : MonoBehaviour
{
    GameObject StepUp = default; // �˾�â �ҷ�����

    // Start is called before the first frame update
    void Start()
    {
        StepUp = GameObject.Find("StepAct1"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        StepUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        StepUp.SetActive(false); // ������ ��Ȱ��ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
