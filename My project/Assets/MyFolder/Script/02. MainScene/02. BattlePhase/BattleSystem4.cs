using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState4 { START, PLAYERTURN, ENEMYTURN, WON, LOST} 

public class BattleSystem4 : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public GameManager gameManager;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public TMP_Text dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    //public HUDTest playerHUD;
    //public HUDTest enemyHUD;

    public GameObject trophyInfoPopUp;
    public GameObject battlePhaseUp;

    public bool isMonsterDown = default;

    public BattleState4 state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState4.START;
        StartCoroutine(SetupBattle());
    }


    IEnumerator SetupBattle() 
    {
        GameObject playerGo = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGo.GetComponent<Unit>();

        GameObject enemyGo = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Unit>();

        dialogueText.text = "살기를 뿜으며 " + enemyUnit.unitName + "가 접근중...";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState4.PLAYERTURN;
        PlayerTurn();
    }


    IEnumerator PlayerAttack() 
    {
        // Damage the enemy
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = "The attack is successful!";

        yield return new WaitForSeconds(2f);

        // check if the enemy is dead
        // change state based on what happened

        if (isDead)
        {
            // End the battle
            state = BattleState4.WON;
            EndBattle();
        }
        else 
        {
            // Enemy turn
            state = BattleState4.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

    IEnumerator EnemyTurn() 
    {
        dialogueText.text = enemyUnit.unitName + " 의 공격!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState4.LOST;
            EndBattle();
        }
        else 
        {
            state = BattleState4.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle() 
    {
        if (state == BattleState4.WON)
        {
            dialogueText.text = " 승리!";

            isMonsterDown = true;

            battlePhaseUp.SetActive(false);
            trophyInfoPopUp.SetActive(true);
            //gameManager.NextStage();
        } 
        else if (state == BattleState4.LOST) 
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
        playerUnit.Heal(5);
        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "You feel renewed strength!";

        yield return new WaitForSeconds(2f);

        state = BattleState4.ENEMYTURN;
        StartCoroutine(EnemyTurn());

    }

    public void OnAttackButton() 
    {
        if (state != BattleState4.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

    public void OnHealButton()
    {
        if (state != BattleState4.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }
}
