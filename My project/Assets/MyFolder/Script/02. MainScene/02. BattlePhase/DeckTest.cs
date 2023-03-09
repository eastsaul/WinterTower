using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckTest : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    //public List<Card> disCard = new List<Card>();

    public Transform[] cardSlots;


    //public void DrawCard()
    //{
    //    if (deck.Count >= 1)
    //    {
    //        Card randCard = deck[Random.Range(0, deck.Count)];

    //        for (int i = 0; i < deck.Count; i++)
    //        {
    //            randCard.gameObject.SetActive(true);
    //            randCard.transform.position = cardSlots[0].position;
                

    //            deck.Remove(randCard);
    //            return;
    //        }
    //    }
    //}

    //public void CardCare()
    //{
    //    foreach (var item in deck)
    //    {
    //        if (gameObject.activeSelf == true)
    //        {
    //            gameObject.SetActive(false);
    //        }
    //    }
    //}

}
