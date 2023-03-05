using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float xMinMax;
    public float zMin;
    public GameObject rock;
    public int count;
    public float startWait;
    public float cloneWait;
    public float waveWait;


    void Start(){
        StartCoroutine (Waves());
    }
    IEnumerator Waves (){
        while (true){
            yield return new WaitForSeconds(startWait);
            for (int i =0; i <count; i++){
                Instantiate(rock, new Vector3(Random.Range(-xMinMax, xMinMax), 0, zMin), Quaternion.identity);
                yield return new WaitForSeconds(cloneWait);
            }
        }
    }
}