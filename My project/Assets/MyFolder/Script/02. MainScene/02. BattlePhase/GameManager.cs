using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int stageCount;

    public int stageIndex;
    public GameObject[]Stages = new GameObject[11];
    public GameObject[]Steps = new GameObject[10];

    public void NextStage() 
    {
        Stages[stageIndex].SetActive(false);

        stageIndex++;
        Stages[stageIndex].SetActive(true);
    }

    public void NextStep() 
    {
        Steps[stageIndex].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Stages[1].transform.localScale = Vector3.one; // new Vector3(1f, 1f, 1f) 와 같은 표현임, 현업에서 자주 씀
        Stages[1].SetActive(false); // 시작은 비활성화
        Stages[2].transform.localScale = Vector3.one;
        Stages[2].SetActive(false);
        Stages[3].transform.localScale = Vector3.one;
        Stages[3].SetActive(false);
        Stages[4].transform.localScale = Vector3.one;
        Stages[4].SetActive(false);
        Stages[5].transform.localScale = Vector3.one;
        Stages[5].SetActive(false);
        Stages[6].transform.localScale = Vector3.one;
        Stages[6].SetActive(false);
        Stages[7].transform.localScale = Vector3.one;
        Stages[7].SetActive(false);
        Stages[8].transform.localScale = Vector3.one;
        Stages[8].SetActive(false);
        Stages[9].transform.localScale = Vector3.one;
        Stages[9].SetActive(false);
        Stages[10].transform.localScale = Vector3.one;
        Stages[10].SetActive(false);

        //CardInfoUp.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        stageCount = stageIndex;
    }
}
