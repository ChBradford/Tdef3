using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maintower : MonoBehaviour
{
    public HealthBar hpscript;
    public float health = 3;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            UnityEngine.Ray raycaster = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(raycaster, out hit))
            {
                if (hit.collider.name == "Cube")
                {
                    hpscript.GetComponent<HealthBar>().hpdeplete();
                    health--;
                    if (health <= 0)
                    {
                        Destroy(hit.collider.gameObject);
                        CoinManager.coincount++;
                    }
                }
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            health--;
        }
    }
}
