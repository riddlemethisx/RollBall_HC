using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ObjectPool : MonoBehaviour
{

    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    }



    [SerializeField] public Pool[] pools = null;                                         //edit�rden ekledi�imiz objeler burada tutuluyor


    private void Awake()                                                                 //oyun daha ba�lat�lmadan �nceki aktarma i�lemi
    {



        CreatePool();

    }


    public void CreatePool()
    {
        for (int j = 0; j < pools.Length; j++)                                          //pools yap�s�ndaki t�m elemanlar� pooledObjects ad�ndaki objectPool'a aktar�yoruz.
        {
            pools[j].pooledObjects = new Queue<GameObject>();

            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                obj.SetActive(false);

                pools[j].pooledObjects.Enqueue(obj);
            }
        }
    }






    public GameObject GetPooledObject(int objectType)
    {
        if (objectType >= pools.Length)
        {
            return null;
        }




        GameObject obj = pools[objectType].pooledObjects.Dequeue();
      
        obj.SetActive(true);
        
        pools[objectType].pooledObjects.Enqueue(obj);
        return obj;
    }



}
