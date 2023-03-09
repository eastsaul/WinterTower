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

            // �ߺ��� �ƴ� �� ���� ����
            while (randCard.gameObject.activeSelf == true)
            {
                if (randCard.gameObject.activeSelf == true)
                {
                    randCard = deck[Random.Range(0, deck.Count)];
                }
                else        // �ùٸ� ī�带 ���� ��쿡�� �� ���� �ʴ´�
                { 
                    break; 
                }
            }       // loop: �ߺ��� �ƴ� �� ���� ����
                    // ī���� Ȱ������ ���� �ߺ��� ��� ī�带 �ٽ� ����

            for (int i = 0; i < availableCardSlots.Length; i++) 
            {
                if (availableCardSlots[i] == true) 
                {
                    //Debug.Log($"{randCard.name}�� �����ϴ� ��");
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
        //Debug.Log("��������?");
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

    // exit ��ư
    public void CardCare()
    {
        //temp = GameObject.FindGameObjectsWithTag("Open");

        foreach (Card card in deck) // ������Ÿ�� ���� in 
        {
            if (card.gameObject.activeSelf == true) 
            {
                //Debug.Log($"{card.name}");
                card.gameObject.SetActive(false);
                
            }
        }       // loop: ����Ʈ ������ Ȱ��ȭ�� ������Ʈ�� ã�� ��Ȱ��ȭ ��Ŵ

        for (int i = 0; i < availableCardSlots.Length; i++) 
        {
            availableCardSlots[i] = true;
        }
    }


}
