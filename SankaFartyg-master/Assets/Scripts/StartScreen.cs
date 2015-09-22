using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour 
{

	private FSM fsm;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	 
	}


	void ChangeScene()
	{
		Application.LoadLevel (1);
	}
}
