using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IDs : MonoBehaviour 
{
	public int Clicks;
	public Image[] Numbers;
	public MyID[] Cards;
	public GameObject[] Cartas;
	private int CounterTo;
	private int MainCard;
	public bool Trying;
	private float j;	
	private bool Right;
	public float NonVired;
	public bool CanDesvira;
	public int Carta1;
	public int Carta2;
	public GameObject[] ActualCards;
	private int countingstars;
	void Start () 
	{
		Clicks = 0;
		j = 0;
		Trying = true;
		MainCard = Mathf.FloorToInt(Random.Range(0,11));
		CounterTo = 0;
		for(int i = 0; i < 12;i++)
		{
			Cards[i] = GameObject.Find(""+(i + 1)).GetComponent<MyID>();
		}	
	}
	void Update () 
	{
		if(Clicks == 2 && Carta1 != Carta2)
		{
			CanDesvira = true;
		}
		else if(Carta1 == Carta2 && Carta1 != 0 && Carta2 != 0)
		{
			ActualCards = GameObject.FindGameObjectsWithTag(Carta1+"");
			ActualCards[0].GetComponent<MyID>().Certou = true;
			ActualCards[1].GetComponent<MyID>().Certou = true;
			Carta1 = 0;
			Carta2 = 0;
			Clicks = 0;
		}
		if(CanDesvira)
		{
			NonVired += Time.deltaTime;
		}
		if(NonVired > 2f)
		{
			for(int i = 0; i < Cards.Length; i++)
			{
				Carta1 = 0;
				Carta2 = 0;
				NonVired = 0;
				CanDesvira = false;
				Clicks = 0;
				if(Cards[i].Certou == false)
				{
					Cards[i].Isvired = false;
				}
			}
		}
		if(j > 3f)
		{
			Trying = false;
		}
		else
		{
			j += Time.deltaTime;
		}
		if(Trying)
		{
			if(CounterTo < 2 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 1;
				Cartas[MainCard].tag = 1+"";
				CounterTo += 1;	
			}
			else if(CounterTo < 4 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 2;
				Cartas[MainCard].tag = 2+"";
				CounterTo += 1;	
			}
			else if(CounterTo < 6 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 3;
				Cartas[MainCard].tag = 3+"";
				CounterTo += 1;	
			}
			else if(CounterTo < 8 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 4;
				Cartas[MainCard].tag = 4+"";
				CounterTo += 1;	
			}
			else if(CounterTo < 10 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 5;
				Cartas[MainCard].tag = 5+"";
				CounterTo += 1;	
			}
			else if(CounterTo < 12 && Cards[MainCard].MyCard == 0)
			{
				Cards[MainCard].MyCard = 6;
				Cartas[MainCard].tag = 6+"";
				CounterTo += 1;	
			}
			else
			{
				for(int i = 0; i < 12; i++)
				{
					if(Cards[i].MyCard == 0)
					{
						MainCard = Mathf.FloorToInt(Random.Range(0,12));
					}
				}
			}
		}
	}
}
