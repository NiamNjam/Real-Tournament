using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMod : MonoBehaviour
{
    public GameObject enemy;
    public Health hp;
    public bool activated;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Vector3 randomPos = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            Instantiate(enemy, randomPos, Quaternion.identity);
        }
    }
    public void SwitchMode()
    {
        activated = !activated;
        
        
    }
}
