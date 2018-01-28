using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {
  private ViveGrip_ControllerHandler controller;
  private float oldXRotation;
  private int VIBRATION_DURATION_IN_MILLISECONDS = 50;
  private float MAX_VIBRATION_STRENGTH = 0.7f;
  private float MAX_VIBRATION_ANGLE = 35f;
	private bool alreadyPulled = false;

  GlobalScript globalScript;

  void Start () {
    oldXRotation = transform.eulerAngles.x;
  }

  void ViveGripGrabStart(ViveGrip_GripPoint gripPoint) {
    controller = gripPoint.controller;
  }

  void ViveGripGrabStop() {
    controller = null;
  }

  void Update () {
    float newXRotation = transform.eulerAngles.x;
    if (controller != null) {
      float distance = Mathf.Min(Mathf.Abs(newXRotation - oldXRotation), MAX_VIBRATION_ANGLE);
      float vibrationStrength = (distance / MAX_VIBRATION_ANGLE) * MAX_VIBRATION_STRENGTH;
      controller.Vibrate(VIBRATION_DURATION_IN_MILLISECONDS, vibrationStrength);
    }
    oldXRotation = newXRotation;

		if (newXRotation < - 160.0f && !alreadyPulled)
	{
			globalScript.switchesToPull -= 1;
			alreadyPulled = true;
	}

	if (globalScript.switchesToPull <= 0) {
		// Cut the lights!
	}
  }
}
