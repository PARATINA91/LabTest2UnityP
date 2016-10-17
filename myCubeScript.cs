using UnityEngine;
using System.Collections;

public class myCubeScript : MonoBehaviour
{

    public float ratateSpeed =0f;
    public Vector3 spinSpeed = new Vector3(2f, 2f, 2f);
    Vector3 spinAxis = new Vector3(0f, 2f, 0f);


    // Use this for initialization
    void Start()
    {
        //   spinSpeed = new Vector3(Random.value, Random.value, Random.value);
       spinAxis = Vector3.up;
       spinAxis.x =  0.1f;
    }

/*    public void setSize(float size)
    {
        this.transform.localScale = new Vector3(.1f, .1f, .1f);
    }

    public void setPlace(float place)
    {
        this.transform.position = new Vector3(place, place, place);
         } 
    
    
    */ 
    // Update is called once per frame
    void Update()
    {
       this.transform.Rotate(spinSpeed);
    //   this.transform.RotateAround(Vector3.zero, Vector3.up, ratateSpeed);
    }
}
