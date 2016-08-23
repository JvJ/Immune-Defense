using UnityEngine;
using System.Collections;

namespace ImmuneDefense
{
    /// <summary>
    /// This class represents the enemies.
    /// </summary>
    public class Creeper : MonoBehaviour {

        [SerializeField]
        private CreeperStats Stats; 

	    // Use this for initialization
	    void Start () {
	
	    }
	
	    // Update is called once per frame
	    void Update () {
	
	    }
    }

    /// <summary>
    /// Represents the creeper's various capacities
    /// </summary>
    [System.Serializable]
    public struct CreeperStats
    {
        public float speed;
        public float defense;
        public float hp;
        public float fireDefense;
    }
}