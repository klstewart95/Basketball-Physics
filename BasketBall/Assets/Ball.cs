using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float Velocity;
    float Vx;
    float Vy;

    public float Theta;

    Vector3 BallMovement = Vector3.zero;

    bool ShotBall = false;

	// Use this for initialization
	void Start () {
        
            
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!ShotBall)
            {
                LaunchBall();
                ShotBall = true;

                Destroy(gameObject, 5);
            }
        }

        if (ShotBall)
        {
            getVelocity();
        }
    }

    public void LaunchBall()
    {
        Vx = Velocity * (Mathf.Cos(Theta * Mathf.Deg2Rad));
        Vy = Velocity * (Mathf.Sin(Theta * Mathf.Deg2Rad));

        BallMovement.z = Vx;
        BallMovement.y = Vy;
    }

    void getVelocity()
    {
        BallMovement.y = BallMovement.y - (.98f);
        transform.Translate(BallMovement * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        BallMovement.z = (BallMovement.z * 0.5f) * -1;

        if(other.tag == "Hoop")
        {
            Debug.LogError("Scored");
            Destroy(gameObject);
        }
    }

}
