using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Act : MonoBehaviour
{
    public GameManager gameManager;
    public TMP_Text actText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actText.text = "Act : " + gameManager.stageIndex;
    }
}
