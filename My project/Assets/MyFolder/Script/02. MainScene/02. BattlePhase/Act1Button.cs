using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act1Button : MonoBehaviour
{
    public GameObject button; // 클릭할 버튼

    public void Fadebutton() // 새로만든 버튼을 클릭하면 실행하는 함수
    {
        Debug.Log("버튼클릭");
        button.SetActive(false); // 버튼을 클릭하면 버튼은 비활성화
        
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
