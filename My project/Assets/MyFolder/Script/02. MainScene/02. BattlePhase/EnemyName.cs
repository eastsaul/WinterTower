using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyName : MonoBehaviour
{
    private TMP_Text textBox;
    

    // Start is called before the first frame update
    void Start()
    {
        textBox = transform.GetComponent<TMP_Text>();
        textBox.text = EnemyInfo.monsterName;
    }

    // Update is called once per frame
    void Update()
    {
        //textBox.text = EnemyInfo.name;
    }
}
