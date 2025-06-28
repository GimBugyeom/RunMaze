using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;

    public List<Exititem> exitItems = new List<Exititem>();
    public bool CanExit = false;

    public TextMeshProUGUI getItemList;

    public List<GameObject> lockedwall = new List<GameObject>();

    private void Start()
    {
        Instance = this;
    }
    public void UpdateItem()
    {
        for (int i = 0; i < exitItems.Count; i++)
        {
            if (exitItems[i].isActivate == true)
            {
                getItemList.text += exitItems[i].ItemName;
            }
        }
    }

    public bool GetAllKey()
    {
        for (int i = 0; i < exitItems.Count; i++)
        {
            if (exitItems[i].isActivate == false)
            {
                return false;
            }
        }

        return true;
    }

    public void GetKey()
    {
        UpdateItem();
        CanExit = GetAllKey();

        if (CanExit)
        {
            foreach (GameObject g in lockedwall)
            {
                g.SetActive(false);
            }
        }
    }
}
