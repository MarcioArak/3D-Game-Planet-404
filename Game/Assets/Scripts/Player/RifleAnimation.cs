using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleAnimation : MonoBehaviour
{
    private GameObject hand;
    private Transform trigger;
    private bool rotate = true;


    void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rotate = false;

            // Change it to true, so player can change to rifle animation
            PlayerStats.hasRifle = true;

            // Gets the Player's hand object by tag
            hand = GameObject.FindGameObjectWithTag("TriggerHand");

            // Get the transform of hand and set it as parent of the rifle
            trigger = hand.GetComponent<Transform>();
            transform.SetParent(trigger);

            // Locate the rifle in the players hand
            this.transform.localPosition = new Vector3(0, 0, 0);
            this.transform.localEulerAngles = new Vector3(88f, 121f, 125f);
        }
    }
}
