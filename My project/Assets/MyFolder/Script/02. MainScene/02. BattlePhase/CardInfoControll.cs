using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardInfoControll : MonoBehaviour
{
    GameObject CardInfoUp = default; // �˾�â �ҷ�����
    public GameManager gameManager;
    

    GameObject stageOpen;

    BattleSystem battleSystem = default;

    //public bool isMonsterDown;

    // Start is called before the first frame update
    void Start()
    {
        CardInfoUp = GameObject.Find("CardInfo"); // �˾�â�� ã�´�
        // Find() �� ��Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� ��ã��
        // �׷��� ó���� ������Ʈ�� �ѵΰ� �������� �ٿ��� �Ⱥ��̰� �ϰ� ����� Ű���� ���� ����
        CardInfoUp.transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) �� ���� ǥ����, �������� ���� ��
        CardInfoUp.SetActive(false); // ������ ��Ȱ��ȭ
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
