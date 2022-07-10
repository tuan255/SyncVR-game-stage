using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIblockCount : MonoBehaviour
{
    [SerializeField] public Text blockcount;
    [SerializeField] private mining mine;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        mine = GameObject.Find("Player").GetComponent<mining>();
        blockcount = GetComponentInChildren<Text>();
        updateText();
    }

    public void updateText()
    {
        switch (gameObject.name)
        {
            case "dirt":
                if (!checkifchanged(count, mine.dirt.Count))
                    return;
                blockcount.text = mine.dirt.Count.ToString();
                mine.hasMined = false;
                break;
            case "stone":
                if (!checkifchanged(count, mine.stone.Count))
                    return;

                blockcount.text = mine.stone.Count.ToString();
                mine.hasMined = false;
                break;
            case "silver":
                if (!checkifchanged(count, mine.silver.Count))
                    return;

                blockcount.text = mine.silver.Count.ToString();
                mine.hasMined = false;
                break;
            case "gold":
                if (!checkifchanged(count, mine.gold.Count))
                    return;

                blockcount.text = mine.gold.Count.ToString();
                mine.hasMined = false;
                break;
            case "diamond":
                if (!checkifchanged(count, mine.diamond.Count))
                    return;

                blockcount.text = mine.diamond.Count.ToString();
                mine.hasMined = false;
                break;
            default:
                break;
        }
    }

    public bool checkifchanged(int previous, int current)
    {
        if (current != previous)
        {
            count = current;
            return true;
        }
        return false;

    }

    // Update is called once per frame
    void Update()
    {
        if (mine.hasMined)
        {
            updateText();
        }
    }
}
