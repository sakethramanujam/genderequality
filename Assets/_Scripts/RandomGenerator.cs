using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    int randomNumber;
    // Use this for initialization
    void Start()
    {
        if (this.gameObject.tag == "Male" || this.gameObject.tag == "Female")
        {
            randomNumber = Random.Range(0, 100);

            if (randomNumber < 50)
            {
                Color tmp = this.GetComponent<SpriteRenderer>().color;
                tmp.a = 0f;
                this.GetComponent<SpriteRenderer>().color = tmp;
            }

            else
            {
                Color tmp = this.GetComponent<SpriteRenderer>().color;
                tmp.a = 1f;
                this.GetComponent<SpriteRenderer>().color = tmp;
            }
        }

        else
        {
            randomNumber = Random.Range(0, 100);

            if (randomNumber >= 0 && randomNumber < 25)
            {
                this.transform.localScale = new Vector3(1.26f, .71f,1f);
            }

            else if (randomNumber >= 25 && randomNumber < 50)
            {
                this.transform.localScale = new Vector3(1.51f, .71f,1f);
            }

            else if (randomNumber >= 50 && randomNumber < 75)
            {
                this.transform.localScale = new Vector3(1.76f, .71f,1f);
            }

            else
            {
                this.transform.localScale = new Vector3(2.01f, .71f, 1f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
