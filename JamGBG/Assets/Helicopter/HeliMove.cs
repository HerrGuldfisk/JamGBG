using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeliMove : MonoBehaviour
{

	public Vector2 dir;
	public float speed;
    // Start is called before the first frame update

	public void OnMove(InputValue input)
	{
		dir = input.Get<Vector2>();
		Debug.Log(dir.x);
	}

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		transform.position += new Vector3(dir.x, 0, 0) * speed * Time.deltaTime;
	}
}
