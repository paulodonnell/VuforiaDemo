using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour 
{
	public bool moveLeft = false;
	public float moveThreshold = 4f;
	public float moveAmount = 0.01f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float posX = this.transform.position.x;

		//Debug.Log("x " + posX);

		if (moveLeft) 
		{
			posX -= moveAmount;

			if(posX <= -moveThreshold)
			{
				posX = -moveThreshold;
				moveLeft = false;
			}
		}
		else
		{
			posX += moveAmount;

			if(posX >= moveThreshold)
			{
				posX = moveThreshold;
				moveLeft = true;
			}
		}

		this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);
	}
}
