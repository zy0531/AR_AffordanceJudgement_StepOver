using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoleSpace : MonoBehaviour
{
    public int TranslateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 amountToMove = (GameObject.Find("Gap").transform.position - GameObject.Find("First Person Camera").transform.position).normalized;
        //Each time you can change 5cm
        Vector3 amountToMove = new Vector3(0f, 0f, 1/2f);
        Vector3 GapPos = GameObject.Find("Gap").transform.position;
        Vector3 PreviousZscale = GameObject.Find("Gap").transform.localScale;
        GameObject.Find("PlaneDiscovery/CanvasPET/Inward").GetComponent<Button>().onClick.AddListener(() =>
        {
            GameObject.Find("Gap").transform.localScale = new Vector3(PreviousZscale.x, PreviousZscale.y, PreviousZscale.z - amountToMove.z / 10);
            GameObject.Find("Gap").transform.position = Vector3.Lerp(GapPos, GapPos - amountToMove / 20, 1);
        }
        );
        GameObject.Find("PlaneDiscovery/CanvasPET/Outward").GetComponent<Button>().onClick.AddListener(() =>
        {
            GameObject.Find("Gap").transform.localScale = new Vector3(PreviousZscale.x, PreviousZscale.y, PreviousZscale.z + amountToMove.z / 10);
            GameObject.Find("Gap").transform.position = Vector3.Lerp(GapPos, GapPos + amountToMove / 20, 1);
        }
        );
    }

}
