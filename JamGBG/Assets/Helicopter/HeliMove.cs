using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeliMove : MonoBehaviour
{

	float dir;
	public float speed = 3;
    // Start is called before the first frame update

	public void OnMove(InputValue input)
	{
		dir = input.Get<Vector2>().x;
	}

	private void Update()
	{
		Move();
	}

	private void Move()
	{
		transform.position += new Vector3(dir, 0, 0) * speed * Time.deltaTime;
	}
}
