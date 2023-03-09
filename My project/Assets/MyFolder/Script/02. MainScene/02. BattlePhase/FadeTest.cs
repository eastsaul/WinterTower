using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeTest : MonoBehaviour
{
    public Image image;

    IEnumerator FadeCoroutine()
    {
        Debug.Log("�۵�");

        float fadeCount = 1; // ó�� ���İ�
        while (fadeCount > 0f) // ���� �ִ밪 1.0���� �ݺ�
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.01f); // 0.01�ʸ��� ����
            image.color = new Color(0, 0, 0, fadeCount); // �ش� ���������� ���İ� ����

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
