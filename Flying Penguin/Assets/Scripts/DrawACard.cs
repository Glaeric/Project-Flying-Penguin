using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeckOfCards : MonoBehaviour
{
    public GameObject[] cards;
    public Transform cardSpawn = null;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {

            GameObject card = cards[Random.Range(0, cards.Length)];
            Instantiate(card);
            card.transform.SetParent(this.transform.parent);
        }
    }
}