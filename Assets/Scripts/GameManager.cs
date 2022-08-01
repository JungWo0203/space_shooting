using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject meteor;
    [SerializeField] private Rigidbody2D Rigid;
    // Start is called before the first frame update
    void Start()
    {
        /*Rigid = GetComponent<Rigidbody2D>();*/
        StartCoroutine("player_attack");
        StartCoroutine("meteor_create");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator meteor_create()
    {
        for (; ; )
        {
            Instantiate(meteor,new Vector3(Random.Range(-2.5f,2.5f),5.5f, 0), meteor.transform.rotation);
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator player_attack()
    {
        for (; ; )
        {
            Instantiate(bullet,new Vector3(player.transform.position.x,player.transform.position.y+1.3f), player.transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
