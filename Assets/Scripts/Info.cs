using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI infoText;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = transform.position - Player.transform.position;
        float dotSameDirection = dotProduct(Player.transform.forward.normalized, transform.forward.normalized);
        float dotBehind = dotProduct(transform.forward.normalized, -distance);
        if (dotSameDirection > 0 && dotBehind < 0)
        {
            infoText.text = "BackStab";
        }
        else
        {
            infoText.text = "Not the same";
        }
        Debug.Log(dotSameDirection);
    }
    private float dotProduct(Vector3 a, Vector3 b)
    {
        return a.x*b.x + a.y * b.y + a.z*b.z;
    }
}
