using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
	public Card_v2 card;

	public Text nameText;
	public Text descriptionText;

	public Image artworkImage;

	public Text pointText;
	public Text typeText;


    void Start()
    {
    	nameText.text = card.name;
    	descriptionText.text = card.description;
    	artworkImage.sprite = card.artwork;
    	pointText.text = card.point.ToString();
    	typeText.text = card.typeOfCard.ToString();
    }

}
