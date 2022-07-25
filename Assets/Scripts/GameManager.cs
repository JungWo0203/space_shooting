using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("player_attack");
    }

    // Update is called once per frame
    void Update()
    {
        
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
