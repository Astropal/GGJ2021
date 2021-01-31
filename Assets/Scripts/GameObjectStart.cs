using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectStart : MonoBehaviour {

    private GameObject[] gameObjectList;

    public static int error = 0;
    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("croix1").transform.localPosition = new Vector3(-6, 0, 1);
        GameObject.Find("croix2").transform.localPosition = new Vector3(-2, 0, 1);
        GameObject.Find("croix3").transform.localPosition = new Vector3(2, 0, 1);
        GameObject.Find("croix4").transform.localPosition = new Vector3(6, 0, 1);
        gameObjectList = GameObject.FindGameObjectsWithTag("ObjectGames");

        foreach (GameObject test in gameObjectList)
        {
            test.GetComponent<ClickManager>().levelObject.toFound = false;
            test.GetComponent<ClickManager>().levelObject.isFound = false;
        }



        int numberOfObject = gameObjectList.Length;
        List<int> objectIdSelected = new List<int>();
        for(int i = 0; i < 4; i++) {
            int numberRdm = Random.Range(0, numberOfObject);
            if(!objectIdSelected.Contains(numberRdm)) {
                gameObjectList[numberRdm].GetComponent<ClickManager>().levelObject.toFound = true;
            } else {
                i--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
