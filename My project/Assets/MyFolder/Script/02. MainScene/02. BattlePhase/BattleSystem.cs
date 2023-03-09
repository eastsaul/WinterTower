using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST} 

public class BattleSystem : MonoBehaviour
{
    public GameObject[]monsters = new GameObject[10];

    

    public GameObject playerPrefab;
    //public GameObject enemyPrefab;

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

    public BattleState state;

    
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    public void OnEnable()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    //public void OnDisable()
    //{
    //    enemyUnit.gameObject.SetActive(false);
    //}

    //IEnumerator Act() //
    //{

    //    StartCoroutine(SetupBattle());

    //    yield return null;

    //    //if (enemyUnit.gameObject.activeSelf == false) 
    //    //{
    //    //    SetupBattle();
    //    //}
    //    //yield return(true);
    //}

    //public void Act2() //
    //{
    //    SetupBattle();
    //}


    IEnumerator SetupBattle() 
    {
        GameObject playerGo = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGo.GetComponent<Unit>();

        GameObject enemyGo = Instantiate(monsters[gameManager.stageIndex], enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Unit>();

        dialogueText.text = "살기를 뿜으며 " + enemyUnit.unitName + "가 접근중...";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
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
            state = BattleState.WON;
            EndBattle();
        }
        else 
        {
            // Enemy turn
            state = BattleState.ENEMYTURN;
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
            state = BattleState.LOST;
            EndBattle();
        }
        else 
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle() 
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = " 승리!";

            isMonsterDown = true;

            enemyUnit.gameObject.SetActive(false);
            battlePhaseUp.SetActive(false);
            trophyInfoPopUp.SetActive(true);
            //gameManager.NextStage();
        } 
        else if (state == BattleState.LOST) 
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

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());

    }

    public void OnAttackButton() 
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }
}
