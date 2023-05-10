using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spearman : MonoBehaviour
{
    public string spearman = "Ã¢¼ú»ç";
    public int hp = 150;
    public int maxHp = 150;

    public int attack = 13;
    public int defance = 12;
    public int critical = 14;
    public int avoid = 3;

    private void Awake()
    {
        PlayerInfo.playerName = spearman;
        PlayerInfo.playerHp = hp;
        PlayerInfo.playerMaxHp = maxHp;

        PlayerInfo.playerAttack = attack;
        PlayerInfo.playerDefance = defance;
        PlayerInfo.playerCritical = critical;
        PlayerInfo.playerAvoid = avoid;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
