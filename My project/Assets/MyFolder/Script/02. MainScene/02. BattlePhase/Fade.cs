using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image image; // ������ȭ��
    public GameObject button; // Ŭ���� ��ư

    public void Fadebutton() // ���θ��� ��ư�� Ŭ���ϸ� �����ϴ� �Լ�
    {
        Debug.Log("��ưŬ��");
        button.SetActive(false); // ��ư�� Ŭ���ϸ� ��ư�� ��Ȱ��ȭ
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine() 
    {
        float fadeCount = 0; // ó�� ���İ�
        while (fadeCount < 1.0f) // ���� �ִ밪 1.0���� �ݺ�
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f); // 0.01�ʸ��� ����
            image.color = new Color(0, 0, 0, fadeCount); // �ش� ���������� ���İ� ����

        } 
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
