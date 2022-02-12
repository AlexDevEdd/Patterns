using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;

    private RobotAbstractFactory _factory;
    public void CreateStandartWorkerRobot()
    {
        _factory = new RobotWorkerFactory(_point1);
        _factory.CreateRobotStandart();
    }
    public void CreateModernizedWorkerRobot()
    {
        _factory = new RobotWorkerFactory(_point1);
        _factory.CreateRobotModernized();      
    }
    public void CreateStandartWarriorRobot()
    {
        _factory = new RobotWarriorFactory(_point2);
        _factory.CreateRobotStandart();
    }
    public void CreateModernizedWarriorRobot()
    {
        _factory = new RobotWarriorFactory(_point2);
        _factory.CreateRobotModernized();
    }
}
