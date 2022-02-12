using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotWorkerFactory : RobotAbstractFactory
{
    private Transform _spawnPoint;
    public RobotWorkerFactory(Transform spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }
    public override GameObject CreateRobotStandart()
    {

        var standartRobotWorkerPrefab = Resources.Load<GameObject>("Worker1");
        var standartRobotWorker = Instantiate(standartRobotWorkerPrefab, _spawnPoint.position, Quaternion.identity);
        return standartRobotWorker;
    }
    public override GameObject CreateRobotModernized()
    {
        var modernizedRobotWorkerPrefab = Resources.Load<GameObject>("Worker2");
        var modernizedRobotWorker = Instantiate(modernizedRobotWorkerPrefab, _spawnPoint.position, Quaternion.identity);
        return modernizedRobotWorker;
    }
   
}
