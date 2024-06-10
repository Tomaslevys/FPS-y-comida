using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionArea : MonoBehaviour
{
    int puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PickupScript pickup;
        pickup = other.GetComponent<PickupScript>();
        puntaje += pickup.PuntosItem;
        if 
        Debug.Log("EN CONTACTO");
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
