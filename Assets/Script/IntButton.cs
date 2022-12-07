using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IntButton : MonoBehaviour //this scripts the buttons using the Event System
{
    private GameObject lastSelect;
    
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = 0;
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
