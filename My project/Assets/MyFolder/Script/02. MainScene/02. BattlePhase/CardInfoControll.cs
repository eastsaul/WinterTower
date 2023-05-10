using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardInfoControll : MonoBehaviour
{
    GameObject CardInfoUp = default; // 팝업창 불러오기
    public GameManager gameManager;
    

    GameObject stageOpen;

    BattleSystem battleSystem = default;

    //public bool isMonsterDown;

    // Start is called before the first frame update
    void Start()
    {
        CardInfoUp = GameObject.Find("CardInfo"); // 팝업창을 찾는다
        // Find() 는 비활성화 되어있는 오브젝트는 못찾음
        // 그러니 처음에 오브젝트를 켜두고 스케일을 줄여서 안보이게 하고 사이즈를 키워서 보는 형식
        CardInfoUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        CardInfoUp.SetActive(false); // 시작은 비활성화
        //CardInfoUp.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);

        GameObject battlePhase_ = GFunc.GetRootObj("BattlePhase");
        GameObject battle_ = battlePhase_.FindChildObj("Battle");
        battleSystem = battle_.FindChildObj("BattleSystem").GetComponent<BattleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StageControll() 
    {
        if (battleSystem.isMonsterDown == true)
        {
            //battleSystem.isMonsterDown = false;
            gameManager.NextStage();

        }

        //stageOpen = GameObject.Find("BattleSystem");
        //stageOpen.
    }
}
