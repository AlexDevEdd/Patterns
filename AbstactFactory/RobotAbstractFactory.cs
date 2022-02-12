using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotAbstractFactory : MonoBehaviour
{
    public abstract GameObject CreateRobotStandart();
    public abstract GameObject CreateRobotModernized();
}
