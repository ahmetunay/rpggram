using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hero", menuName = "Hero")]
public class Hero : ScriptableObject
{

	public new string name;
	public int exp;
	public float attack;
	public float health;
	public int level=1;
	public Sprite artwork;

	public void levelUp()
	{
        if (5 >= exp)
        {
			exp = exp - 5;
			level = level + 1;
			attack = attack + (attack * 0.1f);
        }
	}

}