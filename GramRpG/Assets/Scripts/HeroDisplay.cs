using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

	public Hero hero;

	public Image artworkImage;

	public Text nameText;
	public Text attackText;
	public Text healthText;
	public Text expText;
	public Text levelText;

	// Use this for initialization
	void Start()
	{
		nameText.text = hero.name;

		artworkImage.sprite = hero.artwork;
		
		attackText.text = hero.attack.ToString();
		
		healthText.text = hero.health.ToString();

		expText.text = hero.exp.ToString();

		levelText.text = hero.level.ToString();
	}

}
