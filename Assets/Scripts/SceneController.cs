using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AssemblyCSharp.Assets.Scripts
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] 
        private GameObject enemyPrefab;

        private GameObject _enemy;

        void Update()
        {
            if ( _enemy == null ) {
                _enemy = Instantiate(enemyPrefab) as GameObject;
                _enemy.transform.position = new Vector3( 0, 1, 0 );
                float angle = Random.Range(0, 360);
                _enemy.transform.Rotate( 0, angle, 0 );

            }
        }
    }
}
