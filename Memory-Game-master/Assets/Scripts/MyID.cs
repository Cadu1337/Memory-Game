using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyID : MonoBehaviour 
{
	private IDs Clickzin;
	public int MyCard; 
	public bool Isvired;
	public Sprite[] IdImage;
	public Sprite MyImage;
	public bool Certou;
	
	void Start () 
	{
		Clickzin = GameObject.Find("Canvas").GetComponent<IDs>();
		MyImage = gameObject.GetComponent<Image>().sprite;
		for(int i = 0; i < 6; i++)
		{
			IdImage[i] = Resources.Load("Sprites/"+i,typeof(Sprite)) as Sprite;
		}
	}
	
	void Update () 
	{
		if(Isvired)
		{
			gameObject.GetComponent<Image>().sprite = MyImage;
			switch(MyCard)
			{
				case 1:
					MyImage = IdImage[0];
				break;
				case 2:
					MyImage = IdImage[1];
				break;
				case 3:
					MyImage = IdImage[2];
				break;
				case 4:
					MyImage = IdImage[3];
				break;
				case 5:
					MyImage = IdImage[4];
				break;
				case 6:
					MyImage = IdImage[5];
				break;
			}
		}
		else
		{
			gameObject.GetComponent<Image>().sprite = Resources.Load("Sprites/Default",typeof(Sprite)) as Sprite;
		}
	}
	public void OnClicked()
	{
		if(Clickzin.Clicks < 2)
		{
			Clickzin.Clicks += 1;
			if(Clickzin.Carta1 == 0 || Clickzin.Carta1 == null)
			{
				Clickzin.Carta1 = MyCard;
			}
			else if(Clickzin.Carta2 == 0 || Clickzin.Carta1 == null)
			{
				Clickzin.Carta2 = MyCard;
			}
			Isvired = true;
		}
	}
}
