using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Na ovaj nacin dodajemo atribute nasim varijablama i blize ih odredjujemo
    [SerializeField]float steerSpeed = 1f;
    [SerializeField]float moveSpeed = 0.01f;

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
}
