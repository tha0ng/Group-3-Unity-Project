using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IntButton : MonoBehaviour
{
    private GameObject lastSelect;
    
    void Start()
    {
        lastSelect = new GameObject();
    }

   void Update()
   {
       if(EventSystem.current.currentSelectedGameObject == null)
       {
            EventSystem.current.SetSelectedGameObject(lastSelect);
       }
       else
       {
            lastSelect = EventSystem.current.currentSelectedGameObject;
       }
   }
}
