using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mining : MonoBehaviour
{
    private Rigidbody2D rb;
    private MapMaker mapMaker;
    public List<GameObject> dirt, stone, silver, gold, diamond, hardrock = new List<GameObject>();

    [SerializeField] private LayerMask mineMask;
    public bool hasMined;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mapMaker = GameObject.Find("MapGenerator").GetComponent<MapMaker>();
    }

    public void blockType(string BlockName, GameObject ore)
    {
        hasMined = true;
        switch (BlockName)
        {
            case "dirt":
                dirt.Add(ore);
                break;
            case "stone":
                stone.Add(ore);
                break;
            case "silver":
                silver.Add(ore);
                break;
            case "gold":
                gold.Add(ore);
                break;
            case "diamond":
                diamond.Add(ore);
                break;
            case "hardrock":
                hardrock.Add(ore);
                break;
            default:
                break;
        }
    }

    public void mine(Vector2 direction)
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, direction, 1.5f, mineMask);
        if (ray)
        {
            Vector2 pos = ray.collider.transform.position;
            blockType(mapMaker.map[(int)pos.x, (int)-pos.y].name, mapMaker.map[(int)pos.x, (int)-pos.y]);
            Destroy(mapMaker.map[(int)pos.x, (int)-pos.y]);
        }
        
        //blockType(mapMaker.map[(int)transform.position.x, (int)(-transform.position.y + 1.5)].name, mapMaker.map[(int)transform.position.x, (int)(-transform.position.y + 1.5)]);
        //Destroy(mapMaker.map[(int)transform.position.x, (int)(-transform.position.y + 1.5)]);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            mine(Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mine(Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            mine(Vector2.right);
        }
    }
}
