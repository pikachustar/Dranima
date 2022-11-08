using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HealthBar hpBar;

    Fakemon _fakemon;

    public void SetData(Fakemon fakemon)
    {
        _fakemon = fakemon;

        nameText.text = fakemon.Base.Name;
        levelText.text = "Lvl " + fakemon.Level;
        hpBar.SetHP((float) fakemon.HP / fakemon.MaxHP);

    }

    public IEnumerator UpdateHP()
    {
       yield return hpBar.SetHPSmooth((float)_fakemon.HP / _fakemon.MaxHP);
    }
}
