using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickManager : MonoBehaviour {

    public Object levelObject;


    private void OnMouseDown() {
        TriggerObject(this.gameObject);
    }

    void TriggerObject(GameObject gameObject) 
    {
        if(gameObject.GetComponent<ClickManager>().levelObject.toFound) {
            Debug.Log("WP !");
        } else {
            UpdateError();
            //Destroy(gameObject);
        }
    }

    private void  UpdateError() {
        GameObjectStart.error ++;
        switch (GameObjectStart.error)
        {
            case 1:
                GameObject.Find("croix1").transform.localPosition = new Vector3(-6, 0, -1);
                break;
            case 2:
                GameObject.Find("croix2").transform.localPosition = new Vector3(-2, 0, -1);
                break;
            case 3:
                GameObject.Find("croix3").transform.localPosition = new Vector3(2, 0, -1);
                break;
            case 4:
                GameObject.Find("croix4").transform.localPosition = new Vector3(6, 0, -1);
                break;
        }
    }

}
