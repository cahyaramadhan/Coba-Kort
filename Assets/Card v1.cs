using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardTypesEnum { MELEE, RANGED, SIEGE, WEATHER, BUFF };

public class Card
{
	private int cardPoint;
	private CardTypesEnum typeOfCard;
	private string cardName;
	private string cardDesc;
	private bool isHeroCard;

	public Card(int cardPoint, CardTypesEnum typeOfCard, string cardName, string cardDesc, bool isHeroCard){
		this.cardPoint = cardPoint;
		this.typeOfCard = typeOfCard; 
		this.cardName = cardName;
		this.cardDesc = cardDesc;
		this.isHeroCard = isHeroCard;
	}

    public int Point
    {
    	get
    	{
    		return cardPoint;
    	}
    	set
    	{
    		cardPoint = value;
    	}
    }

    public CardTypesEnum Type
    {
    	get
    	{
    		return typeOfCard;
    	}
    	set
    	{
    		typeOfCard = value;
    	}
    }

    public string Name
    {
    	get
    	{
    		return cardName;
    	}
    	set
    	{
    		cardName = value;
    	}
    }

    public string Desc
    {
    	get
    	{
    		return cardDesc;
    	}
    	set
    	{
    		cardDesc = value;
    	}
    }

    public bool IsHeroCard
    {
    	get
    	{
    		return isHeroCard;
    	}
    	set
    	{
    		isHeroCard = value;
    	}
    }

}