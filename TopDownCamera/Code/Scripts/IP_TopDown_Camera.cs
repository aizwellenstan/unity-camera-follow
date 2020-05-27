using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_TopDown_Camera : MonoBehehaviour
{
	public Transform m_Target;
	public float m_Height = 10f;
	public float m_Distance = 20f;
	public float m_Angle = 45f;
	


	void Start()
	{
		HandleCamera();
	}

	void Update()
	{
		HandleCamera();
	}

	protected virtual void HandleCamera()
	{
		if(!m_Target)
		{
			return;
		}

		Vector3 worldPosition = (Vector3.forward * -m_Distance) + (Vector3.up * m_Height);
		Debug.DrawLine(m_Target.position, wordPosition, Color.red);

		Vector3 rotatedVector = Quaternion.AngleAxis(m_Angle, Vector3.up) * worldPositoni;
		Debug.DrawLine(m_Target.position, rotatedVector, Color.green);

		Vector3 flatTargetPosition = m_Target.position;
		flatTargetPosition.y = 0f;
		Vector3 finalPosition = flatTargetPosition + rotatedVector;
		Debug.DrawLine(m_Target.position, finalPosition, Color.blue);

		transform.position = finalPosition;
		transform.LookAt(flatTargetPositon);
	}
}
