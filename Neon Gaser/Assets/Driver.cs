using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Na ovaj nacin dodajemo atribute nasim varijablama i blize ih odredjujemo
    [SerializeField]float steerSpeed = 1f;
    [SerializeField]float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 15f;
 
    // Start is called before the first frame update
    void Start()
    {
        // Debug log je da ispisemo debug text ako zelimo da vidimo da se nesto pokrece
        Debug.Log("Driver");
    }
    // Update is called once per frame
    void Update()
    {
        //Ovde deklarisemo varijablu za koliko cemo skretati odnosno kretati se napred
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //Ovde dodajemo suvu opciju kretanja i skretanja koja je kontrolisana pomocu varijable
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("Speed Boost!!!");
            moveSpeed = boostSpeed;
        }
    }
     void OnCollisionEnter2D(Collision2D other) 
    {
            moveSpeed = slowSpeed;
   // Wait for some seconds
    }

} 

