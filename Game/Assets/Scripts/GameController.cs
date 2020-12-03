using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public InfoHUD infoHUD;

    // Need to add all enemies to destory them later
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private List<GameObject> enemyList = new List<GameObject>();

    protected static List<string> enemyTag = new List<string>(); // Tags of enemies to destroy
    protected static bool isDead = false;

    protected static Vector3 playerSpawn = new Vector3(19.5f, 0.75f, -17.5f);

    public float decreaseStamina = 10; //per second

    // Start is called before the first frame update
    void Start()
    {
        enemyList.Add(enemy1);
        enemyList.Add(enemy2);
        enemyList.Add(enemy3);

        // Destory enemies that have already been defeated upon restarting scene
        if (isDead)
        {
            foreach (GameObject enemy in enemyList)
            {
                foreach(string tag in enemyTag)              
                if (enemy.gameObject.CompareTag(tag))
                {
                    Destroy(enemy);
                }
            }
        }

        player.transform.position = playerSpawn;
        infoHUD.SetHUD();
    }

    private void Update()
    {
        infoHUD.setHP();
        infoHUD.setMP();

        PlayerStats.CurrentStamina -= Time.deltaTime * decreaseStamina;
        if (PlayerStats.CurrentStamina < 0)
            PlayerStats.CurrentStamina = 0;
        infoHUD.setStamina();
    }

    public static void setPlayerSpawn(Vector3 value)
    {
        playerSpawn = value; // Player spawns more back so it does not hit 
        playerSpawn.z -= 1f; // the enemy trigger before it is destroyed
    }

    public static void destroyEnemy(string tag)
    {
        enemyTag.Add(tag);
        isDead = true;
    }
}
