using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    [SerializeField] private Slider HpBar;
    [SerializeField] private float hp;
    [SerializeField] private float hpDrain;
    [SerializeField] private float maxhp, minhp;
    [SerializeField] private float damageDepth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < damageDepth)
        {
            hp-= hpDrain * Time.deltaTime;
        }
        else
        {
            hp+= hpDrain * Time.deltaTime;
        }
        hp = Mathf.Clamp(hp, minhp, maxhp);
        HpBar.value = hp;

        if (hp <= minhp)
        {
            SceneManager.LoadScene(0);
        }
    }
}
