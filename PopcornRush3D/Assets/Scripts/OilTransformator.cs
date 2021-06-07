using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilTransformator : MonoBehaviour
{

    public GameObject popcornParticle;
    void OnTriggerEnter(Collider whichCollider)
    {
        Debug.Log("Entered " + whichCollider.gameObject.name);
        var popcorn = whichCollider.gameObject.GetComponent<PopcornCharacter>();
        if (popcorn != null)
        {
            popcorn.ActivatePopcorn();
        }
        Instantiate(popcornParticle, transform.position, transform.rotation);
    }
}