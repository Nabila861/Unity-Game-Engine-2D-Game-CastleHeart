using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
private void OnTriggerEnter2D (Collider2D col){

     if (col.tag == "Player")
    col.GetComponent<PlayerHealth>().TakeDamage(20);}
}
