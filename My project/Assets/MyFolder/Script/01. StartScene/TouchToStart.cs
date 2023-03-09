using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TouchToStart : MonoBehaviour, IPointerDownHandler
{
    public string sceneName;

    public void OnPointerDown(PointerEventData eventData)
    {
        
        SceneManager.LoadScene(sceneName);

    }



    //public void gameStart() 
    //{
    //    if (Input.GetMouseButtonDown(0)) 
    //    {
    //        SceneManager.LoadScene(sceneName);
    //    }
    //}

}
