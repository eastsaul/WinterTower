using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    //public List<Card> disCard = new List<Card>();

    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    //public GameObject[] temp;
    //public static bool isOpen;

    public void DrawCard() 
    {
        if(deck.Count >= 1) 
        {
            Card randCard = deck[Random.Range(0, deck.Count)];
            //Debug.Log($"{randCard.name}");

            // 중복이 아닐 때 까지 뽑음
            while (randCard.gameObject.activeSelf == true)
            {
                if (randCard.gameObject.activeSelf == true)
                {
                    randCard = deck[Random.Range(0, deck.Count)];
                }
                else        // 올바른 카드를 뽑은 경우에는 더 뽑지 않는다
                { 
                    break; 
                }
            }       // loop: 중복이 아닐 때 까지 뽑음
                    // 카드의 활성도를 보고 중복일 경우 카드를 다시 뽑음

            for (int i = 0; i < availableCardSlots.Length; i++) 
            {
                if (availableCardSlots[i] == true) 
                {
                    //Debug.Log($"{randCard.name}를 설정하는 곳");
                    randCard.gameObject.SetActive(true);
                    //randCard.tag = "Open";

                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;

                    //deck.Remove(randCard);
                    return;
                }
            }
        }
    }

    public void ThreeDraw() 
    {
        //Debug.Log("세번뽑음?");
        DrawCard();
        DrawCard();
        DrawCard();
    }

    //public void Shuffle()
    //{
    //    if (disCard.Count >= 1)
    //    {
    //        foreach (Card card in disCard)
    //        {
    //            deck.Add(card);
    //        }
    //        disCard.Clear();
    //    }
    //}

    //public void Shot() 
    //{
    //    Shuffle();
    //    DrawCard();
    //}

    // exit 버튼
    public void CardCare()
    {
        //temp = GameObject.FindGameObjectsWithTag("Open");

        foreach (Card card in deck) // 데이터타입 변수 in 
        {
            if (card.gameObject.activeSelf == true) 
            {
                //Debug.Log($"{card.name}");
                card.gameObject.SetActive(false);
                
            }
        }       // loop: 리스트 내에서 활성화된 오브젝트를 찾아 비활성화 시킴

        for (int i = 0; i < availableCardSlots.Length; i++) 
        {
            availableCardSlots[i] = true;
        }
    }


}
