using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card_v2")]
public class Card_v2 : ScriptableObject
{
	public new string name;
	public string description;

	public Sprite artwork;

	public int point;
	public string typeOfCard;

	public void Print()
	{
		Debug.Log(name + ": " + description + " Point: " + point);
	}

}
