using UnityEngine;
using System.Collections;

public class SwordCollision : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag=="Health")
        {
           
        }

        if(other.tag=="Coin")
        {

        }

        if(other.tag=="Sword")
        {
            
        }

    }
}
