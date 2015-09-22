using UnityEngine;
using System;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour 
{
	public GameObject cubePrefab;
	public int heightY = 10;
	public int widthX = 10;
	private Transform boardHolder1;
	private Transform boardHolder2;
	
	

	void Start () 
	{
		PlayerBoard ();
		EnemyBoard();
		
	}
	

	void Update () 
	{
		
	}


	// Här skapar jag en board till spelaren med hjälp av två for-satser.
	public void PlayerBoard()
	{
		boardHolder1 = new GameObject ("PlayerBoard").transform;		// Här skapar jag ett gameObject som fungerar som en parent, så att kuberna hamnar under den i hiearkin. Detta för att det inte ska bli lika rörigt i inspectorn.
		for (int i = 0; i < heightY; i++) 								// Börjar med att skapa en kub med 0,0,0.
		{																
			for (int j = 0; j < widthX ; j++)							// Sedan skapas 9 till i x leden. så att det blir 0,9,0.
			{
				GameObject go = Instantiate (cubePrefab, new Vector3 (j,i,0f), Quaternion.identity) as GameObject;
				go.name = ("PlayerCoords: X: "+ (j + 1) + ", " + "Y: " + (i + 1)).ToString();																	// Här ger jag varje kub i boardet ett namn med dess koordinater.
				go.tag = "PlayerTile";
				go.GetComponent<CubeManager>().XX = (j + 1);
				go.GetComponent<CubeManager>().YY= (i + 1);
				go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z);
				go.transform.SetParent(boardHolder1);

			}
		}
		Debug.Log ("Playerboard created!");
	}

	// Här skapar jag likt ovan en board, men döper den till Enemyboard istället.
	public void EnemyBoard()
	{
		boardHolder2 = new GameObject ("EnemyBoard").transform;
		for (int i = 0; i < heightY; i++) 
		{
			for (int j = 0; j < widthX ; j++)
			{
				GameObject go1 = Instantiate (cubePrefab, new Vector3 (j,i,0f), Quaternion.identity) as GameObject;
				go1.name = ("EnemyCoords: X: "+ (j + 1) + ", " + "Y: " + (i + 1)).ToString();															// Ger kuberna ett namn med koordinater som ovan.
				go1.transform.position = new Vector3(go1.transform.position.x + 15, go1.transform.position.y, 0f);				// Här instantierar jag boarden 15 koordinater längre bort (till vänster) så att den inte de båda boardsen hamnar ovanpå varandra.
				go1.tag = "EnemyTile";
				go1.GetComponent<CubeManager>().XX = (j + 1);
				go1.GetComponent<CubeManager>().YY= (i + 1);
				go1.transform.SetParent(boardHolder2);

				
			}
		}
		Debug.Log ("Enemyboard created!");
	}
	
}

