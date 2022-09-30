using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{




    [SerializeField] private ObjectPool objectPool = null;

    public int numberOfTiles = 3;




    private List<GameObject> activeTiles = new List<GameObject>();

    public List<Transform> spawnPoints = new List<Transform>();



    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnBall(0);
            else
            {
                SpawnBall(Random.Range(0, objectPool.pools.Length));
            }
        }
    }

    bool onetime = false;

    private void Update()
    {
        if (!onetime)
        {
            StartCoroutine(Creating());
            onetime = true;
        }

    
        
    }


    IEnumerator Creating()
    {
        SpawnBall(Random.Range(0, objectPool.pools.Length));
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Creating());
        
    }

    int counter = 0;
    public void SpawnBall(int ballIndex)
    {
        if (counter == spawnPoints.Count )
            counter = 0;

        var go = objectPool.GetPooledObject(ballIndex);
        go.transform.position = spawnPoints[counter].position;
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * 5000 * Time.fixedDeltaTime, ForceMode.VelocityChange);
        counter++;

        StartCoroutine(DeleteBall());


        activeTiles.Add(go);
    }
    IEnumerator  DeleteBall()
    {
        yield return new WaitForSeconds(6f);
        Destroy(activeTiles[0]);

        activeTiles.RemoveAt(0);

    }




}
