using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[Range(1, 10)]
	public float speed = 2;
	public GameObject prefab;

	private void Awake()
	{
        
	}
	// Start is called before the first frame update
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
		//Vector3 position = transform.position;
		Vector3 velocity = Vector3.zero;
		velocity.x = Input.GetAxis("horizontal");
		velocity.z = Input.GetAxis("vertical");
		transform.position += velocity * speed * Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(prefab, transform.position + Vector3.up, Quaternion.identity);
		}
	}
}