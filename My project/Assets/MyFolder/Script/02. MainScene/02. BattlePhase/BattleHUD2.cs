using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD2 : MonoBehaviour
{
    public TMP_Text nameText2;
    public TMP_Text HpText2;
    public Slider hpSlider2;

    public void SetHUD2(Unit2 unit2) 
    {
        nameText2.text = unit2.unit2Name;
        HpText2.text = $"{unit2.currentHP2}/{unit2.maxHP2}";
        hpSlider2.maxValue = unit2.maxHP2;
        hpSlider2.value = unit2.currentHP2;
        //InfoTest.infoHp = unit.currentHP;
        //InfoTest.infoMaxHp = unit.maxHP;
        //InfoTest.infoDamage = unit.damage;
    }

    public void SetHP(int hp) 
    {
        hpSlider2.value = hp;

    }

    //void update()
    //{
    //    hptext.text = $"{unit.currenthp}/{unit.maxhp}";

    //}
}
