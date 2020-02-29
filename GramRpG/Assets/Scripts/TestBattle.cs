using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TestBattle : MonoBehaviour
{
    public Hero enemy;
    public Button enemyButton;
    public List<Hero> Heros = new List<Hero>();
    public List<Button> FightButtons = new List<Button>();
    public int BattleCounter;



    void Start() 
    {
        Button enemyBtn = enemyButton.GetComponent<Button>();
        enemyBtn.onClick.AddListener( delegate { EnemyAttack(); } );

        foreach (Button el in FightButtons)
        {
            int idx = FightButtons.IndexOf(el);
            el.onClick.AddListener(
                delegate
                {
                    PlayerAttack(Heros[idx]);
                }
            );
        }

    }
    void PlayerAttack(Hero h)
    {
        Hero hh = h;
        if (isEnemyAlive())
        {
            if (isPlayerAlive())
            { 
                if (h.health > 0)
                {
                    enemy.health = enemy.health - h.attack;
                    Debug.Log(h.name + " attack to ENEMY and ENEMY HAVE" + enemy.health + "hp point");
                    if (isEnemyAlive())
                    {
                        EnemyAttack();
                    }
                }
            }
        } 
    }
    void EnemyAttack()
    {
        if (isEnemyAlive())
        {
            if (isPlayerAlive())
            {
                int eselect = Random.Range(0, 3);
                if (Heros[eselect].health > 0)
                {
                    Heros[eselect].health = Heros[eselect].health - enemy.attack;
                    Debug.Log("Enemy attack to " + Heros[eselect].name + " and " + Heros[eselect].name + " have a " + Heros[eselect].health + " hp point");
                }
                else
                {
                    EnemyAttack();
                }
            }
        }
        else
        {
            Debug.Log("Player Winn ----Enemy Func");
        }

    }
    bool isPlayerAlive()
    {
        if (Heros[0].health > 0 || Heros[1].health > 0 || Heros[2].health > 0)
        {
            return true;
        }
        else
        {
            Debug.Log("Enemy Win---- isPlayerAlive Func ");
            return false;
        }
    }
    bool isEnemyAlive()
    {
        if (enemy.health <= 0)
        {
            Debug.Log("Players Win");
           
            HealUP();
            return false;
        }
        else
        {
            return true;
        }
    }
    void HealUP()
    {
        enemy.health = 20f;
        Heros[0].health = 5f;
        Heros[1].health = 10f;
        Heros[2].health = 15f;

    }
    void GameOver(Hero H) 
    {
        //Open Panel
        //Panel.text= H.name win
       
    
    }

}