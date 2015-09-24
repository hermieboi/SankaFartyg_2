using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{

	public int Sub_totalNumber = 4;
//	public int CurrentSubsSpawned = 0;

	public int Destroyer_totalNumber = 3;
//	public int CurrentDesSpawned = 0;

	public int Crusier_totalNumber = 2;
//	public int CurrentCrusSpawned = 0;

	public int Battleship_totalNumber = 1;
//	public int CurrentBattlesSpawned = 0;


	public int SpawnOnlyOnce = 0; //public bool SpawnOnlyOnce = false;

	public enum ShipType { None, Sub, Destroyer, Crusier, Battleship}
	public ShipType currentShip;
//	private int Submarine_HP = 1;
//	private int Destroyer_HP = 2;
//	private int Crusier_HP = 3;
//	private int Battleship_HP = 4;

	ChaseMouse _chaseMouse;


	public GameObject[] ShipList = new GameObject[4];  //This is not neccessary right now as it is a graphical thing and Im behind quite a lot so I have to focus on the basics. Will try to make this work later on if I have time though.


	void Start () 
	{
		currentShip = ShipType.None;
		_chaseMouse = GameObject.Find ("_GameManager").GetComponent<ChaseMouse>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}








//	public void SpawnBoat(int BoatID)
//	{
//		if(SpawnOnlyOnce == 1) //SpawnOnlyOnce == true;
//		{
//			GameObject Boat = Instantiate (ShipList[BoatID], new Vector3 (_chaseMouse.mousePoz.x, _chaseMouse.mousePoz.y, 0f), Quaternion.identity) as GameObject;   // Same here, just a graphical thing to make it look more nice, adding a transparent prefab on the mouse of the same boat type that I want to spawn.
//			SpawnOnlyOnce = 0; //SpawnOnlyOnce == false;
//		}
//
//	}

	public void SpawnSubmarine()
	{

		if (Sub_totalNumber == 0) 
		{
			currentShip = ShipType.None;
			Debug.Log("YOU SHALL NOT SPAWN...ANYMORE SUBMARINES!!");
			return;
		}

//		CurrentSubsSpawned++;
		Sub_totalNumber--;
//		SpawnOnlyOnce = 1; //True
		currentShip = ShipType.Sub;
//		SpawnBoat (0);
		Debug.Log("You may spawn " + Sub_totalNumber + " more Submarines. - Message from SpawnManager (SpawnSubmarine).");
//		Debug.Log("Because you have spawned " + CurrentSubsSpawned + " out of "+ Sub_totalNumber + " Submarines. - Message from SpawnManager (SpawnSubmarine).");


	
	}

	public void SpawnDestroyer()
	{
		if (Destroyer_totalNumber == 0) 
		{
			currentShip = ShipType.None;
			Debug.Log("YOU SHALL NOT SPAWN...ANYMORE DESTROYERS!!");
			return;
		}
		Destroyer_totalNumber--;
//		SpawnOnlyOnce = 1;
		currentShip = ShipType.Destroyer;
//		SpawnBoat (1);
		Debug.Log("You may spawn " + Destroyer_totalNumber + " more Destroyers. - Message from SpawnManager (SpawnDestroyer).");
	}

	public void SpawnCrusier()
	{
		if (Crusier_totalNumber == 0) 
		{
			currentShip = ShipType.None;
			Debug.Log("YOU SHALL NOT SPAWN...ANYMORE CRUSIERS!!");
			return;
		}
		Crusier_totalNumber--;
//		SpawnOnlyOnce = 1;
		currentShip = ShipType.Crusier;
//		SpawnBoat (2);
		Debug.Log("You may spawn " + Crusier_totalNumber + " more Crusiers. - Message from SpawnManager (SpawnCrusier).");
	}

	public void SpawnBattleship()
	{
		if (Battleship_totalNumber == 0) 
		{
			currentShip = ShipType.None;
			Debug.Log("YOU SHALL NOT SPAWN...ANYMORE BATTLESHIPS!!");
			return;
		}

		Battleship_totalNumber--;
//		SpawnOnlyOnce = 1;
		currentShip = ShipType.Battleship;
//		SpawnBoat (3);
		Debug.Log("You may spawn " + Battleship_totalNumber + " more Battleships. - Message from SpawnManager (SpawnBattleship).");
	}

}
