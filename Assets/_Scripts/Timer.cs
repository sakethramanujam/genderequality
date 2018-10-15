using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float inittime;
    float time;
    float timeDecre;
    public Slider slider;
    int i;
    int j;
    int k;
    int l;
    int randomNumber;
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
        time = inittime;
        timeDecre = 0;
        _text.text = "";
        maleGoal = GameObject.FindGameObjectWithTag("MaleGoal");
        femaleGoal = GameObject.FindGameObjectWithTag("FemaleGoal");
        male = GameObject.FindGameObjectsWithTag("Male");
        female = GameObject.FindGameObjectsWithTag("Female");
        i = 0;
        j = 0;
        k = 0;
        l = 0;
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

        else if (time < 0)
        {
            if (i == 0)
            {
                checkEquity();
                i++;
            }
        }

        if (canCheck)
        {
            if (j == k && (maleGoal.transform.localScale.x == femaleGoal.transform.localScale.x))
            {
                l++;
                Debug.Log("Success");
                _text.text = "Streak : " + l.ToString() ;
                randomTeam();
                randomGoal();
                if (timeDecre <= 15)
                {
                    timeDecre += 3;
                }
                time = inittime - timeDecre;
                slider.maxValue = time;
                i = 0;
                canCheck = false;
            }

            else
            {
                Debug.Log("Failed");
                _text.text = "Streak : " + l.ToString() + " GameOver";
                canCheck = false;
            }
        }
    }

    public void checkEquity()
    {
        foreach (GameObject i in male)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if (tmp.a == 1)
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

    public void randomTeam()
    {
        foreach (GameObject p in male)
        {
            randomNumber = Random.Range(0, 100);

            if (randomNumber < 50)
            {
                Color tmp = p.GetComponent<SpriteRenderer>().color;
                tmp.a = 0f;
                p.GetComponent<SpriteRenderer>().color = tmp;
            }

            else
            {
                Color tmp = p.GetComponent<SpriteRenderer>().color;
                tmp.a = 1f;
                p.GetComponent<SpriteRenderer>().color = tmp;
            }
        }

        foreach (GameObject p in female)
        {
            randomNumber = Random.Range(0, 100);

            if (randomNumber < 50)
            {
                Color tmp = p.GetComponent<SpriteRenderer>().color;
                tmp.a = 0f;
                p.GetComponent<SpriteRenderer>().color = tmp;
            }

            else
            {
                Color tmp = p.GetComponent<SpriteRenderer>().color;
                tmp.a = 1f;
                p.GetComponent<SpriteRenderer>().color = tmp;
            }
        }
    }

    public void randomGoal()
    {
        for(int i =0;i<2;i++)
        {
            if(i==0)
            {
                randomNumber = Random.Range(0, 100);

                if (randomNumber >= 0 && randomNumber < 25)
                {
                    maleGoal.transform.localScale = new Vector3(8.5f, 2.87041f, 4.020913f);
                }

                else if (randomNumber >= 25 && randomNumber < 50)
                {
                    maleGoal.transform.localScale = new Vector3(10f, 2.87041f, 4.020913f);
                }

                else if (randomNumber >= 50 && randomNumber < 75)
                {
                    maleGoal.transform.localScale = new Vector3(11.5f, 2.87041f, 4.020913f);
                }

                else
                {
                    maleGoal.transform.localScale = new Vector3(13f, 2.87041f, 4.020913f);
                }
            }

            else
            {
                randomNumber = Random.Range(0, 100);

                if (randomNumber >= 0 && randomNumber < 25)
                {
                    femaleGoal.transform.localScale = new Vector3(8.5f, 2.87041f, 4.020913f);
                }

                else if (randomNumber >= 25 && randomNumber < 50)
                {
                    femaleGoal.transform.localScale = new Vector3(10f, 2.87041f, 4.020913f);
                }

                else if (randomNumber >= 50 && randomNumber < 75)
                {
                    femaleGoal.transform.localScale = new Vector3(11.5f, 2.87041f, 4.020913f);
                }

                else
                {
                    femaleGoal.transform.localScale = new Vector3(13f, 2.87041f, 4.020913f);
                }
            }
        }
    }
}
