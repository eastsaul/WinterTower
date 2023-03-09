using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    private TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox = transform.GetComponent<TMP_Text>();
        textBox.text = PlayerInfo.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
