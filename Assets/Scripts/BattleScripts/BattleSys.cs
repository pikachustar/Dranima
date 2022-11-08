using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSys : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleHUD enemyHUD;

    private void Start()
    {
        SetupBattle();
    }

    public void SetupBattle()
    {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHUD.SetData(playerUnit.Fakemon);
        enemyHUD.SetData(enemyUnit.Fakemon);
    }
}
