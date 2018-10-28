using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Timer : MonoBehaviour
{
    public float inittime;
    public AudioClip Cheer;
    public AudioClip Boo;
    public AudioSource audsou;
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
    public GameObject panel;
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
            timeText.text = System.Math.Round(time,2).ToString();
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
            if (j == k && (System.Math.Round(maleGoal.transform.localScale.x,2) == System.Math.Round(femaleGoal.transform.localScale.x,2)))
            {
                l++;
                Debug.Log("Success");
                audsou.GetComponent<AudioSource>().PlayOneShot(Cheer,.5f);
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
                audsou.GetComponent<AudioSource>().PlayOneShot(Boo, .5f);
                _text.text = "Streak : " + l.ToString() + "  GameOver";
                panel.SetActive(true);
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
                    maleGoal.transform.localScale = new Vector3(1.26f, .71f, 1f);
                }

                else if (randomNumber >= 25 && randomNumber < 50)
                {
                    maleGoal.transform.localScale = new Vector3(1.51f, .71f, 1f);
                }

                else if (randomNumber >= 50 && randomNumber < 75)
                {
                    maleGoal.transform.localScale = new Vector3(1.76f, .71f, 1f);
                }

                else
                {
                    maleGoal.transform.localScale = new Vector3(2.01f, .71f, 1f);
                }
            }

            else
            {
                randomNumber = Random.Range(0, 100);

                if (randomNumber >= 0 && randomNumber < 25)
                {
                    femaleGoal.transform.localScale = new Vector3(1.26f, .71f, 1f);
                }

                else if (randomNumber >= 25 && randomNumber < 50)
                {
                    femaleGoal.transform.localScale = new Vector3(1.51f, .71f, 1f);
                }

                else if (randomNumber >= 50 && randomNumber < 75)
                {
                    femaleGoal.transform.localScale = new Vector3(1.76f, .71f, 1f);
                }

                else
                {
                    femaleGoal.transform.localScale = new Vector3(2.01f, .71f, 1f);
                }
            }
        }
    }
}
