using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HUDTest : MonoBehaviour
{
    public TMP_Text nameText;

    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        
    }
}
