using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody force; 

    public float forewardForce = 1000;
    public float sidewaysForce = 600;

    void FixedUpdate()
    {
        force.AddForce(0, 0, forewardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            force.AddForce(sidewaysForce * Time.deltaTime , 0 , 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") )
        {
            force.AddForce(-sidewaysForce * Time.deltaTime , 0 , 0, ForceMode.VelocityChange);
        }

    }
}

