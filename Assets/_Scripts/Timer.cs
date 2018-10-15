using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Slider slider;
    int i;
    int j;
    int k;
    GameObject[] male;
    GameObject[] female;
    GameObject maleGoal;
    GameObject femaleGoal;
    bool canCheck;
    public Text _text;
    public Text timeText;
    // Use this for initialization
    void Start()
    {
        _text.text = "";
        maleGoal = GameObject.FindGameObjectWithTag("MaleGoal");
        femaleGoal = GameObject.FindGameObjectWithTag("FemaleGoal");
        i = 0;
        j = 0;
        k = 0;
        slider.maxValue = 20f;
        slider.minValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            slider.value = time;
            timeText.text = time.ToString();
        }

        else if(time < 0)
        {
            if(i==0)
            {
                checkEquity();
                i++;
            }
        }

        if(canCheck)
        {
            if (j == k && (maleGoal.transform.localScale.x==femaleGoal.transform.localScale.x))
            {
                Debug.Log("Success");
                _text.text = "Success";
                canCheck = false;
            }

            else
            {
                Debug.Log("Failed");
                _text.text = "Failed";
                canCheck = false;
            }
        }
    }

    public void checkEquity()
    {
        male = GameObject.FindGameObjectsWithTag("Male");
        female = GameObject.FindGameObjectsWithTag("Female");

        foreach(GameObject i in male)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if(tmp.a==1)
            {
                j++;
            }
        }

        foreach (GameObject i in female)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if (tmp.a == 1)
            {
                k++;
            }
        }
        canCheck = true;
    }
}
