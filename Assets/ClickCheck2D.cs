using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCheck2D : MonoBehaviour {

    public GameObject CardFront;
    public GameObject Shuffle;
    public string cardbackName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clicked = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D colD = Physics2D.OverlapPoint(clicked);
            if (colD)
            {
                RaycastHit2D hit2D = Physics2D.Raycast(clicked, -Vector2.up);
                if (hit2D)
                {
                    //Debug.Log("hit object is " + hit2D.collider.gameObject.name);
                    for (int i = 0; i < 10; i ++ ){
                        if ( hit2D.collider.gameObject.name == cardbackName + i.ToString()){
                            //Debug.Log("Hit!!!!!!");
                            //Debug.Log(i);

                            int index = Shuffle.GetComponent<Shuffle>().getShuffledIndex(i);
                            CardFront.GetComponent<SpriteRenderer>().sprite = Shuffle.GetComponent<Shuffle>().spriteArray[index];
                        }
                    }
                }
            }
        }
	}
}
