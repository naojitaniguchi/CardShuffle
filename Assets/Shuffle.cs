using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour {
    int arraySize;
    int[] indexArray;
    public Sprite[] spriteArray;

	// Use this for initialization
	void Start () {
        arraySize = spriteArray.Length;
        indexArray = new int[arraySize];

        for (int i = 0; i < arraySize; i ++ ){
            indexArray[i] = i;
        }

        for (int i = arraySize - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int tmp = indexArray[i];
            indexArray[i] = indexArray[j];
            indexArray[j] = tmp;
        }

        for (int i = 0; i < arraySize; i ++ ){
            Debug.Log(indexArray[i]);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getShuffledIndex( int i){
        return indexArray[i];
    }
}
