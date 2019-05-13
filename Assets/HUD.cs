using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
	//public Text counter_text;
	//Card card = new Card(9, CardTypesEnum.MELEE, "Black Lotus", "This is super powerful awesome card that makes you win", false);

	private static int Size = 5; //jumlah card yang dibikin
	GameObject[] Cards = new GameObject[Size];

    void Start()
    {
    	//counter_text.text = card.Point.ToString();
		GameObject canvas = GameObject.Find("Canvas"); //cari "Canvas" untuk dijadikan parent

		for (int i = 0; i < Size; i++)
		{
		    //Create the game object
		    Cards[i] = Instantiate (Resources.Load ("Card")) as GameObject;  //"Card" harus ada di folder Assets/Resource

		    //Position it in the scene
		    Cards[i].transform.position = new Vector3(i * 0.32f, 250, 0);
		    Cards[i].transform.parent = canvas.transform; //parentnya Canvas, childnya Card(s)
		}        
    }

    void Update()
    {
        
    }
}
