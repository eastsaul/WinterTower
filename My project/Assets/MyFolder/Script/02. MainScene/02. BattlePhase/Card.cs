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

        // Find == 오브젝트 이름으로 찾기
        // FindObjectOfType == 스크립트 이름으로 찾기
        // FindGameObjectWithTag == 태그 이름으로 찾기
    }

    public virtual void MoveToDiscard() 
    {
        //deckObj.disCard.Add(this);
        //gameObject.SetActive(false); 
    }

    


}
