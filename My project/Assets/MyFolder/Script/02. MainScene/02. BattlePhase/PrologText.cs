using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrologText : MonoBehaviour
{
    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        
    }

    //void Fade()
    //{
    //    for (float f = 1f; f >= 0; f -= 0.1f)
    //    {
    //        Color c = renderer.material.color;
    //        c.a = f;
    //        renderer.material.color = c;
    //    }
    //}

    public IEnumerator FadeTextToFullAlpha() // 알파값 0에서 1로 전환
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime / 2.0f));
            yield return null;
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
