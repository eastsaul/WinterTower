using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act1Button : MonoBehaviour
{
    public GameObject button; // Ŭ���� ��ư

    public void Fadebutton() // ���θ��� ��ư�� Ŭ���ϸ� �����ϴ� �Լ�
    {
        Debug.Log("��ưŬ��");
        button.SetActive(false); // ��ư�� Ŭ���ϸ� ��ư�� ��Ȱ��ȭ
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
