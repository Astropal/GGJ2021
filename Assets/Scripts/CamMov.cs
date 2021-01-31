using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour
{
    public float ScrSpeed=10f, ZoneMorte=0.95f, ZoomIn=10f, ZoomOut=100f;
    public bool mov = true;

    void Start()
    {
        
    }

	void Update ()
	{
        if (Input.GetMouseButtonDown (0))
		{
            mov = false;
        }

        if (Input.GetMouseButtonUp (0))
		{
            mov = true;
        }

        if(mov == true)
        {
            float Molette;
            Vector2 MPos=Vector3.zero;
            Vector3 ScrMove=transform.position;
            
            
            Molette = Input.GetAxis("Mouse ScrollWheel")*20;
            
            if(ScrMove.y-Molette>=ZoomIn && ScrMove.y-Molette<=ZoomOut)
            {
                ScrMove.y -= Molette;
            }
            if(ScrMove.y<ZoomIn) {ScrMove.y = ZoomIn;}
            if(ScrMove.y>ZoomOut) {ScrMove.y = ZoomOut;}
            
            
            MPos.Set(Input.mousePosition.x/Screen.width,Input.mousePosition.y/Screen.height);

            
            if(MPos.x < 1-ZoneMorte)
            {
                ScrMove.x-=Time.deltaTime*ScrSpeed*ScrMove.y/10;
            }
            else if(MPos.x > ZoneMorte)
            {
                ScrMove.x +=Time.deltaTime*ScrSpeed*ScrMove.y/10;
            }
            
            
            if(MPos.y < 1-ZoneMorte)
            {
                ScrMove.y-=Time.deltaTime*ScrSpeed*ScrMove.y/10;
            }
            else if(MPos.y > ZoneMorte)
            {
                ScrMove.y +=Time.deltaTime*ScrSpeed*ScrMove.y/10;
            }

            transform.position =ScrMove;
        }
	}
}
