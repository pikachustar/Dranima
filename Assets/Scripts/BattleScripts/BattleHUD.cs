using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HealthBar hpBar;

    public void SetData(Fakemon fakemon)
    {
        nameText.text = fakemon.Base.Name;
        levelText.text = "Lvl " + fakemon.Level;
        hpBar.SetHP((float) fakemon.HP / fakemon.MaxHP);

    }
}
