using UnityEngine;
using System.Collections;

public class CubeManager : MonoBehaviour 
{
	public int XX;
	public int YY;
	private Color baseColor;

	public GameObject SubmarinePrefab;
	public GameObject DestroyerPrefab;
	public GameObject CrusierPrefab;
	public GameObject BattleshipPrefab;

	SpawnManager SM;

	// Use this for initialization
	void Start () 
	{
		SM = GameObject.Find ("_GameManager").GetComponent<SpawnManager>();
		gameObject.GetComponent<MeshRenderer>().material.color = baseColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseOver ()
	{
		gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;

	}

	void OnMouseDown()
	{
		if(SM.currentShip == SpawnManager.ShipType.Sub && gameObject.name == "PlayerCoords: X: " + XX + ", Y: " + YY)
		{
//			GameObject ShadowSub = GameObject.FindGameObjectWithTag("TransparentSub");
//			Debug.Log ("ShadowSub spawned!");

//		
//			if(ShadowSub != null)
//			{
//				ShadowSub.GetComponent<ChaseMouse>().Chasing = false;
//				ShadowSub.GetComponent<ChaseMouse>().Death = true;
//				Debug.Log ("ShadowSub destroyed!");
//			}

			Instantiate(SubmarinePrefab,transform.position,Quaternion.identity);
		
			Debug.Log ("CubeManager i farten.");

			if(SM.Sub_totalNumber < 1)
			{
				SM.currentShip = SpawnManager.ShipType.None;
			}
		}

	
		else if (SM.currentShip == SpawnManager.ShipType.Destroyer && gameObject.name == "PlayerCoords: X: " + XX + ", Y: " + YY) 
		{
//			GameObject ShadowDestroyer = GameObject.FindGameObjectWithTag ("TransparentDes");
//
//			if (ShadowDestroyer != null) 
//			{
//
//				ShadowDestroyer.GetComponent<ChaseMouse> ().Chasing = false;
//				ShadowDestroyer.GetComponent<ChaseMouse> ().Death = true;
//				Debug.Log ("ShadowDestroyer destroyed!");
//			}
		
			Instantiate (DestroyerPrefab, transform.position, Quaternion.identity);

			if (SM.Destroyer_totalNumber < 1) 
			{
				SM.currentShip = SpawnManager.ShipType.None;
			}
		}

	else if (SM.currentShip == SpawnManager.ShipType.Crusier && gameObject.name == "PlayerCoords: X: " + XX + ", Y: " + YY) 
		{
//			GameObject ShadowCrusier = GameObject.FindGameObjectWithTag ("TransparentCrus");
//
//			if (ShadowCrusier != null) 
//			{
//				ShadowCrusier.GetComponent<ChaseMouse> ().Chasing = false;
//				ShadowCrusier.GetComponent<ChaseMouse> ().Death = true;
//			}

			Instantiate (CrusierPrefab, transform.position, Quaternion.identity);
			
			if (SM.Crusier_totalNumber < 1) 
			{
				SM.currentShip = SpawnManager.ShipType.None;
			}
		}


		else if(SM.currentShip == SpawnManager.ShipType.Battleship && gameObject.name == "PlayerCoords: X: " + XX + ", Y: " + YY)
		{
//			GameObject ShadowBattleship = GameObject.FindGameObjectWithTag("TransparentBattle");
//
//			if(ShadowBattleship != null)
//			{
//				ShadowBattleship.GetComponent<ChaseMouse>().Chasing = false;
//				ShadowBattleship.GetComponent<ChaseMouse>().Death = true;
//			}

			Instantiate(BattleshipPrefab,transform.position,Quaternion.identity);
	

			if(SM.Battleship_totalNumber < 1)
			{
				SM.currentShip = SpawnManager.ShipType.None;
			}

		}
	}


	void OnMouseExit ()
	{
		gameObject.GetComponent<MeshRenderer>().material.color = baseColor;
	}
	
}
