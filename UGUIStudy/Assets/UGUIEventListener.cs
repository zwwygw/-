using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;

public class UGUIEventListener :EventTrigger{
    public UnityAction<GameObject> onClick;
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        if (onClick != null)
        {
            onClick(gameObject);
        }
    }

    static public UGUIEventListener Get(GameObject go)
    {
        UGUIEventListener listener = go.GetComponent<UGUIEventListener>();
        if (listener == null)
        {
            listener = go.AddComponent<UGUIEventListener>();
        }
        return listener;
    }

}
