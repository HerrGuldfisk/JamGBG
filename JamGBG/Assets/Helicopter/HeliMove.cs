using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeliMove : MonoBehaviour
{

	public Vector2 dir;

	private float speed = 0.0f;
	private float maxSpeed = 30.0f;
	private float acce = 30.0f;
	private float dece = 1000.0f;

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
		if (dir.x != 0)
		{
			if (speed < maxSpeed)
			{
				speed += acce * Time.deltaTime;
			}
			else if (speed > maxSpeed)
			{
				speed = maxSpeed;
			}
		}
		else
		{
			if (speed > 0)
			{
				speed -= dece * Time.deltaTime;
			}
			else
			{
				speed = 0;
			}
		}

		transform.position += new Vector3(dir.x, 0, 0) * speed * Time.deltaTime;
	}
}
