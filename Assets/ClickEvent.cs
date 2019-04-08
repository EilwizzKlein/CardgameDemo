using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour {
    public GameObject[] cube1;
    // Use this for initialization
    void Start () {
       
            AddObjectClickEvent(GameObject .Find ("TESTCUBE"));

        }
    
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddObjectClickEvent(GameObject itemObject)
    {
        var box = itemObject.GetComponent<BoxCollider>();
        if (box == null) {
            box = itemObject.AddComponent<BoxCollider>();
        }                // ThreeD_Object为3D物体挂载的脚本       
        var item = itemObject.GetComponent<testcard>();
        if (item == null)        {
            item = itemObject.AddComponent<testcard>();
        }
        EventTrigger trigger = itemObject.GetComponent<EventTrigger>();
        if (trigger == null)
        {
            trigger = itemObject.AddComponent<EventTrigger>();
        }
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        UnityEngine.Events.UnityAction<BaseEventData> click = new UnityEngine.Events.UnityAction<BaseEventData>(item.OnClickCubeItem);
        entry.callback.AddListener(click);
        trigger.triggers.Clear();
        trigger.triggers.Add(entry);
    }
        
}
