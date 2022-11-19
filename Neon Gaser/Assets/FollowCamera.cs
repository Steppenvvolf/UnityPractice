using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //This script position is the same as the car's possition
    //Treba nam transform i pozicija objekta kojeg zelimo da pratimo
    // moramo kreirati referencu
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
        
    }
}
