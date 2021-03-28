using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeliMove : MonoBehaviour
{

	public Vector2 dir;

	Vector3 position;

	private float speed = 0.0f;
	private float startSpeed = 4f;
	private float maxSpeed = 30.0f;
	private float acce = 30.0f;
	private float dece = 200.0f;

    private void Awake()
    {
		position = transform.position;
    }

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
		/*
		if (dir.x != 0)
		{
			if (speed == 0)
			{
				speed = startSpeed;
			}

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
		} */

		if (dir.x != 0)
		{
			if (speed == 0)
			{
				speed = startSpeed * dir.x;
			}
		}

		if (dir.x > 0 && speed > -maxSpeed)
		{
			if (speed < maxSpeed)
			{
				//speed += acce * Time.deltaTime;

				speed = Mathf.Min(maxSpeed, speed + acce * Time.deltaTime);
			}
			else
			{
				speed = maxSpeed;
			}
		}
		else if (dir.x < 0 && speed < maxSpeed)
		{
			if (speed > -maxSpeed)
			{
				//speed -= acce * Time.deltaTime;

				speed = Mathf.Max(-maxSpeed, speed - acce * Time.deltaTime);
			}
			else
			{
				speed = -maxSpeed;
			}
		}
		else 
		{
			if (dir.x == 0)
            {
				if (speed > dece * Time.deltaTime)
				{
					speed -= dece * Time.deltaTime;
				}
				else if (speed < -dece * Time.deltaTime)
				{
					speed += dece * Time.deltaTime;
				}
				else
				{
					speed = 0;
				}
			}
		}

		Debug.LogWarning(speed);

		position.x = transform.position.x + speed * Time.deltaTime;
		transform.position = position;

		//transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

		//transform.position += new Vector3(dir.x, 0, 0) * speed * Time.deltaTime;
	}
}
