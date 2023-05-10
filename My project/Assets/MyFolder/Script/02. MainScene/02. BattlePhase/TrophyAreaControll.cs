using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyAreaControll : MonoBehaviour
{
    GameObject trophyInfoPopUp = default; // 팝업창 불러오기

    // Start is called before the first frame update
    void Start()
    {
        trophyInfoPopUp = GameObject.Find("Trophy"); // 팝업창을 찾는다
        // Find() 는 비활성화 되어있는 오브젝트는 못찾음
        // 그러니 처음에 오브젝트를 켜두고 스케일을 줄여서 안보이게 하고 사이즈를 키워서 보는 형식
        trophyInfoPopUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        trophyInfoPopUp.SetActive(false); // 시작은 비활성화
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
