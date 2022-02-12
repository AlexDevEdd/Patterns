using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotWarriorFactory : RobotAbstractFactory
{
    private Transform _spawnPoint;
    public RobotWarriorFactory(Transform spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }
    public override GameObject CreateRobotStandart()
    {

        var standartRobotWarriorPrefab = Resources.Load<GameObject>("Warrior1");
        var standartRobotWarrior = Instantiate(standartRobotWarriorPrefab, _spawnPoint.position, Quaternion.identity);
        return standartRobotWarrior;
    }
    public override GameObject CreateRobotModernized()
    {
        var modernizedRobotWarriorPrefab = Resources.Load<GameObject>("Warrior2");
        var modernizedRobotWarrior = Instantiate(modernizedRobotWarriorPrefab, _spawnPoint.position, Quaternion.identity);
        Destroy(modernizedRobotWarrior, 5f);
        return modernizedRobotWarrior;
    }
}
