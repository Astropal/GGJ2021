using UnityEngine;
using System.Collections;

public class ClickManager : MonoBehaviour {

    public Object test;
    private void OnMouseDown() {
        TriggerObject(this.gameObject);
    }

        void TriggerObject(GameObject gameObject) 
    {
        Debug.Log(gameObject.name);
        Debug.Log(test.name);
    }

}
