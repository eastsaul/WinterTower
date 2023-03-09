using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum BattleState2 { START, PLAYERTURN, ENEMYTURN, WON, LOST }


public class BattleSystem2 : MonoBehaviour
{

    public GameObject playerPrefab2;
    public GameObject enemyPrefab2;

    public GameManager gameManager;

    public Transform playerBattleStation2;
    public Transform enemyBattleStation2;

    Unit2 playerUnit2;
    Unit2 enemyUnit2;

    public TMP_Text dialogueText;

    public BattleHUD2 playerHUD2;
    public BattleHUD2 enemyHUD2;

    //public HUDTest playerHUD;
    //public HUDTest enemyHUD;

    public GameObject trophyInfoPopUp;
    public GameObject battlePhaseUp;

    public bool isMonsterDown = default;

    public BattleState2 state2;

    // Start is called before the first frame update
    void Start()
    {
        state2 = BattleState2.START;
        StartCoroutine(SetupBattle2());
    }


    IEnumerator SetupBattle2()
    {
        GameObject playerGo2 = Instantiate(playerPrefab2, playerBattleStation2);
        playerUnit2 = playerGo2.GetComponent<Unit2>();

        GameObject enemyGo2 = Instantiate(enemyPrefab2, enemyBattleStation2);
        enemyUnit2 = enemyGo2.GetComponent<Unit2>();

        dialogueText.text = "살기를 뿜으며 " + enemyUnit2.unit2Name + "가 접근중...";

        playerHUD2.SetHUD2(playerUnit2);
        enemyHUD2.SetHUD2(enemyUnit2);

        yield return new WaitForSeconds(2f);

        state2 = BattleState2.PLAYERTURN;
        PlayerTurn();
    }


    IEnumerator PlayerAttack()
    {
        // Damage the enemy
        bool isDead2 = enemyUnit2.TakeDamage(playerUnit2.damage2);

        enemyHUD2.SetHP(enemyUnit2.currentHP2);
        dialogueText.text = "The attack is successful!";

        yield return new WaitForSeconds(2f);

        // check if the enemy is dead
        // change state based on what happened

        if (isDead2)
        {
            // End the battle
            state2 = BattleState2.WON;
            EndBattle();
        }
        else
        {
            // Enemy turn
            state2 = BattleState2.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit2.unit2Name + " 의 공격!";

        yield return new WaitForSeconds(1f);

        bool isDead2 = playerUnit2.TakeDamage(enemyUnit2.damage2);

        playerHUD2.SetHP(playerUnit2.currentHP2);

        yield return new WaitForSeconds(1f);

        if (isDead2)
        {
            state2 = BattleState2.LOST;
            EndBattle();
        }
        else
        {
            state2 = BattleState2.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle()
    {
        if (state2 == BattleState2.WON)
        {
            dialogueText.text = " 승리!";

            isMonsterDown = true;

            battlePhaseUp.SetActive(false);
            trophyInfoPopUp.SetActive(true);
            //gameManager.NextStage();
        }
        else if (state2 == BattleState2.LOST)
        {
            dialogueText.text = " 패배";
        }

    }

    void PlayerTurn()
    {
        dialogueText.text = " 어떻게 할까?";
    }

    IEnumerator PlayerHeal()
    {
        playerUnit2.Heal(5);
        playerHUD2.SetHP(playerUnit2.currentHP2);
        dialogueText.text = "You feel renewed strength!";

        yield return new WaitForSeconds(2f);

        state2 = BattleState2.ENEMYTURN;
        StartCoroutine(EnemyTurn());

    }

    public void OnAttackButton()
    {
        if (state2 != BattleState2.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

    public void OnHealButton()
    {
        if (state2 != BattleState2.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }
}
