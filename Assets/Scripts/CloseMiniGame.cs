using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseMiniGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp() {
        // transform.parent.gameObject.GetComponent<MiniGame>().Show(false);
        GlobalState.instance.glaceExit = true;
        SceneManager.LoadScene("Planets");
    }
}
