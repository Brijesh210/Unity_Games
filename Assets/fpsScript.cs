using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class fpsScript : MonoBehaviour
{
    private int count;
    public Text point;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        point.text = " Total Point :" + count.ToString();
        win.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        point.text = " Total Point :" + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("box"))
        {

            count++;
            other.gameObject.SetActive(false);
            Debug.Log("collision with box" + "total count: " + count.ToString());
            point.text = " Total Point :" + count.ToString();

        }

        if (other.gameObject.CompareTag("coin"))
        {
            count+=2;
            other.gameObject.SetActive(false);
            Debug.Log("collision with coin" + "total count: " + count.ToString());
            point.text = " Total Point :" + count.ToString();
        }
        if(count >5)
        {
            Debug.Log("Win!");
            win.text = "You Won!";
        }
        

    }
}
