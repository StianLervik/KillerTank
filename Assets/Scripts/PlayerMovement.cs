using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public float maxFart;

    private Rigidbody body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal")* Time.deltaTime, 0.0f, moveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
    }

    void FixedUpdate()
    {
        Vector3 fart = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.fixedDeltaTime * 100.0f;
        if (body.velocity.magnitude+fart.magnitude <= maxFart)
        {
            body.AddRelativeForce(fart);
        }
        else
        {
            body.velocity = Vector3.forward * maxFart;
        }
        //body.AddRelativeForce(Input.GetAxis("Horizontal")*Vector3.right*moveSpeed*Time.fixedDeltaTime * 100);
    }

}
