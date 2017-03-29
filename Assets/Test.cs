
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {
        
        int[] array = new int[5];
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;
        for (int a = 0; a <= 4; a++)
        {
            Debug.Log(array[a]);
                }
            for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        } 

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}