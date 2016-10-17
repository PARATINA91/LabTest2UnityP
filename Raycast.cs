using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour
{
    public GameObject myPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                float x = .1f;
                float y = 5.0f;
                float z = 0.0f;
                GameObject Cube1 = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
             //   Cube2.GetComponentInChildren<TextMesh>().text = product.ReadingID;
                Destroy(this.gameObject);
            }
        }
    }
}
