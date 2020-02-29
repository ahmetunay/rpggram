using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectedHero : MonoBehaviour
{
    public TestBattle instanceBattleHeros;
    public int TeamCount = 3;
    public void SelectHero(Hero s)
    {


        if (TeamCount>=1)
        {
            TeamCount = TeamCount - 1;
            Debug.Log("TeamCount" + TeamCount); ;
            
            instanceBattleHeros.Heros.Add(s);
        }
        else
        {
            Debug.Log("Slots Are Full !!! ");
        }
        
    }
    public void UnSelectHero(Hero s)
    {
        TeamCount = TeamCount + 1;
        Debug.Log("UnSelect: " + s.name);
        instanceBattleHeros.Heros.Remove(s);
    }
}



