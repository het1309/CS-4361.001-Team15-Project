using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 currentRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform> ().eulerAngles;
       if((Input.GetAxis("Horizontal") > .1) && (currentRot.z >=351 || currentRot.z <= 10 ))
       {
        transform.Rotate(0, 0, -1);
       } 
       if((Input.GetAxis("Horizontal") < -.1) && (currentRot.z <=8 || currentRot.z >= 349))
       {
        transform.Rotate(0, 0, 1);
       }
       if((Input.GetAxis("Vertical") > .1) && (currentRot.x <=8 || currentRot.x >= 349))
       {
        transform.Rotate(1, 0, 0);
       } 
       if((Input.GetAxis("Vertical") < -.1) && (currentRot.x >=351 || currentRot.x <= 10))
       {
        transform.Rotate(-1, 0, 0);
       }
    }
}