using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //public Deck deckObj;
    public bool isCard = default(bool);

    // Start is called before the first frame update
    void Start()
    {
        //deckObj = FindObjectOfType<Deck>();

        // Find == ������Ʈ �̸����� ã��
        // FindObjectOfType == ��ũ��Ʈ �̸����� ã��
        // FindGameObjectWithTag == �±� �̸����� ã��
    }

    public virtual void MoveToDiscard() 
    {
        //deckObj.disCard.Add(this);
        //gameObject.SetActive(false); 
    }

    


}
