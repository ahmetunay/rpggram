using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Hero enemy;
    public Hero[] Heros = new Hero[3];

    void Start()
    {
        Battle();
    }
    void Battle()
    {
        EnemyAttack();

    }
    void PlayerAttack()
    {
        if (isEnemyAlive())
        {
            if (isPlayerAlive())
            {
                int pselect = Random.Range(0, 3);
                if (Heros[pselect].health > 0)
                {
                    enemy.health = enemy.health - Heros[pselect].attack;
                    Debug.Log(Heros[pselect].name + " attack to ENEMY and ENEMY HAVE" + enemy.health + "hp point");
                    if (isEnemyAlive())
                    {
                        EnemyAttack();
                    }
                }
                else
                {
                    PlayerAttack();
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
                    if (isPlayerAlive())
                    {
                        PlayerAttack();
                    } 
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
}