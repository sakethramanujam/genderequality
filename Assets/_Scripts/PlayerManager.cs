using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    GameObject[] male;
    GameObject[] female;
    GameObject maleGoal;
    GameObject femaleGoal;
    // Use this for initialization
    void Start()
    {
        male = GameObject.FindGameObjectsWithTag("Male");
        female = GameObject.FindGameObjectsWithTag("Female");
        maleGoal = GameObject.FindGameObjectWithTag("MaleGoal");
        femaleGoal = GameObject.FindGameObjectWithTag("FemaleGoal");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void maleIncrement()
    {
        //male = GameObject.FindGameObjectsWithTag("Male");

        foreach(GameObject i in male)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if(tmp.a==0)
            {
                tmp.a = 1f;
                i.GetComponent<SpriteRenderer>().color = tmp;
                break;
            }
        }
    }

    public void maleDecrement()
    {
        //male = GameObject.FindGameObjectsWithTag("Male");

        foreach (GameObject i in male)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if (tmp.a == 1f)
            {
                tmp.a = 0;
                i.GetComponent<SpriteRenderer>().color = tmp;
                break;
            }
        }
    }

    public void femaleIncrement()
    {
        //female = GameObject.FindGameObjectsWithTag("Female");

        foreach (GameObject i in female)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if (tmp.a == 0)
            {
                tmp.a = 1f;
                i.GetComponent<SpriteRenderer>().color = tmp;
                break;
            }
        }
    }

    public void femaleDecrement()
    {
        //female = GameObject.FindGameObjectsWithTag("Female");

        foreach (GameObject i in female)
        {
            Color tmp = i.GetComponent<SpriteRenderer>().color;
            if (tmp.a == 1f)
            {
                tmp.a = 0;
                i.GetComponent<SpriteRenderer>().color = tmp;
                break;
            }
        }
    }

    public void maleGoalIncrement()
    {
        if(maleGoal.transform.localScale.x<=13f)
            maleGoal.transform.localScale += new Vector3(1.5f, 0, 0);
    }

    public void maleGoalDecrement()
    {
        if (maleGoal.transform.localScale.x >= 7f)
            maleGoal.transform.localScale -= new Vector3(1.5f, 0, 0);
    }

    public void femaleGoalIncrement()
    {
        if (maleGoal.transform.localScale.x <= 13f)
            femaleGoal.transform.localScale += new Vector3(1.5f, 0, 0);
    }

    public void femaleGoalDecrement()
    {
        if (maleGoal.transform.localScale.x >= 7f)
            femaleGoal.transform.localScale -= new Vector3(1.5f, 0, 0);
    }

    public void reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
