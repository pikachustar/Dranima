using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy}

public class BattleSys : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD playerHUD;
    [SerializeField] BattleHUD enemyHUD;
    [SerializeField] BDialgBox dialogBox;

    BattleState state;
    int currentAction;
    int currentMove;


    private void Start()
    {
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle()
    {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHUD.SetData(playerUnit.Fakemon);
        enemyHUD.SetData(enemyUnit.Fakemon);

        dialogBox.SetMoveNames(playerUnit.Fakemon.Moves);

        yield return (dialogBox.TypeDialog($"A wild {enemyUnit.Fakemon.Base.Name} appeared!"));
        yield return new WaitForSeconds(1f);

        PlayerAction();
    }

    void PlayerAction()
    {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Choose an action"));
        dialogBox.EnableActionSelector(true);
    }

    void PlayerMove()
    {
        state = BattleState.PlayerMove;
        dialogBox.EnableActionSelector(false);
        dialogBox.EnableDialogText(false);
        dialogBox.EnableMoveSelector(true);
    }

    private void Update()
    {
        if (state == BattleState.PlayerAction)
        {
            HandleActionSelection();
        }
        else if(state == BattleState.PlayerMove)
        {
            HandleMoveSelection();
        }
    }

    void HandleActionSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (currentAction < 1)
            ++currentAction;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (currentAction > 0)
                --currentAction;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (currentAction < 2)
            currentAction += 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (currentAction > 1)
                currentAction -= 2;
        }
        
        dialogBox.UpdateActionSelection(currentAction);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (currentAction == 0)
            {
            //Fight
            PlayerMove();
            }
            else if (currentAction == 1)
            {
            //Item
            }
            else if (currentAction == 2)
            {
            //Mon
            }
            else if (currentAction == 3)
            {
            //Run
            }
            
        }
    }
    void HandleMoveSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (currentMove < playerUnit.Fakemon.Moves.Count - 1)
            ++currentMove;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (currentMove > 0)
                --currentMove;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (currentMove < playerUnit.Fakemon.Moves.Count - 2)
            currentMove += 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (currentMove > 1)
                currentMove -= 2;
        }

        dialogBox.UpdateMoveSelection(currentMove, playerUnit.Fakemon.Moves[currentMove]);

        //If press X return to PlayerAction
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerBack();
        }
    }

    void PlayerBack()
    {
        state = BattleState.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Choose an action"));
        dialogBox.EnableActionSelector(true);
        dialogBox.EnableDialogText(true);
        dialogBox.EnableMoveSelector(false);
    }
}
