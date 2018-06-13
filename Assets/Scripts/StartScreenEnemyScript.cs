using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenEnemyScript : MonoBehaviour
{
    //Variable to hold the object's current and next position
    public float currentX;
    public float targetX;

    //Variable to check if the object is moving
    public bool isMoveTime;

    //Variable to control the movement speed of the object
    public float moveSpeed;


    void Start ()
    {
        currentX = this.transform.position.x;
    }
	
	void Update ()
    {
        if (isMoveTime)
        {
            //Check movement direction to change object's direction
            if (targetX < transform.position.x)
            {
                float yRotation = -90.0f;
                transform.rotation = Quaternion.Lerp(transform.rotation,
                                                    Quaternion.Euler(transform.eulerAngles.x, yRotation,transform.eulerAngles.z),
                                                    moveSpeed);
            }

            else if (targetX > transform.position.x)
            {
                float yRotation = 90.0f;
                transform.rotation = Quaternion.Lerp(transform.rotation,
                                                    Quaternion.Euler(transform.eulerAngles.x, yRotation, transform.eulerAngles.z),
                                                    moveSpeed);
            }

            //Moves the Object
            this.transform.position = new Vector3(Mathf.MoveTowards(currentX, targetX, moveSpeed),
                                                        transform.position.z);

            //Updates the current position as it moves
            currentX = this.transform.position.x;
        }

        if (!isMoveTime)
        {
            //Creates a random number
            float randXPos = Random.Range(-25f, 25f);

            //Updates the target position
            targetX = randXPos;

            //Set the object moving again
            isMoveTime = true;
        }

        //Stops the object if the target is reached
        if (currentX == targetX)
        {
            isMoveTime = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Randomly generates a new position
        float newPos = Random.Range(3f, 16f);

        //Checks the direction that the object is moving
        if (targetX < currentX)
        {
            //Updates the target position
            targetX = currentX + newPos;
        }

        else if (targetX > currentX)
        {
            targetX = currentX - newPos;
        }
    }
}
