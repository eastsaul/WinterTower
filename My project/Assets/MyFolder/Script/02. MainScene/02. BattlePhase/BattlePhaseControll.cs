using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhaseControll : MonoBehaviour
{
    GameObject battlePhaseUp = default; // 팝업창 불러오기
    //GameObject battlePhase2Up = default;
    //GameObject battlePhase3Up = default;
    //GameObject battlePhase4Up = default;
    //GameObject battlePhase5Up = default;

    // Start is called before the first frame update
    void Start()
    {
        battlePhaseUp = GameObject.Find("Battle"); // 팝업창을 찾는다
        // Find() 는 비활성화 되어있는 오브젝트는 못찾음
        // 그러니 처음에 오브젝트를 켜두고 스케일을 줄여서 안보이게 하고 사이즈를 키워서 보는 형식
        battlePhaseUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        battlePhaseUp.SetActive(false); // 시작은 비활성화

        //battlePhase2Up = GameObject.Find("Battle2");
        //battlePhase2Up.transform.localScale = Vector3.one;
        //battlePhase2Up.SetActive(false);

        //battlePhase3Up = GameObject.Find("Battle3");
        //battlePhase3Up.transform.localScale = Vector3.one;
        //battlePhase3Up.SetActive(false);

        //battlePhase4Up = GameObject.Find("Battle4");
        //battlePhase4Up.transform.localScale = Vector3.one;
        //battlePhase4Up.SetActive(false);

        //battlePhase5Up = GameObject.Find("Battle5");
        //battlePhase5Up.transform.localScale = Vector3.one;
        //battlePhase5Up.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
