using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{

	public int Sub_totalNumber = 4;
	public int Destroyer_totalNumber = 3;
	public int Crusier_totalNumber = 2;
	public int Battleship_totalNumber = 1;

	public int SpawnOnlyOnce = 0;

	public enum ShipType { None, Sub, Destroyer, Crusier, Battleship}
	public ShipType currentShip;
//	private int Submarine_HP = 1;
//	private int Destroyer_HP = 2;
//	private int Crusier_HP = 3;
//	private int Battleship_HP = 4;

	public GameObject[] ShipList = new GameObject[4];


	void Start () 
	{
		currentShip = ShipType.None;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}



	public void SpawnBoat(int BoatID)
	{
		if(SpawnOnlyOnce == 1)
		{
			GameObject Boat = Instantiate (ShipList[BoatID], new Vector3 (0f,0f,0f), Quaternion.identity) as GameObject;
			SpawnOnlyOnce = 0;
		}

	}

	public void SpawnSubmarine()
	{

		if (Sub_totalNumber == 0) 
		{
			currentShip = ShipType.None;
			Debug.Log("YOU SHALL NOT SPAWN...ANYMORE SUBMARINES!!");
			return;
		}
		Sub_totalNumber--;
		SpawnOnlyOnce++;
		currentShip = ShipType.Sub;
		SpawnBoat (0);
		Debug.Log("You may spawn " + Sub_totalNumber + " more Submarines.");
	
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
		SpawnOnlyOnce++;
		currentShip = ShipType.Destroyer;
		SpawnBoat (1);
		Debug.Log("You may spawn " + Destroyer_totalNumber + " more Destroyers.");
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
		SpawnOnlyOnce++;
		currentShip = ShipType.Crusier;
		SpawnBoat (2);
		Debug.Log("You may spawn " + Crusier_totalNumber + " more Crusiers.");
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
		SpawnOnlyOnce++;
		currentShip = ShipType.Battleship;
		SpawnBoat (3);
		Debug.Log("You may spawn " + Battleship_totalNumber + " more Battleships.");
	}

}
