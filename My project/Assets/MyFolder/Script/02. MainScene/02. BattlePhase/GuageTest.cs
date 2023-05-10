using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuageTest : MonoBehaviour
{
    GameManager gameManager;

    private Image frontGuage;

    public int eGuage = default;
    public int eGuageMax = default;
    public float eGuageControll = default;

    // Start is called before the first frame update
    void Start()
    {
        frontGuage = transform.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        eGuage = InfoTest.infoHp;
        eGuageMax = InfoTest.infoMaxHp;

        eGuageControll = eGuage / (float)eGuageMax;
        frontGuage.fillAmount = eGuageControll;
    }
}
