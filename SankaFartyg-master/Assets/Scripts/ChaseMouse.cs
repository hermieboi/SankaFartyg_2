using UnityEngine;
using System.Collections;

public class ChaseMouse : MonoBehaviour 
{
	
	public Vector3 mousePoz;
	private float x_Cords;
	private float y_Cords;
	public bool Chasing = true;
	public bool Death = false;

	SpawnManager SM;

	void Awake()
	{
	

	}

	void Start () 
	{

		mousePoz = transform.position;
	}
	

	void Update () 
	{

		ChasingMouse();
		if(Death == true)
		{
			Destroy(gameObject);
		}
	}




	void ChasingMouse()
	{

		if (Chasing)
		{
			mousePoz = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 15);
			mousePoz = Camera.main.ScreenToWorldPoint (mousePoz);
			transform.position = mousePoz;
		}

		if (!Chasing)
		{
			print ("Not chasing anything!");
		}
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
//			Destroy(gameObject);

			if(SM.currentShip == SpawnManager.ShipType.Sub)
			{
				SM.Sub_totalNumber = 4;
				Destroy(gameObject);
				Debug.Log ("You just destroyed: " + gameObject.name + ".");
				Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
			}

			else if(SM.currentShip == SpawnManager.ShipType.Destroyer)
			{
				SM.Destroyer_totalNumber = 3;
				Destroy(gameObject);
				Debug.Log ("You just destroyed: " + gameObject.name + ".");
				Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
			}

			else if(SM.currentShip == SpawnManager.ShipType.Crusier)
			{
				SM.Crusier_totalNumber = 2;
				Destroy(gameObject);
				Debug.Log ("You just destroyed: " + gameObject.name + ".");
				Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
			}

			else if(SM.currentShip == SpawnManager.ShipType.Battleship)
			{
				SM.Battleship_totalNumber = 1;
				Destroy(gameObject);
				Debug.Log ("You just destroyed: " + gameObject.name + ".");
				Debug.Log ("Placement canceled. You have 1 more " + gameObject.name + " to spawn.");
			}


		}

	}
}