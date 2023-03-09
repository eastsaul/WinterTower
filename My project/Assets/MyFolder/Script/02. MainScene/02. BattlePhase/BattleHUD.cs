using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text HpText;
    public Slider hpSlider;

    public void SetHUD(Unit unit) 
    {
        nameText.text = unit.unitName;
        HpText.text = $"{unit.currentHP}/{unit.maxHP}";
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
        //InfoTest.infoHp = unit.currentHP;
        //InfoTest.infoMaxHp = unit.maxHP;
        //InfoTest.infoDamage = unit.damage;
    }

    public void SetHP(int hp) 
    {
        hpSlider.value = hp;

    }

    //void update()
    //{
    //    hptext.text = $"{unit.currenthp}/{unit.maxhp}";

    //}
}
