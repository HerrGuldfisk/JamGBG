using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
	public GameObject brick;

	public bool autoDrop;
	public float horizontalSpeed = 5f;

	[SerializeField] float spawnDelay = 0.8f;

	public float timeBetweenDrops = 4;
	public float timeLeft = 4;
	[SerializeField] GameObject dropCooldownBar;
	[SerializeField] Transform barPosInWorld;
	Transform barTrans;
	Slider fillSlider;

	[HideInInspector] public bool isOverlap;

	AudioSource audioSource;

	Rigidbody2D nextBody2D;

	private GuideLines guideLines;

	public Sprite closedHook;
	public Sprite openHook;
	SpriteRenderer spriteRenderer;

    void Start()
    {
		spriteRenderer = GetComponent<SpriteRenderer>();
		audioSource = GetComponent<AudioSource>();

		//cooldown bar setup
		barTrans = Instantiate(dropCooldownBar, Camera.main.WorldToScreenPoint(barPosInWorld.position), Quaternion.identity, FindObjectOfType<Canvas>().transform).transform;
		fillSlider = barTrans.GetComponent<Slider>();
		barTrans.gameObject.SetActive(false);

		foreach(Transform child in barTrans)
        {
			if (child.CompareTag("Fill"))
            {
				child.GetComponent<Image>().color = GetComponent<SpriteRenderer>().color;
            }
        }

		guideLines = GetComponent<GuideLines>();
}

    private void Update()
    {
		if (timeLeft > 0)
        {
			timeLeft -= Time.deltaTime;
        }

		barTrans.position = Camera.main.WorldToScreenPoint(barPosInWorld.position);
		fillSlider.value = timeLeft / timeBetweenDrops;
	}

    public void OnAction(InputValue action)
	{
		if (autoDrop)
		{
			return;
		}

	}

	public void DropBrick(float timeUntilNextDrop)
	{

		if (isOverlap)
		{
			audioSource.Play();
			return;
		}

		if (nextBody2D)
		{
			nextBody2D.simulated = true;
			nextBody2D.transform.SetParent(null);
		}

		spriteRenderer.sprite = openHook;

		StartCoroutine(SpawnAfterDelay(spawnDelay, timeUntilNextDrop-spawnDelay));
	}

	IEnumerator SpawnAfterDelay(float delay, float timeUntilDrop)
	{
		yield return new WaitForSeconds(delay);

		barTrans.gameObject.SetActive(true);
		timeBetweenDrops = timeUntilDrop;
		timeLeft = timeUntilDrop;

		nextBody2D = Instantiate(brick, transform.position + new Vector3(0, -1.65f, 0), Quaternion.identity, transform).GetComponent<Rigidbody2D>();

		guideLines.SetLines(nextBody2D.transform.position, nextBody2D.gameObject.GetComponent<BoxCollider2D>().size.x);
		guideLines.SetRect(nextBody2D.transform.position, nextBody2D.gameObject.GetComponent<BoxCollider2D>().size.x);

		spriteRenderer.sprite = closedHook;
	}


	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			isOverlap = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Brick"))
		{
			isOverlap = false;
		}
	}
}
