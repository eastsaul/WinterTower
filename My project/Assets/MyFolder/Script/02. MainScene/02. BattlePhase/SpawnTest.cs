using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnTest : MonoBehaviour
{
    public GameObject card;
    public Transform spawnPosition;
    public Transform spawnPosition2;
    public Transform spawnPosition3;
    public GameObject[] gameObjects = new GameObject[20];
    //public GameObject[0] = default;
    int result = Random.Range(0, 21);
    
    public List<GameObject> list = new List<GameObject>();

    WaitForSeconds delay = new WaitForSeconds(10);
    
    public void Spawn()
    {
        Debug.Log("��ο�");
        list = gameObjects.ToList();
    }

    // Start is called before the first frame update
    void Start()
    {
        // ī�带 Ȱ��ȭ
        //card.gameObject.SetActive(true);
        card.transform.position = spawnPosition.transform.position;
        card.transform.position = spawnPosition2.transform.position;
        card.transform.position = spawnPosition3.transform.position;


        Debug.Log("1�� �׽�Ʈ");
        for (int i = 0; i < 5; ++i)
        {
            // UnityEngine.Random.Range(0, 10);
            // 0 ~ 9 ����
            int result = Random.Range(0, 10);
            Debug.Log($"Random {i + 1}ȸ : {result}");
        }

        Debug.Log("2�� �׽�Ʈ");
        for (int i = 0; i < 5; ++i)
        {
            // -10 ~ 19 ����
            int result = Random.Range(-10, 20);
            Debug.Log($"Random {i + 1}ȸ : {result}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
