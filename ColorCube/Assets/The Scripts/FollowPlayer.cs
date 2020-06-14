using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{ 
         
	public float smoothSpeed = 2f;
	public Vector3 offset;

	void FixedUpdate ()
	{  GameObject Player = GameObject.FindWithTag("Player1.0");
           Transform PlayerT = Player.transform;
		Vector3 desiredPosition = PlayerT.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;

		transform.LookAt(PlayerT);
	}
}
